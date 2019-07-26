using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImtiazSuperStore
{
    class InvoiceStoresInfoProduct
    {
        public const string QUERY_SELECT = "SELECT * FROM amjad.invoice_stores_info_product";
        public const string COLUMN_TRANSACTION_NO = "TRANSACTION_NO";
        public const string COLUMN_PRODUCT_ID = "PRODUCT_ID";
        public const string COLUMN_QUANTITY_BOUGHT = "QUANTITY_BOUGHT";

        private static int ROW_COUNT = 0;
        /*
        private static List<Data> data;

        public static Data get(int i) { return data[i]; }

        public class Data
        {
            public string tramsactionNo { get; private set; }
            public int productId { get; private set; }
            public int quantityBought { get; private set; }

            public Data(string tramsactionNo, int productId, int quantityBought)
            {
                this.tramsactionNo = tramsactionNo;
                this.productId = productId;
                this.quantityBought = quantityBought;
            }
        }

        public static bool LoadInfo()
        {
            User.CrudPrivilege privilege;

            User.tablesPrivilege.map.TryGetValue("INVOICE_STORES_INFO_PRODUCT", out privilege);

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
                                reader[COLUMN_TRANSACTION_NO].ToString(),
                                reader[COLUMN_PRODUCT_ID]),
                                reader[COLUMN_QUANTITY_BOUGHT])
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
                gridView.Rows.Add(dataItem.tramsactionNo, dataItem.productId, dataItem.quantityBought);
        }
        */
        public static bool LoadData(DataGridView gridView)
        {
            if (!User.dba)
            {
                User.CrudPrivilege privilege;

                User.tablesPrivilege.map.TryGetValue("INVOICE_STORES_INFO_PRODUCT", out privilege);

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
                                reader[COLUMN_TRANSACTION_NO].ToString(),
                                reader[COLUMN_PRODUCT_ID].ToString(),
                                reader[COLUMN_QUANTITY_BOUGHT].ToString()
                            );

                            ROW_COUNT++;
                        }
                    }

                }
            }

            return true;
        }

        public static void Delete(string transactionNo, int productId)
        {
            using (OracleConnection connection = new OracleConnection(Program.superConnectionString))
            {
                connection.Open();

                OracleCommand command;

                command = new OracleCommand($"DELETE FROM invoice_stores_info_product " +
                    $"WHERE ({COLUMN_TRANSACTION_NO}='{transactionNo}' AND {COLUMN_PRODUCT_ID}={productId})", connection);
                command.ExecuteNonQuery();
            }

        }
    }


}
