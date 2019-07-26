using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImtiazSuperStore
{
    class SurveillanceCamera
    {
        private const string QUERY_SELECT = "SELECT * FROM amjad.survelliance_camera";
        public const string COLUMN_CAMERA_NO = "CAMERA_NO";
        public const string COLUMN_FlOOR_NO = "FlOOR_NO";

        private static int ROW_COUNT = 0;
        /*
        private static List<Data> data;

        public static Data get(int i) { return data[i]; }

        public class Data
        {
            public int cameraNo { get; private set; }
            public int floorNo { get; private set; }

            public Data(int cameraNo, int floorNo)
            {
                this.cameraNo = cameraNo;
                this.floorNo = floorNo;
            }
        }

        public static bool LoadInfo()
        {
            User.CrudPrivilege privilege;

            User.tablesPrivilege.map.TryGetValue("SURVELLIANCE_CAMERA", out privilege);

            if(User.dba==false)
            if (privilege == null || !privilege.Select) return false;
            data = new List<Data>();

            using (OracleConnection connection = new OracleConnection(Program.superConnectionString))
            {
                using (OracleCommand command = new OracleCommand(QUERY_SELECT, connection))
                {
                    command.Connection.Open();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new Data(
                                reader[COLUMN_CAMERA_NO]),
                                reader[COLUMN_FlOOR_NO])
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
                gridView.Rows.Add(dataItem.cameraNo, dataItem.floorNo);
        }
        */
        public static bool LoadData(DataGridView gridView)
        {
            if (!User.dba)
            {
                User.CrudPrivilege privilege;

                User.tablesPrivilege.map.TryGetValue("SURVELLIANCE_CAMERA", out privilege);

                if (User.dba == false)
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
                                reader[COLUMN_CAMERA_NO].ToString(),
                                reader[COLUMN_FlOOR_NO].ToString()
                            );

                            ROW_COUNT++;
                        }
                    }
                }
            }

            return true;
        }

        public static void Delete(int cameraNo)
        {
            using (OracleConnection connection = new OracleConnection(Program.superConnectionString))
            {
                connection.Open();

                OracleCommand command;

                command = new OracleCommand($"UPDATE counter SET {Counter.COLUMN_CAMERA_NO}=null " +
                    $"WHERE {Counter.COLUMN_CAMERA_NO}={cameraNo}",
                    connection);
                command.ExecuteNonQuery();

                command = new OracleCommand($"DELETE FROM survelliance_camera WHERE {COLUMN_CAMERA_NO}={cameraNo}", connection);
                command.ExecuteNonQuery();
            }

        }
    }
}
