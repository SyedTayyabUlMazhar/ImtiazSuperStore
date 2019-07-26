using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImtiazSuperStore
{
    class Counter
    {
        public const string QUERY_SELECT = "SELECT * FROM counter";
        public const string COLUMN_COUNTER_NO = "COUNTER_NO";
        public const string COLUMN_CAMERA_NO = "CAMERA_NO";
        public const string COLUMN_CNIC = "CNIC";
        private static int ROW_COUNT = 0;
        /*
        private static List<Data> data;
        public class Data
        {
            public int counterNo { get; private set; }
            public int cameraNo { get; private set; }
            public string cnic { get; private set; }

            public Data(int counterNo, int cameraNo, string cnic)
            {
                this.counterNo = counterNo;
                this.cameraNo = cameraNo;
                this.cnic = cnic;
            }

        }
        public static Data get(int i) { return data[i]; }

        public static bool LoadInfo()
        {
            User.CrudPrivilege privilege;

            User.tablesPrivilege.map.TryGetValue("COUNTER", out privilege);

            if (User.dba == false)
                if (privilege == null || !privilege.Select) return false;
            data = new List<Data>();

            using (OracleConnection connection = new OracleConnection(Program.superConnectionString))
            {
                using (OracleCommand command = new OracleCommand(QUERY_SELECT, connection))
                {
                    command.Connection.Open();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            data.Add(new Data(
                                reader[COLUMN_COUNTER_NO]),
                                reader[COLUMN_CAMERA_NO]),
                                reader[COLUMN_CNIC].ToString())
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
                gridView.Rows.Add(dataItem.counterNo, dataItem.cameraNo, dataItem.cnic);
        }
        */
        public static bool LoadData(DataGridView gridView)
        {
            if (!User.dba)
            {
                User.CrudPrivilege privilege;

                User.tablesPrivilege.map.TryGetValue("COUNTER", out privilege);

                if (privilege == null || !privilege.Select) return false;
            }

            using (OracleConnection connection = new OracleConnection(Program.superConnectionString))
            {
                using (OracleCommand command = new OracleCommand(QUERY_SELECT, connection))
                {
                    command.Connection.Open();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            gridView.Rows.Add(
                                reader[COLUMN_COUNTER_NO].ToString(),
                                reader[COLUMN_CAMERA_NO].ToString(),
                                reader[COLUMN_CNIC].ToString()
                                );

                            ROW_COUNT++;
                        }
                    }
                }
            }

            return true;
        }


        public static int getRowCount() { return ROW_COUNT; }

        public static void Delete(int counterNo)
        {
            using (OracleConnection connection = new OracleConnection(Program.superConnectionString))
            {
                connection.Open();

                OracleCommand command;

                command = new OracleCommand($"UPDATE invoice_1 SET {Invoice.COLUMN_COUNTER_NO}=null " +
                    $"WHERE {Invoice.COLUMN_COUNTER_NO}={counterNo}",
                    connection);
                command.ExecuteNonQuery();

                command = new OracleCommand($"DELETE FROM counter WHERE {COLUMN_COUNTER_NO}={counterNo}", connection);
                command.ExecuteNonQuery();
            }

        }


    }
}
