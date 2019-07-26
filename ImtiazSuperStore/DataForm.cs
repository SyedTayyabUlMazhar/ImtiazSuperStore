using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImtiazSuperStore
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();

            if(!Employee.LoadData(dataGridViewEmployee)) tabPageEmployee.Dispose();

            if (!Product.LoadData(dataGridViewProduct)) tabPageProduct.Dispose();

            if (!Invoice.LoadData(dataGridViewInvoice)) tabPageInvoice.Dispose();

            if (!Stock.LoadData(dataGridViewStock)) tabPageStock.Dispose();

            if (!Floor.LoadData(dataGridViewFloor)) tabPageFloor.Dispose();

            if (!Counter.LoadData(dataGridViewCounter)) tabPageCounter.Dispose();

            if (!SurveillanceCamera.LoadData(dataGridViewSurveillanceCamera)) tabPageSurveillanceCamera.Dispose();

            if (!StockContainsProduct.LoadData(dataGridViewStockDetail)) tabPageStockDetail.Dispose();

            if (!InvoiceStoresInfoProduct.LoadData(dataGridViewInvoiceDetail)) tabPageInvoiceDetail.Dispose();

            dataGridViewEmployee.AllowUserToDeleteRows = checkPrivilege(Privilege.DELETE, "EMPLOYEE_1");
            dataGridViewEmployee.UserDeletedRow += DataGridViewEmployee_UserDeletedRow;

            dataGridViewProduct.AllowUserToDeleteRows = checkPrivilege(Privilege.DELETE, "PRODUCT_1");
            dataGridViewProduct.UserDeletedRow += DataGridViewEmployee_UserDeletedRow;

            dataGridViewInvoice.AllowUserToDeleteRows = checkPrivilege(Privilege.DELETE, "INVOICE_1");
            dataGridViewInvoice.UserDeletedRow += DataGridViewEmployee_UserDeletedRow;

            dataGridViewStock.AllowUserToDeleteRows = checkPrivilege(Privilege.DELETE, "STOCK");
            dataGridViewStock.UserDeletedRow += DataGridViewEmployee_UserDeletedRow;

            dataGridViewFloor.AllowUserToDeleteRows = checkPrivilege(Privilege.DELETE, "FLOOR");
            dataGridViewFloor.UserDeletedRow += DataGridViewEmployee_UserDeletedRow;

            dataGridViewCounter.AllowUserToDeleteRows = checkPrivilege(Privilege.DELETE, "COUNTER");
            dataGridViewCounter.UserDeletedRow += DataGridViewEmployee_UserDeletedRow;

            dataGridViewSurveillanceCamera.AllowUserToDeleteRows = checkPrivilege(Privilege.DELETE, "SURVELLIANCE_CAMERA");
            dataGridViewSurveillanceCamera.UserDeletedRow += DataGridViewEmployee_UserDeletedRow;

            dataGridViewStockDetail.AllowUserToDeleteRows = checkPrivilege(Privilege.DELETE, "STOCK_CONTAINS_PRODUCT");
            dataGridViewStockDetail.UserDeletedRow += DataGridViewEmployee_UserDeletedRow;

            dataGridViewInvoiceDetail.AllowUserToDeleteRows = checkPrivilege(Privilege.DELETE, "INVOICE_STORES_INFO_PRODUCT");
            dataGridViewInvoiceDetail.UserDeletedRow += DataGridViewEmployee_UserDeletedRow;
        }

        private void DataGridViewEmployee_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
           
            DataGridView gridView = (DataGridView)sender;

            if(gridView==dataGridViewEmployee)
            {
                string cnic = e.Row.Cells[5].Value.ToString();
                Employee.Delete(cnic);

                dataGridViewCounter.Rows.Clear();
                Counter.LoadData(dataGridViewCounter);
                return;
            }

            if(gridView==dataGridViewProduct)
            {
                //MessageBox.Show("dataGridViewProduct");
                Product.Delete(Convert.ToInt32(e.Row.Cells[1].Value), e.Row.Cells[0].Value.ToString());

                dataGridViewInvoiceDetail.Rows.Clear();
                dataGridViewStockDetail.Rows.Clear();

                InvoiceStoresInfoProduct.LoadData(dataGridViewInvoiceDetail);
                StockContainsProduct.LoadData(dataGridViewStockDetail);
                return;
            }

            if (gridView ==dataGridViewInvoice)
            {
                Invoice.Delete(e.Row.Cells[1].Value.ToString(), e.Row.Cells[0].Value.ToString());

                dataGridViewInvoiceDetail.Rows.Clear();
                InvoiceStoresInfoProduct.LoadData(dataGridViewInvoiceDetail);
                return;
            }

            if (gridView ==dataGridViewStock)
            {
                Stock.Delete(e.Row.Cells[0].Value.ToString());

                dataGridViewStockDetail.Rows.Clear();
                StockContainsProduct.LoadData(dataGridViewStockDetail);
                return;
            }

            if (gridView ==dataGridViewFloor)
            {
                //MessageBox.Show("dataGridViewFloor");
                Floor.Delete(Convert.ToInt32(e.Row.Cells[0].Value));

                dataGridViewProduct.Rows.Clear();
                Product.LoadData(dataGridViewProduct);

                dataGridViewSurveillanceCamera.Rows.Clear();
                SurveillanceCamera.LoadData(dataGridViewSurveillanceCamera);
                return;
            }

            if (gridView ==dataGridViewCounter)
            {
                //MessageBox.Show("dataGridViewCounter");
                Counter.Delete(Convert.ToInt32(e.Row.Cells[0].Value));

                dataGridViewInvoice.Rows.Clear();
                Invoice.LoadData(dataGridViewInvoice);

                
                return;
            }

            if (gridView ==dataGridViewSurveillanceCamera)
            {
                //MessageBox.Show("dataGridViewSurveillanceCamera");
                SurveillanceCamera.Delete(Convert.ToInt32(e.Row.Cells[0].Value));

                dataGridViewCounter.Rows.Clear();
                Counter.LoadData(dataGridViewCounter);
                return;
            }

            if (gridView ==dataGridViewStockDetail)
            {
                //MessageBox.Show("dataGridViewStockDetail");
                StockContainsProduct.Delete(e.Row.Cells[0].Value.ToString(), Convert.ToInt32(e.Row.Cells[1].Value));

                return;
            }

            if (gridView ==dataGridViewInvoiceDetail)
            {
                //MessageBox.Show("dataGridViewInvoiceDetail");
                InvoiceStoresInfoProduct.Delete(e.Row.Cells[0].Value.ToString(), Convert.ToInt32(e.Row.Cells[1].Value));

                return;
            }







        }


        public bool checkPrivilege(string privilege, string tableName)
        {
            if (User.dba) return true;

            User.CrudPrivilege crudPrivilege;
            User.tablesPrivilege.map.TryGetValue(tableName, out crudPrivilege);

            if (crudPrivilege == null) return false;

            switch(privilege)
            {
                case Privilege.SELECT: return crudPrivilege.Select;
                case Privilege.INSERT: return crudPrivilege.Insert;
                case Privilege.UPDATE: return crudPrivilege.Update;
                case Privilege.DELETE: return crudPrivilege.Delete;
                default: return false;
            }
        }
    }
}
