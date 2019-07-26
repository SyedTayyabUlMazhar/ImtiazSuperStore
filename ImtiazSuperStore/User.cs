using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Oracle.ManagedDataAccess.Client;

namespace ImtiazSuperStore
{
    class User
    {
        public static string connectionString;
        public static string username;
        public static TablesPrivilege tablesPrivilege;
        public static bool dba { get; private set; }

        public class TablesPrivilege
        {
            private string QUERY = $"SELECT table_name, privilege FROM dba_tab_privs WHERE grantee IN " +
                $"( SELECT granted_role FROM dba_role_privs WHERE upper(grantee)=upper('{username}'))";

            public Dictionary<string, CrudPrivilege> map;

            public void LoadPrivileges()
            {
                if(String.Compare(username.ToUpper(), "AMJAD")==0)
                {
                    dba = true;
                    return;
                }
                map = new Dictionary<string, CrudPrivilege>();

                using (OracleConnection connection = new OracleConnection(Program.superConnectionString))
                {
                    using (OracleCommand command = new OracleCommand(QUERY, connection))
                    {
                        command.Connection.Open();

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                string tableName = reader["table_name"].ToString();
                                string privilege = reader["privilege"].ToString();

                                if(!map.ContainsKey(tableName))
                                {
                                    map.Add(tableName, new CrudPrivilege());
                                }

                                CrudPrivilege crudPrivilege;
                                map.TryGetValue(tableName, out crudPrivilege);
                                crudPrivilege.SetPrivilege(privilege);
                            }

                        }
                    }
                }
            }
        }
        public class CrudPrivilege
        {
            public bool Select = false;
            public bool Insert = false;
            public bool Update = false;
            public bool Delete = false;

            public void SetPrivilege(string privilege)
            {
                switch(privilege)
                {
                    case "SELECT": Select = true; break;
                    case "INSERT": Insert = true; break;
                    case "UPDATE": Update = true; break;
                    case "DELETE": Delete = true; break;
                    default: break;
                }
            }

        }

        public static bool Connect(string username, string password)
        {
            User.username = username;
            bool connectionStatus = true;

            connectionString = $"USER ID={username}; PASSWORD={password}; DATA SOURCE=XE;";

            //verify the user and password is valid
            OracleConnection connection = new OracleConnection(connectionString);
            try
            {
                connection.Open();
                connection.Close();

            }catch(OracleException exception)
            {
                connectionStatus = false;
            }

            if (connectionStatus)
            {
                tablesPrivilege = new TablesPrivilege();
                tablesPrivilege.LoadPrivileges();
            }

            return connectionStatus;
        }
        

    }
}
