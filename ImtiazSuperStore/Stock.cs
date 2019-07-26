using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImtiazSuperStore
{
    class Stock
    {
        private const string QUERY_SELECT = "SELECT * FROM amjad.stock";
        private const string COLUMN_DATE_ARRIVED = "DATE_ARRIVED";
        private const string COLUMN_COST = "COST";

        private static int ROW_COUNT = 0;

        /*
        private static List<Data> data;

        public static Data get(int i) { return data[i]; }

        public class Data
        {
            public string dateArrived { get; private set; }
            public int cost { get; private set; }

            public Data(string dateArrived, int cost)
            {
                this.dateArrived = dateArrived;
                this.cost = cost;
            }

        }

        public static bool LoadInfo()
        {
            User.CrudPrivilege privilege;

            User.tablesPrivilege.map.TryGetValue("STOCK", out privilege);

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
                                reader[COLUMN_COST])
                                )
                            );

                            ROW_COUNT++;
                        }
                    }
                }

                return true;
            }
        }
        public static void FillGridView(DataGridView gridView)
        {
            foreach (Data dataItem in data)
                gridView.Rows.Add(dataItem.dateArrived, dataItem.cost);
        }
        */

        public static bool LoadData(DataGridView gridView)
        {
            if (!User.dba)
            {
                User.CrudPrivilege privilege;

                User.tablesPrivilege.map.TryGetValue("STOCK", out privilege);

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
                                reader[COLUMN_COST].ToString()
                            );

                            ROW_COUNT++;
                        }
                    }
                }

            }
            return true;
        }

        public static void Delete(string dateArrived)
        {
            using (OracleConnection connection = new OracleConnection(Program.superConnectionString))
            {
                connection.Open();

                OracleCommand command;

                command = new OracleCommand($"DELETE FROM stock WHERE {COLUMN_DATE_ARRIVED}='{dateArrived}'",
                    connection);
                command.ExecuteNonQuery();

                command = new OracleCommand($"DELETE FROM stock_contains_product WHERE {StockContainsProduct.COLUMN_DATE_ARRIVED}='{dateArrived}'", connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
