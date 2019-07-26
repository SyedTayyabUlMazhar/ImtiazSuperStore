using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImtiazSuperStore
{
    class Floor
    {
        private const string QUERY_SELECT = "SELECT * FROM amjad.floor";
        private const string COLUMN_FlOOR_NO = "FlOOR_NO";
        private const string COLUMN_PRODUCT_CATEGORY = "PRODUCT_CATEGORY";

        private static int ROW_COUNT = 0;

        /*
        private static List<Data> data;

        public static Data get(int i) { return data[i]; }

        public class Data
        {
            public int floorNo { get; private set; }
            public string productCategory { get; private set; }

            public Data(int floorNo, string productCategory)
            {
                this.floorNo = floorNo;
                this.productCategory = productCategory;
            }
        }

        public static bool LoadInfo()
        {
            User.CrudPrivilege privilege;

            User.tablesPrivilege.map.TryGetValue("FLOOR", out privilege);
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
                        while (reader.Read())
                        {
                            data.Add(new Data(
                                reader[COLUMN_FlOOR_NO]),
                                reader[COLUMN_PRODUCT_CATEGORY].ToString()
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
                gridView.Rows.Add(dataItem.floorNo, dataItem.productCategory);
        }
        */

        public static bool LoadData(DataGridView gridView)
        {
            if (!User.dba)
            {
                User.CrudPrivilege privilege;

                User.tablesPrivilege.map.TryGetValue("FLOOR", out privilege);
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
                                reader[COLUMN_FlOOR_NO].ToString(),
                                reader[COLUMN_PRODUCT_CATEGORY].ToString()
                                );

                            ROW_COUNT++;
                        }
                    }
                }
            }

            return true;
        }

        public static void Delete(int floorNo)
        {
            using (OracleConnection connection = new OracleConnection(Program.superConnectionString))
            {
                connection.Open();

                OracleCommand command;

                command = new OracleCommand($"UPDATE product_2 SET {Product.COLUMN_FLOOR_NO}=null " +
                    $"WHERE {Product.COLUMN_FLOOR_NO}={floorNo}",
                    connection);
                command.ExecuteNonQuery();

                command = new OracleCommand($"UPDATE survelliance_camera SET {SurveillanceCamera.COLUMN_FlOOR_NO}=null " +
                    $"WHERE {Product.COLUMN_FLOOR_NO}={floorNo}", connection);
                command.ExecuteNonQuery();


                command = new OracleCommand($"DELETE FROM floor WHERE {COLUMN_FlOOR_NO}={floorNo}", connection);
                command.ExecuteNonQuery();
            }

        }
    }
}
