namespace ImtiazSuperStore
{
    partial class DataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.COLUMN_E_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMN_POSITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMN_SALARY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMN_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMN_CONTACT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMN_CNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLOOR_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageInvoice = new System.Windows.Forms.TabPage();
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.BARCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANSACTION_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COUNTER_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANSACTION_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_ITEMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVOICE_VALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CASH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHANGE_DUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageStock = new System.Windows.Forms.TabPage();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.DATE_ARRIVED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageFloor = new System.Windows.Forms.TabPage();
            this.dataGridViewFloor = new System.Windows.Forms.DataGridView();
            this.FLOOR_FlOOR_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCounter = new System.Windows.Forms.TabPage();
            this.dataGridViewCounter = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAMERA_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageSurveillanceCamera = new System.Windows.Forms.TabPage();
            this.dataGridViewSurveillanceCamera = new System.Windows.Forms.DataGridView();
            this.SURVEILLANCE_CAMERA_CAMERA_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SURVEILLANCE_CAMERA_FLOOR_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageStockDetail = new System.Windows.Forms.TabPage();
            this.dataGridViewStockDetail = new System.Windows.Forms.DataGridView();
            this.STOCK_DETAIL_DATE_ARRIVED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOCK_DETAIL_PRODUCT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageInvoiceDetail = new System.Windows.Forms.TabPage();
            this.dataGridViewInvoiceDetail = new System.Windows.Forms.DataGridView();
            this.INVOICE_DETAIL_TRANSACTION_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVOICE_DETAIL_PRODUCT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY_BOUGHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.tabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.tabPageInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            this.tabPageStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.tabPageFloor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor)).BeginInit();
            this.tabPageCounter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCounter)).BeginInit();
            this.tabPageSurveillanceCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSurveillanceCamera)).BeginInit();
            this.tabPageStockDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockDetail)).BeginInit();
            this.tabPageInvoiceDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageEmployee);
            this.tabControl.Controls.Add(this.tabPageProduct);
            this.tabControl.Controls.Add(this.tabPageInvoice);
            this.tabControl.Controls.Add(this.tabPageStock);
            this.tabControl.Controls.Add(this.tabPageFloor);
            this.tabControl.Controls.Add(this.tabPageCounter);
            this.tabControl.Controls.Add(this.tabPageSurveillanceCamera);
            this.tabControl.Controls.Add(this.tabPageStockDetail);
            this.tabControl.Controls.Add(this.tabPageInvoiceDetail);
            this.tabControl.Location = new System.Drawing.Point(1, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(798, 447);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Controls.Add(this.dataGridViewEmployee);
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(790, 421);
            this.tabPageEmployee.TabIndex = 0;
            this.tabPageEmployee.Text = "Employee";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COLUMN_E_NAME,
            this.COLUMN_POSITION,
            this.COLUMN_SALARY,
            this.COLUMN_ADDRESS,
            this.COLUMN_CONTACT_NO,
            this.COLUMN_CNIC});
            this.dataGridViewEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(784, 415);
            this.dataGridViewEmployee.TabIndex = 0;
            // 
            // COLUMN_E_NAME
            // 
            this.COLUMN_E_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COLUMN_E_NAME.HeaderText = "Name";
            this.COLUMN_E_NAME.Name = "COLUMN_E_NAME";
            // 
            // COLUMN_POSITION
            // 
            this.COLUMN_POSITION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COLUMN_POSITION.HeaderText = "Position";
            this.COLUMN_POSITION.Name = "COLUMN_POSITION";
            // 
            // COLUMN_SALARY
            // 
            this.COLUMN_SALARY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COLUMN_SALARY.HeaderText = "Salary";
            this.COLUMN_SALARY.Name = "COLUMN_SALARY";
            // 
            // COLUMN_ADDRESS
            // 
            this.COLUMN_ADDRESS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COLUMN_ADDRESS.HeaderText = "Address";
            this.COLUMN_ADDRESS.Name = "COLUMN_ADDRESS";
            // 
            // COLUMN_CONTACT_NO
            // 
            this.COLUMN_CONTACT_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COLUMN_CONTACT_NO.HeaderText = "Contact No";
            this.COLUMN_CONTACT_NO.Name = "COLUMN_CONTACT_NO";
            // 
            // COLUMN_CNIC
            // 
            this.COLUMN_CNIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COLUMN_CNIC.HeaderText = "CNIC";
            this.COLUMN_CNIC.Name = "COLUMN_CNIC";
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.dataGridViewProduct);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 22);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(790, 421);
            this.tabPageProduct.TabIndex = 1;
            this.tabPageProduct.Text = "Product";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DESCRIPTION,
            this.PRODUCT_ID,
            this.PRICE,
            this.FLOOR_NO});
            this.dataGridViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProduct.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.Size = new System.Drawing.Size(784, 415);
            this.dataGridViewProduct.TabIndex = 0;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRIPTION.HeaderText = "Description";
            this.DESCRIPTION.Name = "DESCRIPTION";
            // 
            // PRODUCT_ID
            // 
            this.PRODUCT_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRODUCT_ID.HeaderText = "Product ID";
            this.PRODUCT_ID.Name = "PRODUCT_ID";
            // 
            // PRICE
            // 
            this.PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRICE.HeaderText = "Price";
            this.PRICE.Name = "PRICE";
            // 
            // FLOOR_NO
            // 
            this.FLOOR_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FLOOR_NO.HeaderText = "Floor No";
            this.FLOOR_NO.Name = "FLOOR_NO";
            // 
            // tabPageInvoice
            // 
            this.tabPageInvoice.Controls.Add(this.dataGridViewInvoice);
            this.tabPageInvoice.Location = new System.Drawing.Point(4, 22);
            this.tabPageInvoice.Name = "tabPageInvoice";
            this.tabPageInvoice.Size = new System.Drawing.Size(790, 421);
            this.tabPageInvoice.TabIndex = 2;
            this.tabPageInvoice.Text = "Invoice";
            this.tabPageInvoice.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.AllowUserToAddRows = false;
            this.dataGridViewInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BARCODE,
            this.TRANSACTION_NO,
            this.COUNTER_NO,
            this.TRANSACTION_DATE,
            this.TOTAL_ITEMS,
            this.TOTAL_DISCOUNT,
            this.INVOICE_VALUE,
            this.CASH,
            this.CHANGE_DUE,
            this.TOTAL_QUANTITY});
            this.dataGridViewInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInvoice.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.ReadOnly = true;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(790, 421);
            this.dataGridViewInvoice.TabIndex = 0;
            // 
            // BARCODE
            // 
            this.BARCODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BARCODE.HeaderText = "Barcode";
            this.BARCODE.Name = "BARCODE";
            // 
            // TRANSACTION_NO
            // 
            this.TRANSACTION_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TRANSACTION_NO.HeaderText = "Transaction No";
            this.TRANSACTION_NO.Name = "TRANSACTION_NO";
            // 
            // COUNTER_NO
            // 
            this.COUNTER_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COUNTER_NO.HeaderText = "Counter No";
            this.COUNTER_NO.Name = "COUNTER_NO";
            // 
            // TRANSACTION_DATE
            // 
            this.TRANSACTION_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TRANSACTION_DATE.HeaderText = "Transaction Date";
            this.TRANSACTION_DATE.Name = "TRANSACTION_DATE";
            // 
            // TOTAL_ITEMS
            // 
            this.TOTAL_ITEMS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TOTAL_ITEMS.HeaderText = "Total Items";
            this.TOTAL_ITEMS.Name = "TOTAL_ITEMS";
            // 
            // TOTAL_DISCOUNT
            // 
            this.TOTAL_DISCOUNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TOTAL_DISCOUNT.HeaderText = "Total Discount";
            this.TOTAL_DISCOUNT.Name = "TOTAL_DISCOUNT";
            // 
            // INVOICE_VALUE
            // 
            this.INVOICE_VALUE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.INVOICE_VALUE.HeaderText = "Invoice Value";
            this.INVOICE_VALUE.Name = "INVOICE_VALUE";
            // 
            // CASH
            // 
            this.CASH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CASH.HeaderText = "Cash";
            this.CASH.Name = "CASH";
            // 
            // CHANGE_DUE
            // 
            this.CHANGE_DUE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CHANGE_DUE.HeaderText = "Change Due";
            this.CHANGE_DUE.Name = "CHANGE_DUE";
            // 
            // TOTAL_QUANTITY
            // 
            this.TOTAL_QUANTITY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TOTAL_QUANTITY.HeaderText = "Total Quantity";
            this.TOTAL_QUANTITY.Name = "TOTAL_QUANTITY";
            // 
            // tabPageStock
            // 
            this.tabPageStock.Controls.Add(this.dataGridViewStock);
            this.tabPageStock.Location = new System.Drawing.Point(4, 22);
            this.tabPageStock.Name = "tabPageStock";
            this.tabPageStock.Size = new System.Drawing.Size(790, 421);
            this.tabPageStock.TabIndex = 3;
            this.tabPageStock.Text = "Stock";
            this.tabPageStock.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.AllowUserToAddRows = false;
            this.dataGridViewStock.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DATE_ARRIVED,
            this.COST});
            this.dataGridViewStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStock.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.ReadOnly = true;
            this.dataGridViewStock.Size = new System.Drawing.Size(790, 421);
            this.dataGridViewStock.TabIndex = 0;
            // 
            // DATE_ARRIVED
            // 
            this.DATE_ARRIVED.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DATE_ARRIVED.HeaderText = "Date Arrived";
            this.DATE_ARRIVED.Name = "DATE_ARRIVED";
            // 
            // COST
            // 
            this.COST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COST.HeaderText = "Cost";
            this.COST.Name = "COST";
            // 
            // tabPageFloor
            // 
            this.tabPageFloor.Controls.Add(this.dataGridViewFloor);
            this.tabPageFloor.Location = new System.Drawing.Point(4, 22);
            this.tabPageFloor.Name = "tabPageFloor";
            this.tabPageFloor.Size = new System.Drawing.Size(790, 421);
            this.tabPageFloor.TabIndex = 4;
            this.tabPageFloor.Text = "Floor";
            this.tabPageFloor.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFloor
            // 
            this.dataGridViewFloor.AllowUserToAddRows = false;
            this.dataGridViewFloor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFloor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFloor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FLOOR_FlOOR_NO,
            this.PRODUCT_CATEGORY});
            this.dataGridViewFloor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFloor.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFloor.Name = "dataGridViewFloor";
            this.dataGridViewFloor.ReadOnly = true;
            this.dataGridViewFloor.Size = new System.Drawing.Size(790, 421);
            this.dataGridViewFloor.TabIndex = 0;
            // 
            // FLOOR_FlOOR_NO
            // 
            this.FLOOR_FlOOR_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FLOOR_FlOOR_NO.HeaderText = "Floor No";
            this.FLOOR_FlOOR_NO.Name = "FLOOR_FlOOR_NO";
            // 
            // PRODUCT_CATEGORY
            // 
            this.PRODUCT_CATEGORY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRODUCT_CATEGORY.HeaderText = "Product Category";
            this.PRODUCT_CATEGORY.Name = "PRODUCT_CATEGORY";
            // 
            // tabPageCounter
            // 
            this.tabPageCounter.Controls.Add(this.dataGridViewCounter);
            this.tabPageCounter.Location = new System.Drawing.Point(4, 22);
            this.tabPageCounter.Name = "tabPageCounter";
            this.tabPageCounter.Size = new System.Drawing.Size(790, 421);
            this.tabPageCounter.TabIndex = 5;
            this.tabPageCounter.Text = "Counter";
            this.tabPageCounter.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCounter
            // 
            this.dataGridViewCounter.AllowUserToAddRows = false;
            this.dataGridViewCounter.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCounter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.CAMERA_NO,
            this.CNIC});
            this.dataGridViewCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCounter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCounter.Name = "dataGridViewCounter";
            this.dataGridViewCounter.ReadOnly = true;
            this.dataGridViewCounter.Size = new System.Drawing.Size(790, 421);
            this.dataGridViewCounter.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "COUNTER NO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // CAMERA_NO
            // 
            this.CAMERA_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CAMERA_NO.HeaderText = "CAMERA NO";
            this.CAMERA_NO.Name = "CAMERA_NO";
            // 
            // CNIC
            // 
            this.CNIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNIC.HeaderText = "CNIC";
            this.CNIC.Name = "CNIC";
            // 
            // tabPageSurveillanceCamera
            // 
            this.tabPageSurveillanceCamera.Controls.Add(this.dataGridViewSurveillanceCamera);
            this.tabPageSurveillanceCamera.Location = new System.Drawing.Point(4, 22);
            this.tabPageSurveillanceCamera.Name = "tabPageSurveillanceCamera";
            this.tabPageSurveillanceCamera.Size = new System.Drawing.Size(790, 421);
            this.tabPageSurveillanceCamera.TabIndex = 6;
            this.tabPageSurveillanceCamera.Text = "Surveillance Camera";
            this.tabPageSurveillanceCamera.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSurveillanceCamera
            // 
            this.dataGridViewSurveillanceCamera.AllowUserToAddRows = false;
            this.dataGridViewSurveillanceCamera.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSurveillanceCamera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSurveillanceCamera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SURVEILLANCE_CAMERA_CAMERA_NO,
            this.SURVEILLANCE_CAMERA_FLOOR_NO});
            this.dataGridViewSurveillanceCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSurveillanceCamera.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSurveillanceCamera.Name = "dataGridViewSurveillanceCamera";
            this.dataGridViewSurveillanceCamera.ReadOnly = true;
            this.dataGridViewSurveillanceCamera.Size = new System.Drawing.Size(790, 421);
            this.dataGridViewSurveillanceCamera.TabIndex = 0;
            // 
            // SURVEILLANCE_CAMERA_CAMERA_NO
            // 
            this.SURVEILLANCE_CAMERA_CAMERA_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SURVEILLANCE_CAMERA_CAMERA_NO.HeaderText = "Camera No";
            this.SURVEILLANCE_CAMERA_CAMERA_NO.Name = "SURVEILLANCE_CAMERA_CAMERA_NO";
            // 
            // SURVEILLANCE_CAMERA_FLOOR_NO
            // 
            this.SURVEILLANCE_CAMERA_FLOOR_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SURVEILLANCE_CAMERA_FLOOR_NO.HeaderText = "Floor No";
            this.SURVEILLANCE_CAMERA_FLOOR_NO.Name = "SURVEILLANCE_CAMERA_FLOOR_NO";
            // 
            // tabPageStockDetail
            // 
            this.tabPageStockDetail.Controls.Add(this.dataGridViewStockDetail);
            this.tabPageStockDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageStockDetail.Name = "tabPageStockDetail";
            this.tabPageStockDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStockDetail.Size = new System.Drawing.Size(790, 421);
            this.tabPageStockDetail.TabIndex = 7;
            this.tabPageStockDetail.Text = "Stock Detail";
            this.tabPageStockDetail.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStockDetail
            // 
            this.dataGridViewStockDetail.AllowUserToAddRows = false;
            this.dataGridViewStockDetail.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStockDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStockDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STOCK_DETAIL_DATE_ARRIVED,
            this.STOCK_DETAIL_PRODUCT_ID,
            this.QUANTITY});
            this.dataGridViewStockDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStockDetail.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewStockDetail.Name = "dataGridViewStockDetail";
            this.dataGridViewStockDetail.ReadOnly = true;
            this.dataGridViewStockDetail.Size = new System.Drawing.Size(784, 415);
            this.dataGridViewStockDetail.TabIndex = 0;
            // 
            // STOCK_DETAIL_DATE_ARRIVED
            // 
            this.STOCK_DETAIL_DATE_ARRIVED.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STOCK_DETAIL_DATE_ARRIVED.HeaderText = "Date Arrived";
            this.STOCK_DETAIL_DATE_ARRIVED.Name = "STOCK_DETAIL_DATE_ARRIVED";
            // 
            // STOCK_DETAIL_PRODUCT_ID
            // 
            this.STOCK_DETAIL_PRODUCT_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STOCK_DETAIL_PRODUCT_ID.HeaderText = "Product Id";
            this.STOCK_DETAIL_PRODUCT_ID.Name = "STOCK_DETAIL_PRODUCT_ID";
            // 
            // QUANTITY
            // 
            this.QUANTITY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QUANTITY.HeaderText = "Quantity";
            this.QUANTITY.Name = "QUANTITY";
            // 
            // tabPageInvoiceDetail
            // 
            this.tabPageInvoiceDetail.Controls.Add(this.dataGridViewInvoiceDetail);
            this.tabPageInvoiceDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageInvoiceDetail.Name = "tabPageInvoiceDetail";
            this.tabPageInvoiceDetail.Size = new System.Drawing.Size(790, 421);
            this.tabPageInvoiceDetail.TabIndex = 8;
            this.tabPageInvoiceDetail.Text = "Invoice Detail";
            this.tabPageInvoiceDetail.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInvoiceDetail
            // 
            this.dataGridViewInvoiceDetail.AllowUserToAddRows = false;
            this.dataGridViewInvoiceDetail.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewInvoiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoiceDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.INVOICE_DETAIL_TRANSACTION_NO,
            this.INVOICE_DETAIL_PRODUCT_ID,
            this.QUANTITY_BOUGHT});
            this.dataGridViewInvoiceDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInvoiceDetail.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInvoiceDetail.Name = "dataGridViewInvoiceDetail";
            this.dataGridViewInvoiceDetail.ReadOnly = true;
            this.dataGridViewInvoiceDetail.Size = new System.Drawing.Size(790, 421);
            this.dataGridViewInvoiceDetail.TabIndex = 0;
            // 
            // INVOICE_DETAIL_TRANSACTION_NO
            // 
            this.INVOICE_DETAIL_TRANSACTION_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.INVOICE_DETAIL_TRANSACTION_NO.HeaderText = "Transaction No";
            this.INVOICE_DETAIL_TRANSACTION_NO.Name = "INVOICE_DETAIL_TRANSACTION_NO";
            // 
            // INVOICE_DETAIL_PRODUCT_ID
            // 
            this.INVOICE_DETAIL_PRODUCT_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.INVOICE_DETAIL_PRODUCT_ID.HeaderText = "Product Id";
            this.INVOICE_DETAIL_PRODUCT_ID.Name = "INVOICE_DETAIL_PRODUCT_ID";
            // 
            // QUANTITY_BOUGHT
            // 
            this.QUANTITY_BOUGHT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QUANTITY_BOUGHT.HeaderText = "Quantity Bought";
            this.QUANTITY_BOUGHT.Name = "QUANTITY_BOUGHT";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "DataForm";
            this.Text = "Data";
            this.tabControl.ResumeLayout(false);
            this.tabPageEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.tabPageProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.tabPageInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            this.tabPageStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.tabPageFloor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloor)).EndInit();
            this.tabPageCounter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCounter)).EndInit();
            this.tabPageSurveillanceCamera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSurveillanceCamera)).EndInit();
            this.tabPageStockDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockDetail)).EndInit();
            this.tabPageInvoiceDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.TabPage tabPageInvoice;
        private System.Windows.Forms.TabPage tabPageStock;
        private System.Windows.Forms.TabPage tabPageFloor;
        private System.Windows.Forms.TabPage tabPageCounter;
        private System.Windows.Forms.TabPage tabPageSurveillanceCamera;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLOOR_NO;
        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BARCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANSACTION_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COUNTER_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANSACTION_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_ITEMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_DISCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVOICE_VALUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CASH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHANGE_DUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_QUANTITY;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_ARRIVED;
        private System.Windows.Forms.DataGridViewTextBoxColumn COST;
        private System.Windows.Forms.DataGridView dataGridViewFloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLOOR_FlOOR_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_CATEGORY;
        private System.Windows.Forms.DataGridView dataGridViewCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAMERA_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNIC;
        private System.Windows.Forms.DataGridView dataGridViewSurveillanceCamera;
        private System.Windows.Forms.DataGridViewTextBoxColumn SURVEILLANCE_CAMERA_CAMERA_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SURVEILLANCE_CAMERA_FLOOR_NO;
        private System.Windows.Forms.TabPage tabPageStockDetail;
        private System.Windows.Forms.TabPage tabPageInvoiceDetail;
        private System.Windows.Forms.DataGridView dataGridViewStockDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCK_DETAIL_DATE_ARRIVED;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCK_DETAIL_PRODUCT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridView dataGridViewInvoiceDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVOICE_DETAIL_TRANSACTION_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVOICE_DETAIL_PRODUCT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY_BOUGHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_E_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_POSITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_SALARY;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_CONTACT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_CNIC;
    }
}