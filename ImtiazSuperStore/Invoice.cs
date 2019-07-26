using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImtiazSuperStore
{
    class Invoice
    {
        private const string QUERY_SELECT = "SELECT * FROM amjad.invoice_1 NATURAL JOIN amjad.invoice_2";

        public const string COLUMN_BARCODE = "BARCODE";
        public const string COLUMN_TRANSACTION_NO = "TRANSACTION_NO";
        public const string COLUMN_COUNTER_NO = "COUNTER_NO";
        public const string COLUMN_TRANSACTION_DATE = "TRANSACTION_DATE";
        public const string COLUMN_TOTAL_ITEMS = "TOTAL_ITEMS";
        public const string COLUMN_TOTAL_DISCOUNT = "TOTAL_DISCOUNT";
        public const string COLUMN_INVOICE_VALUE = "INVOICE_VALUE";
        public const string COLUMN_CASH = "CASH";
        public const string COLUMN_CHANGE_DUE = "CHANGE_DUE";
        public const string COLUMN_TOTAL_QUANTITY = "TOTAL_QUANTITY";

        private static int ROW_COUNT = 0;

        /*
        private static List<Data> data = new List<Data>();

        public static Data get(int i) { return data[i]; }

        public class Data
        {
            public string barcode { get; private set; }
            public string transactionNo { get; private set; }
            public int counterNo { get; private set; }
            public string transactionDate { get; private set; }
            public int totalItems { get; private set; }
            public int totalDiscount { get; private set; }
            public int invoiceValue { get; private set; }
            public int cash { get; private set; }
            public int changeDue { get; private set; }
            public int totalQuantity { get; private set; }

            public Data(string barcode, string transactionNo, int counterNo, string transactionDate, int totalItems, 
                int totalDiscount, int invoiceValue, int cash, int changeDue, int totalQuantity)
            {
                this.barcode = barcode;
                this.transactionNo = transactionNo;
                this.counterNo = counterNo;
                this.transactionDate = transactionDate;
                this.totalItems = totalItems;
                this.totalDiscount = totalDiscount;
                this.invoiceValue = invoiceValue;
                this.cash = cash;
                this.changeDue = changeDue;
                this.totalQuantity = totalQuantity;
            }
        }


        public static bool LoadInfo()
        {
            User.CrudPrivilege privilege;

            User.tablesPrivilege.map.TryGetValue("INVOICE_1", out privilege);

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
                                    reader[COLUMN_BARCODE].ToString(),
                                    reader[COLUMN_TRANSACTION_NO].ToString(),
                                    reader[COLUMN_COUNTER_NO]),
                                    reader[COLUMN_TRANSACTION_DATE].ToString(),
                                    reader[COLUMN_TOTAL_ITEMS]),
                                    reader[COLUMN_TOTAL_DISCOUNT]),
                                    reader[COLUMN_INVOICE_VALUE]),
                                    reader[COLUMN_CASH]),
                                    reader[COLUMN_CHANGE_DUE]),
                                    reader[COLUMN_TOTAL_QUANTITY])
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
                gridView.Rows.Add(dataItem.barcode, dataItem.transactionNo, dataItem.counterNo, dataItem.transactionDate,
                    dataItem.totalItems, dataItem.totalDiscount, dataItem.invoiceValue, dataItem.cash, dataItem.changeDue,
                    dataItem.totalQuantity);
        }
        */
        public static bool LoadData(DataGridView gridView)
        {
            if (!User.dba)
            {
                User.CrudPrivilege privilege;

                User.tablesPrivilege.map.TryGetValue("INVOICE_1", out privilege);
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
                                    reader[COLUMN_BARCODE].ToString(),
                                    reader[COLUMN_TRANSACTION_NO].ToString(),
                                    reader[COLUMN_COUNTER_NO].ToString(),
                                    reader[COLUMN_TRANSACTION_DATE].ToString(),
                                    reader[COLUMN_TOTAL_ITEMS].ToString(),
                                    reader[COLUMN_TOTAL_DISCOUNT].ToString(),
                                    reader[COLUMN_INVOICE_VALUE].ToString(),
                                    reader[COLUMN_CASH].ToString(),
                                    reader[COLUMN_CHANGE_DUE].ToString(),
                                    reader[COLUMN_TOTAL_QUANTITY].ToString()
                            );

                            ROW_COUNT++;
                        }
                    }
                }
            }

            return true;

        }

        public static void Delete(string transactionNo, string barcode)
        {
            using (OracleConnection connection = new OracleConnection(Program.superConnectionString))
            {
                connection.Open();

                OracleCommand command;
                OracleDataReader reader;

                command = new OracleCommand($"DELETE FROM invoice_1 WHERE {COLUMN_TRANSACTION_NO}='{transactionNo}'",
                    connection);
                command.ExecuteNonQuery();

                command = new OracleCommand($"DELETE FROM invoice_2 WHERE {COLUMN_BARCODE}='{barcode}'", connection);
                command.ExecuteNonQuery();

                command = new OracleCommand(
                    $"DELETE FROM invoice_stores_info_product WHERE {InvoiceStoresInfoProduct.COLUMN_TRANSACTION_NO}='{transactionNo}'",
                    connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
