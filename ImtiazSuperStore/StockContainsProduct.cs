using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImtiazSuperStore
{
    class StockContainsProduct
    {
        public const string QUERY_SELECT = "SELECT * FROM amjad.stock_contains_product";
        public const string COLUMN_DATE_ARRIVED = "DATE_ARRIVED";
        public const string COLUMN_PRODUCT_ID = "PRODUCT_ID";
        public const string COLUMN_QUANTITY = "QUANTITY";

        private static int ROW_COUNT = 0;
        /*
        private static List<Data> data;

        public static Data get(int i) { return data[i]; }

        public class Data
        {
            public string dateArrived { get; private set; }
            public int productId { get; private set; }
            public int quantity { get; private set; }

            public Data(string dateArrived, int productId, int quantity)
            {
                this.dateArrived = dateArrived;
                this.productId = productId;
                this.quantity = quantity;
            }
        }

        public static bool LoadInfo()
        {
            User.CrudPrivilege privilege;

            User.tablesPrivilege.map.TryGetValue("STOCK_CONTAINS_PRODUCT", out privilege);

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
                                reader[COLUMN_DATE_ARRIVED].ToString(),
                                reader[COLUMN_PRODUCT_ID]),
                                reader[COLUMN_QUANTITY])
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
                gridView.Rows.Add(dataItem.dateArrived, dataItem.productId, dataItem.quantity);
        }
        */
        public static bool LoadData(DataGridView gridView)
        {
            if (!User.dba)
            {
                User.CrudPrivilege privilege;

                User.tablesPrivilege.map.TryGetValue("STOCK_CONTAINS_PRODUCT", out privilege);

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
                                reader[COLUMN_DATE_ARRIVED].ToString(),
                                reader[COLUMN_PRODUCT_ID].ToString(),
                                reader[COLUMN_QUANTITY].ToString()
                                );

                            ROW_COUNT++;
                        }
                    }
                }
            }

            return true;
        }

        public static void Delete(string dateArrived, int productId)
        {
            using (OracleConnection connection = new OracleConnection(Program.superConnectionString))
            {
                connection.Open();

                OracleCommand command;

                command = new OracleCommand($"DELETE FROM stock_contains_product " +
                    $"WHERE ({COLUMN_DATE_ARRIVED}='{dateArrived}' AND {COLUMN_PRODUCT_ID}={productId})", connection);
                command.ExecuteNonQuery();
            }

        }
    }
}
