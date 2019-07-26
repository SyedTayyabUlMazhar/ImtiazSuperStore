using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImtiazSuperStore
{
    class Employee
    {
        private const string QUERY_SELECT = "SELECT * FROM amjad.employee_1 NATURAL JOIN amjad.employee_2" +
            " NATURAL JOIN amjad.employee_3";

        private const string COLUMN_E_NAME = "E_NAME";
        private const string COLUMN_POSITION = "POSITION";
        private const string COLUMN_SALARY = "SALARY";
        private const string COLUMN_ADDRESS = "ADDRESS";
        private const string COLUMN_CONTACT_NO = "CONTACT_NO";
        private const string COLUMN_CNIC = "CNIC";

        private static int ROW_COUNT = 0;

        /*
        private static List<Data> data = new List<Data>();

        public static Data get(int i) { return data[i]; }
        public class Data
        {
            public string e_name { get; private set; }
            public string position { get; private set; }
            public int salary { get; private set; }
            public string address { get; private set; }
            public string contactNo { get; private set; }
            public string cnic { get; private set; }

            public Data(string e_name, string position, int salary, string address, string contactNo, string cnic)
            {
                this.e_name = e_name;
                this.position = position;
                this.salary = salary;
                this.address = address;
                this.contactNo = contactNo;
                this.cnic = cnic;
            }

        }
        public static bool LoadInfo()
        {
            if (User.dba == false)
            {
                User.CrudPrivilege privilege;

                User.tablesPrivilege.map.TryGetValue("EMPLOYEE_1", out privilege);


                if (privilege == null || !privilege.Select) return false;
            }
            data = new List<Data>();

            using (OracleConnection connection = new OracleConnection(User.connectionString))
            {
                using (OracleCommand command = new OracleCommand(QUERY_SELECT, connection))
                {
                    command.Connection.Open();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(
                                new Data(
                                    reader[COLUMN_E_NAME].ToString(),
                                    reader[COLUMN_POSITION].ToString(),
                                    reader[COLUMN_SALARY]),
                                    reader[COLUMN_ADDRESS].ToString(),
                                    reader[COLUMN_CONTACT_NO].ToString(),
                                    reader[COLUMN_CNIC].ToString()
                                    )
                            );

                            ROW_COUNT++;
                        }
                    }
                }
            }

            return true;
        }
        public static void FillGridView(DataGridView gridView)
        {
            foreach (Data dataItem in data)
                gridView.Rows.Add(dataItem.e_name, dataItem.position, dataItem.salary,dataItem.address,
                    dataItem.contactNo, dataItem.cnic);
        }
        */

        public static bool LoadData(DataGridView gridView)
        {
            if (!User.dba)
            {
                User.CrudPrivilege privilege;

                User.tablesPrivilege.map.TryGetValue("EMPLOYEE_1", out privilege);


                if (privilege == null || !privilege.Select) return false;
            }

            using (OracleConnection connection = new OracleConnection(User.connectionString))
            {
                using (OracleCommand command = new OracleCommand(QUERY_SELECT, connection))
                {
                    command.Connection.Open();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            gridView.Rows.Add(
                                reader[COLUMN_E_NAME].ToString(),
                                reader[COLUMN_POSITION].ToString(),
                                reader[COLUMN_SALARY].ToString(),
                                reader[COLUMN_ADDRESS].ToString(),
                                reader[COLUMN_CONTACT_NO].ToString(),
                                reader[COLUMN_CNIC].ToString()
                                );

                            ROW_COUNT++;
                        }
                    }
                }
            }

            return true;
        }
        public static void Delete(string cnic)
        {
            using (OracleConnection connection = new OracleConnection(Program.superConnectionString))
            {
                connection.Open();

                OracleCommand command;
                OracleDataReader reader;

                command = new OracleCommand($"SELECT {COLUMN_CONTACT_NO} FROM employee_1 WHERE {Employee.COLUMN_CNIC}='{cnic}'",
                    connection);
                reader = command.ExecuteReader();
                reader.Read();
                string contactNo = reader[$"{ COLUMN_CONTACT_NO}"].ToString();

                command = new OracleCommand($"UPDATE counter set {Counter.COLUMN_CNIC}=null WHERE {Counter.COLUMN_CNIC}='{cnic}'", connection);
                command.ExecuteNonQuery();

                command = new OracleCommand($"DELETE FROM employee_1 WHERE {Employee.COLUMN_CNIC}='{cnic}'", connection);
                command.ExecuteNonQuery();

                command = new OracleCommand($"DELETE FROM employee_2 WHERE {Employee.COLUMN_CONTACT_NO}='{contactNo}'", connection);
                command.ExecuteNonQuery();
            }
        }

    }
}
