using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImtiazSuperStore
{
    class Product
    {
        private const string QUERY_SELECT = "SELECT * FROM amjad.product_1 NATURAL JOIN amjad.product_2";

        public const string COLUMN_DESCRIPTION = "DESCRIPTION";
        public const string COLUMN_PRODUCT_ID = "PRODUCT_ID";
        public const string COLUMN_PRICE = "PRICE";
        public const string COLUMN_FLOOR_NO = "FLOOR_NO";

        private static int ROW_COUNT = 0;

        /*
        private static List<Data> data = new List<Data>();

        public static Data get(int i) { return data[i]; }

        public class Data
        {
            public string description { get; private set; }
            public int productId { get; private set; }
            public int price { get; private set; }
            public int floorNo { get; private set; }

            public Data(string description, int productId, int price, int floorNo)
            {
                this.description = description;
                this.productId = productId;
                this.price = price;
                this.floorNo = floorNo;
            }
        }


        public static bool LoadInfo()
        {
            User.CrudPrivilege privilege;

            User.tablesPrivilege.map.TryGetValue("PRODUCT_1", out privilege);

            if (User.dba == false)
                if (privilege == null || !privilege.Select) return false;

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
                                    reader[COLUMN_DESCRIPTION].ToString(),
                                    reader[COLUMN_PRODUCT_ID]),
                                    reader[COLUMN_PRICE]),
                                    reader[COLUMN_FLOOR_NO])
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
                gridView.Rows.Add(dataItem.description, dataItem.productId, dataItem.price, dataItem.floorNo);
        }
        */
        public static bool LoadData(DataGridView gridView)
        {
            if (!User.dba)
            {
                User.CrudPrivilege privilege;

                User.tablesPrivilege.map.TryGetValue("PRODUCT_1", out privilege);

                if (User.dba == false)
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
                                    reader[COLUMN_DESCRIPTION].ToString(),
                                    reader[COLUMN_PRODUCT_ID].ToString(),
                                    reader[COLUMN_PRICE].ToString(),
                                    reader[COLUMN_FLOOR_NO].ToString()
                            );

                            ROW_COUNT++;
                        }
                    }
                }
            }

            return true;
        }

        public static void Delete(int productId, string description)
        {
            using (OracleConnection connection = new OracleConnection(Program.superConnectionString))
            {
                connection.Open();

                OracleCommand command;
                OracleDataReader reader;

                command = new OracleCommand($"DELETE FROM product_1 WHERE {COLUMN_PRODUCT_ID}={productId}",
                    connection);
                command.ExecuteNonQuery();

                command = new OracleCommand($"DELETE FROM product_2 WHERE {COLUMN_DESCRIPTION}='{description}'", connection);
                command.ExecuteNonQuery();

                command = new OracleCommand(
                    $"DELETE FROM invoice_stores_info_product WHERE {InvoiceStoresInfoProduct.COLUMN_PRODUCT_ID}={productId}",
                    connection);
                command.ExecuteNonQuery();

                command = new OracleCommand(
                    $"DELETE FROM stock_contains_product WHERE {StockContainsProduct.COLUMN_PRODUCT_ID}={productId}", connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
