
namespace AdvInCRUD
{
    partial class Customers
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
            this.components = new System.ComponentModel.Container();
            this.customergrid = new System.Windows.Forms.DataGridView();
            this.getAllCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorksLT2017DataSet1 = new AdvInCRUD.AdventureWorksLT2017DataSet1();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorksLT2017DataSet = new AdvInCRUD.AdventureWorksLT2017DataSet();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.searchtxtbox = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.gotoproductbtn = new System.Windows.Forms.Button();
            this.customerTableAdapter = new AdvInCRUD.AdventureWorksLT2017DataSetTableAdapters.CustomerTableAdapter();
            this.instructionlbl = new System.Windows.Forms.Label();
            this.getAllCustomersTableAdapter = new AdvInCRUD.AdventureWorksLT2017DataSet1TableAdapters.getAllCustomersTableAdapter();
            this.txtid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtfirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmiddle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtlast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsuffix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsalesperson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtaddressid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtaddresstype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtaddressline1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtaddressline2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtstateprovince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcountryregion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtpostalcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customergrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2017DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2017DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // customergrid
            // 
            this.customergrid.AutoGenerateColumns = false;
            this.customergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customergrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtid,
            this.txttitle,
            this.txtfirst,
            this.txtmiddle,
            this.txtlast,
            this.txtsuffix,
            this.txtcompany,
            this.txtsalesperson,
            this.txtemail,
            this.txtphone,
            this.modifiedDateDataGridViewTextBoxColumn,
            this.txtaddressid,
            this.txtaddresstype,
            this.txtaddressline1,
            this.txtaddressline2,
            this.txtcity,
            this.txtstateprovince,
            this.txtcountryregion,
            this.txtpostalcode});
            this.customergrid.DataSource = this.getAllCustomersBindingSource;
            this.customergrid.Location = new System.Drawing.Point(6, 6);
            this.customergrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customergrid.Name = "customergrid";
            this.customergrid.RowHeadersWidth = 82;
            this.customergrid.RowTemplate.Height = 33;
            this.customergrid.Size = new System.Drawing.Size(990, 451);
            this.customergrid.TabIndex = 0;
            this.customergrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.customergrid_CellValueChanged);
            this.customergrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.customergrid_UserDeletingRow);
            // 
            // getAllCustomersBindingSource
            // 
            this.getAllCustomersBindingSource.DataMember = "getAllCustomers";
            this.getAllCustomersBindingSource.DataSource = this.adventureWorksLT2017DataSet1;
            // 
            // adventureWorksLT2017DataSet1
            // 
            this.adventureWorksLT2017DataSet1.DataSetName = "AdventureWorksLT2017DataSet1";
            this.adventureWorksLT2017DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.adventureWorksLT2017DataSet;
            // 
            // adventureWorksLT2017DataSet
            // 
            this.adventureWorksLT2017DataSet.DataSetName = "AdventureWorksLT2017DataSet";
            this.adventureWorksLT2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refreshbtn
            // 
            this.refreshbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refreshbtn.Location = new System.Drawing.Point(363, 475);
            this.refreshbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(83, 23);
            this.refreshbtn.TabIndex = 9;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // searchtxtbox
            // 
            this.searchtxtbox.Location = new System.Drawing.Point(567, 472);
            this.searchtxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchtxtbox.Name = "searchtxtbox";
            this.searchtxtbox.Size = new System.Drawing.Size(181, 20);
            this.searchtxtbox.TabIndex = 20;
            // 
            // searchbtn
            // 
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchbtn.Location = new System.Drawing.Point(505, 472);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(58, 20);
            this.searchbtn.TabIndex = 21;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // gotoproductbtn
            // 
            this.gotoproductbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gotoproductbtn.Location = new System.Drawing.Point(844, 472);
            this.gotoproductbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gotoproductbtn.Name = "gotoproductbtn";
            this.gotoproductbtn.Size = new System.Drawing.Size(90, 41);
            this.gotoproductbtn.TabIndex = 22;
            this.gotoproductbtn.Text = "Products";
            this.gotoproductbtn.UseVisualStyleBackColor = true;
            this.gotoproductbtn.Click += new System.EventHandler(this.gotoproductbtn_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // instructionlbl
            // 
            this.instructionlbl.Location = new System.Drawing.Point(83, 475);
            this.instructionlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructionlbl.Name = "instructionlbl";
            this.instructionlbl.Size = new System.Drawing.Size(168, 64);
            this.instructionlbl.TabIndex = 27;
            this.instructionlbl.Text = "Edit the table directly for CRUD operations, press Add to update/insert, or selec" +
    "t a row and press delete";
            // 
            // getAllCustomersTableAdapter
            // 
            this.getAllCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // txtid
            // 
            this.txtid.DataPropertyName = "CustomerID";
            this.txtid.HeaderText = "CustomerID";
            this.txtid.MinimumWidth = 10;
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Visible = false;
            this.txtid.Width = 200;
            // 
            // txttitle
            // 
            this.txttitle.DataPropertyName = "Title";
            this.txttitle.HeaderText = "Title";
            this.txttitle.MinimumWidth = 10;
            this.txttitle.Name = "txttitle";
            this.txttitle.Width = 200;
            // 
            // txtfirst
            // 
            this.txtfirst.DataPropertyName = "FirstName";
            this.txtfirst.HeaderText = "FirstName";
            this.txtfirst.MinimumWidth = 10;
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Width = 200;
            // 
            // txtmiddle
            // 
            this.txtmiddle.DataPropertyName = "MiddleName";
            this.txtmiddle.HeaderText = "MiddleName";
            this.txtmiddle.MinimumWidth = 10;
            this.txtmiddle.Name = "txtmiddle";
            this.txtmiddle.Width = 200;
            // 
            // txtlast
            // 
            this.txtlast.DataPropertyName = "LastName";
            this.txtlast.HeaderText = "LastName";
            this.txtlast.MinimumWidth = 10;
            this.txtlast.Name = "txtlast";
            this.txtlast.Width = 200;
            // 
            // txtsuffix
            // 
            this.txtsuffix.DataPropertyName = "Suffix";
            this.txtsuffix.HeaderText = "Suffix";
            this.txtsuffix.MinimumWidth = 10;
            this.txtsuffix.Name = "txtsuffix";
            this.txtsuffix.Width = 200;
            // 
            // txtcompany
            // 
            this.txtcompany.DataPropertyName = "CompanyName";
            this.txtcompany.HeaderText = "CompanyName";
            this.txtcompany.MinimumWidth = 10;
            this.txtcompany.Name = "txtcompany";
            this.txtcompany.Width = 200;
            // 
            // txtsalesperson
            // 
            this.txtsalesperson.DataPropertyName = "SalesPerson";
            this.txtsalesperson.HeaderText = "SalesPerson";
            this.txtsalesperson.MinimumWidth = 10;
            this.txtsalesperson.Name = "txtsalesperson";
            this.txtsalesperson.Width = 200;
            // 
            // txtemail
            // 
            this.txtemail.DataPropertyName = "EmailAddress";
            this.txtemail.HeaderText = "EmailAddress";
            this.txtemail.MinimumWidth = 10;
            this.txtemail.Name = "txtemail";
            this.txtemail.Width = 200;
            // 
            // txtphone
            // 
            this.txtphone.DataPropertyName = "Phone";
            this.txtphone.HeaderText = "Phone";
            this.txtphone.MinimumWidth = 10;
            this.txtphone.Name = "txtphone";
            this.txtphone.Width = 200;
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            this.modifiedDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.modifiedDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // txtaddressid
            // 
            this.txtaddressid.DataPropertyName = "AddressID";
            this.txtaddressid.HeaderText = "Address ID";
            this.txtaddressid.MinimumWidth = 10;
            this.txtaddressid.Name = "txtaddressid";
            this.txtaddressid.Visible = false;
            this.txtaddressid.Width = 200;
            // 
            // txtaddresstype
            // 
            this.txtaddresstype.DataPropertyName = "AddressType";
            this.txtaddresstype.HeaderText = "Address Type";
            this.txtaddresstype.MinimumWidth = 10;
            this.txtaddresstype.Name = "txtaddresstype";
            this.txtaddresstype.Width = 200;
            // 
            // txtaddressline1
            // 
            this.txtaddressline1.DataPropertyName = "AddressLine1";
            this.txtaddressline1.HeaderText = "Address Line 1";
            this.txtaddressline1.MinimumWidth = 10;
            this.txtaddressline1.Name = "txtaddressline1";
            this.txtaddressline1.Width = 200;
            // 
            // txtaddressline2
            // 
            this.txtaddressline2.DataPropertyName = "AddressLine2";
            this.txtaddressline2.HeaderText = "Address Line 2";
            this.txtaddressline2.MinimumWidth = 10;
            this.txtaddressline2.Name = "txtaddressline2";
            this.txtaddressline2.Width = 200;
            // 
            // txtcity
            // 
            this.txtcity.DataPropertyName = "City";
            this.txtcity.HeaderText = "City";
            this.txtcity.MinimumWidth = 10;
            this.txtcity.Name = "txtcity";
            this.txtcity.Width = 200;
            // 
            // txtstateprovince
            // 
            this.txtstateprovince.DataPropertyName = "StateProvince";
            this.txtstateprovince.HeaderText = "State Province";
            this.txtstateprovince.MinimumWidth = 10;
            this.txtstateprovince.Name = "txtstateprovince";
            this.txtstateprovince.Width = 200;
            // 
            // txtcountryregion
            // 
            this.txtcountryregion.DataPropertyName = "CountryRegion";
            this.txtcountryregion.HeaderText = "Country Region";
            this.txtcountryregion.MinimumWidth = 10;
            this.txtcountryregion.Name = "txtcountryregion";
            this.txtcountryregion.Width = 200;
            // 
            // txtpostalcode
            // 
            this.txtpostalcode.DataPropertyName = "PostalCode";
            this.txtpostalcode.HeaderText = "Postal Code";
            this.txtpostalcode.MinimumWidth = 10;
            this.txtpostalcode.Name = "txtpostalcode";
            this.txtpostalcode.Width = 200;
            // 
            // insertbtn
            // 
            this.insertbtn.Location = new System.Drawing.Point(275, 475);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(83, 23);
            this.insertbtn.TabIndex = 28;
            this.insertbtn.Text = "Add";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 580);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.instructionlbl);
            this.Controls.Add(this.gotoproductbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxtbox);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.customergrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Customers";
            this.Text = "AdventureWorks Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customers_FormClosing);
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customergrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2017DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2017DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customergrid;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.TextBox searchtxtbox;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button gotoproductbtn;
        private AdventureWorksLT2017DataSet adventureWorksLT2017DataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private AdventureWorksLT2017DataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Label instructionlbl;
        private AdventureWorksLT2017DataSet1 adventureWorksLT2017DataSet1;
        private System.Windows.Forms.BindingSource getAllCustomersBindingSource;
        private AdventureWorksLT2017DataSet1TableAdapters.getAllCustomersTableAdapter getAllCustomersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtid;
        private System.Windows.Forms.DataGridViewTextBoxColumn txttitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtfirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtmiddle;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtlast;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtsuffix;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtsalesperson;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtaddressid;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtaddresstype;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtaddressline1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtaddressline2;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcity;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtstateprovince;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcountryregion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtpostalcode;
        private System.Windows.Forms.Button insertbtn;
    }
}

