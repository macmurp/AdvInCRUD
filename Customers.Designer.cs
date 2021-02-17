
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
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStyleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suffixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordHashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordSaltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowguidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorksLT2017DataSet = new AdvInCRUD.AdventureWorksLT2017DataSet();
            this.FirstNamelbl = new System.Windows.Forms.Label();
            this.firsttxtbox = new System.Windows.Forms.TextBox();
            this.lasttxtbox = new System.Windows.Forms.TextBox();
            this.LastNamelbl = new System.Windows.Forms.Label();
            this.middletxtbox = new System.Windows.Forms.TextBox();
            this.MiddleNamelbl = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.companytxtbox = new System.Windows.Forms.TextBox();
            this.Companylbl = new System.Windows.Forms.Label();
            this.suffixtxtbox = new System.Windows.Forms.TextBox();
            this.Suffixlbl = new System.Windows.Forms.Label();
            this.titletxtbox = new System.Windows.Forms.TextBox();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.phonetxtbox = new System.Windows.Forms.TextBox();
            this.Phonelbl = new System.Windows.Forms.Label();
            this.emailtxtbox = new System.Windows.Forms.TextBox();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.searchtxtbox = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.gotoproductbtn = new System.Windows.Forms.Button();
            this.gotocustomeraddressbtn = new System.Windows.Forms.Button();
            this.gotoCustomerSalesbtn = new System.Windows.Forms.Button();
            this.customerTableAdapter = new AdvInCRUD.AdventureWorksLT2017DataSetTableAdapters.CustomerTableAdapter();
            this.SalesPersontxtbox = new System.Windows.Forms.TextBox();
            this.SalesPersonlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customergrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2017DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // customergrid
            // 
            this.customergrid.AutoGenerateColumns = false;
            this.customergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customergrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.nameStyleDataGridViewCheckBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.suffixDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.salesPersonDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.passwordHashDataGridViewTextBoxColumn,
            this.passwordSaltDataGridViewTextBoxColumn,
            this.rowguidDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn});
            this.customergrid.DataSource = this.customerBindingSource;
            this.customergrid.Location = new System.Drawing.Point(6, 6);
            this.customergrid.Margin = new System.Windows.Forms.Padding(2);
            this.customergrid.Name = "customergrid";
            this.customergrid.RowHeadersWidth = 82;
            this.customergrid.RowTemplate.Height = 33;
            this.customergrid.Size = new System.Drawing.Size(976, 381);
            this.customergrid.TabIndex = 0;
            this.customergrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.customergrid_CellValueChanged);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Visible = false;
            this.customerIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameStyleDataGridViewCheckBoxColumn
            // 
            this.nameStyleDataGridViewCheckBoxColumn.DataPropertyName = "NameStyle";
            this.nameStyleDataGridViewCheckBoxColumn.HeaderText = "NameStyle";
            this.nameStyleDataGridViewCheckBoxColumn.MinimumWidth = 10;
            this.nameStyleDataGridViewCheckBoxColumn.Name = "nameStyleDataGridViewCheckBoxColumn";
            this.nameStyleDataGridViewCheckBoxColumn.Visible = false;
            this.nameStyleDataGridViewCheckBoxColumn.Width = 200;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 200;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // suffixDataGridViewTextBoxColumn
            // 
            this.suffixDataGridViewTextBoxColumn.DataPropertyName = "Suffix";
            this.suffixDataGridViewTextBoxColumn.HeaderText = "Suffix";
            this.suffixDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.suffixDataGridViewTextBoxColumn.Name = "suffixDataGridViewTextBoxColumn";
            this.suffixDataGridViewTextBoxColumn.Width = 200;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // salesPersonDataGridViewTextBoxColumn
            // 
            this.salesPersonDataGridViewTextBoxColumn.DataPropertyName = "SalesPerson";
            this.salesPersonDataGridViewTextBoxColumn.HeaderText = "SalesPerson";
            this.salesPersonDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.salesPersonDataGridViewTextBoxColumn.Name = "salesPersonDataGridViewTextBoxColumn";
            this.salesPersonDataGridViewTextBoxColumn.Width = 200;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 200;
            // 
            // passwordHashDataGridViewTextBoxColumn
            // 
            this.passwordHashDataGridViewTextBoxColumn.DataPropertyName = "PasswordHash";
            this.passwordHashDataGridViewTextBoxColumn.HeaderText = "PasswordHash";
            this.passwordHashDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.passwordHashDataGridViewTextBoxColumn.Name = "passwordHashDataGridViewTextBoxColumn";
            this.passwordHashDataGridViewTextBoxColumn.Visible = false;
            this.passwordHashDataGridViewTextBoxColumn.Width = 200;
            // 
            // passwordSaltDataGridViewTextBoxColumn
            // 
            this.passwordSaltDataGridViewTextBoxColumn.DataPropertyName = "PasswordSalt";
            this.passwordSaltDataGridViewTextBoxColumn.HeaderText = "PasswordSalt";
            this.passwordSaltDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.passwordSaltDataGridViewTextBoxColumn.Name = "passwordSaltDataGridViewTextBoxColumn";
            this.passwordSaltDataGridViewTextBoxColumn.Visible = false;
            this.passwordSaltDataGridViewTextBoxColumn.Width = 200;
            // 
            // rowguidDataGridViewTextBoxColumn
            // 
            this.rowguidDataGridViewTextBoxColumn.DataPropertyName = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.HeaderText = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.rowguidDataGridViewTextBoxColumn.Name = "rowguidDataGridViewTextBoxColumn";
            this.rowguidDataGridViewTextBoxColumn.Visible = false;
            this.rowguidDataGridViewTextBoxColumn.Width = 200;
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            this.modifiedDateDataGridViewTextBoxColumn.Width = 200;
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
            // FirstNamelbl
            // 
            this.FirstNamelbl.AutoSize = true;
            this.FirstNamelbl.Location = new System.Drawing.Point(12, 397);
            this.FirstNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNamelbl.Name = "FirstNamelbl";
            this.FirstNamelbl.Size = new System.Drawing.Size(57, 13);
            this.FirstNamelbl.TabIndex = 1;
            this.FirstNamelbl.Text = "First Name";
            // 
            // firsttxtbox
            // 
            this.firsttxtbox.Location = new System.Drawing.Point(86, 394);
            this.firsttxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.firsttxtbox.Name = "firsttxtbox";
            this.firsttxtbox.Size = new System.Drawing.Size(157, 20);
            this.firsttxtbox.TabIndex = 2;
            // 
            // lasttxtbox
            // 
            this.lasttxtbox.Location = new System.Drawing.Point(86, 429);
            this.lasttxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.lasttxtbox.Name = "lasttxtbox";
            this.lasttxtbox.Size = new System.Drawing.Size(157, 20);
            this.lasttxtbox.TabIndex = 4;
            // 
            // LastNamelbl
            // 
            this.LastNamelbl.AutoSize = true;
            this.LastNamelbl.Location = new System.Drawing.Point(12, 431);
            this.LastNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNamelbl.Name = "LastNamelbl";
            this.LastNamelbl.Size = new System.Drawing.Size(58, 13);
            this.LastNamelbl.TabIndex = 3;
            this.LastNamelbl.Text = "Last Name";
            // 
            // middletxtbox
            // 
            this.middletxtbox.Location = new System.Drawing.Point(86, 411);
            this.middletxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.middletxtbox.Name = "middletxtbox";
            this.middletxtbox.Size = new System.Drawing.Size(157, 20);
            this.middletxtbox.TabIndex = 6;
            // 
            // MiddleNamelbl
            // 
            this.MiddleNamelbl.AutoSize = true;
            this.MiddleNamelbl.Location = new System.Drawing.Point(12, 414);
            this.MiddleNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MiddleNamelbl.Name = "MiddleNamelbl";
            this.MiddleNamelbl.Size = new System.Drawing.Size(69, 13);
            this.MiddleNamelbl.TabIndex = 5;
            this.MiddleNamelbl.Text = "Middle Name";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(275, 397);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 22);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(349, 397);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 22);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // refreshbtn
            // 
            this.refreshbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refreshbtn.Location = new System.Drawing.Point(425, 397);
            this.refreshbtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(58, 22);
            this.refreshbtn.TabIndex = 9;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // companytxtbox
            // 
            this.companytxtbox.Location = new System.Drawing.Point(86, 484);
            this.companytxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.companytxtbox.Name = "companytxtbox";
            this.companytxtbox.Size = new System.Drawing.Size(157, 20);
            this.companytxtbox.TabIndex = 15;
            // 
            // Companylbl
            // 
            this.Companylbl.AutoSize = true;
            this.Companylbl.Location = new System.Drawing.Point(13, 487);
            this.Companylbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Companylbl.Name = "Companylbl";
            this.Companylbl.Size = new System.Drawing.Size(51, 13);
            this.Companylbl.TabIndex = 14;
            this.Companylbl.Text = "Company";
            // 
            // suffixtxtbox
            // 
            this.suffixtxtbox.Location = new System.Drawing.Point(86, 466);
            this.suffixtxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.suffixtxtbox.Name = "suffixtxtbox";
            this.suffixtxtbox.Size = new System.Drawing.Size(157, 20);
            this.suffixtxtbox.TabIndex = 13;
            // 
            // Suffixlbl
            // 
            this.Suffixlbl.AutoSize = true;
            this.Suffixlbl.Location = new System.Drawing.Point(13, 468);
            this.Suffixlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Suffixlbl.Name = "Suffixlbl";
            this.Suffixlbl.Size = new System.Drawing.Size(33, 13);
            this.Suffixlbl.TabIndex = 12;
            this.Suffixlbl.Text = "Suffix";
            // 
            // titletxtbox
            // 
            this.titletxtbox.Location = new System.Drawing.Point(86, 448);
            this.titletxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.titletxtbox.Name = "titletxtbox";
            this.titletxtbox.Size = new System.Drawing.Size(157, 20);
            this.titletxtbox.TabIndex = 11;
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Location = new System.Drawing.Point(13, 450);
            this.Titlelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(27, 13);
            this.Titlelbl.TabIndex = 10;
            this.Titlelbl.Text = "Title";
            // 
            // phonetxtbox
            // 
            this.phonetxtbox.Location = new System.Drawing.Point(86, 521);
            this.phonetxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.phonetxtbox.Name = "phonetxtbox";
            this.phonetxtbox.Size = new System.Drawing.Size(157, 20);
            this.phonetxtbox.TabIndex = 19;
            // 
            // Phonelbl
            // 
            this.Phonelbl.AutoSize = true;
            this.Phonelbl.Location = new System.Drawing.Point(12, 524);
            this.Phonelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Phonelbl.Name = "Phonelbl";
            this.Phonelbl.Size = new System.Drawing.Size(38, 13);
            this.Phonelbl.TabIndex = 18;
            this.Phonelbl.Text = "Phone";
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.Location = new System.Drawing.Point(86, 503);
            this.emailtxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.Size = new System.Drawing.Size(157, 20);
            this.emailtxtbox.TabIndex = 17;
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Location = new System.Drawing.Point(12, 505);
            this.Emaillbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(32, 13);
            this.Emaillbl.TabIndex = 16;
            this.Emaillbl.Text = "Email";
            // 
            // searchtxtbox
            // 
            this.searchtxtbox.Location = new System.Drawing.Point(801, 394);
            this.searchtxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.searchtxtbox.Name = "searchtxtbox";
            this.searchtxtbox.Size = new System.Drawing.Size(181, 20);
            this.searchtxtbox.TabIndex = 20;
            // 
            // searchbtn
            // 
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchbtn.Location = new System.Drawing.Point(739, 394);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(58, 22);
            this.searchbtn.TabIndex = 21;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // gotoproductbtn
            // 
            this.gotoproductbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gotoproductbtn.Location = new System.Drawing.Point(892, 521);
            this.gotoproductbtn.Margin = new System.Windows.Forms.Padding(2);
            this.gotoproductbtn.Name = "gotoproductbtn";
            this.gotoproductbtn.Size = new System.Drawing.Size(90, 41);
            this.gotoproductbtn.TabIndex = 22;
            this.gotoproductbtn.Text = "Products";
            this.gotoproductbtn.UseVisualStyleBackColor = true;
            this.gotoproductbtn.Click += new System.EventHandler(this.gotoproductbtn_Click);
            // 
            // gotocustomeraddressbtn
            // 
            this.gotocustomeraddressbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gotocustomeraddressbtn.Location = new System.Drawing.Point(828, 422);
            this.gotocustomeraddressbtn.Margin = new System.Windows.Forms.Padding(2);
            this.gotocustomeraddressbtn.Name = "gotocustomeraddressbtn";
            this.gotocustomeraddressbtn.Size = new System.Drawing.Size(60, 41);
            this.gotocustomeraddressbtn.TabIndex = 23;
            this.gotocustomeraddressbtn.Text = "Customer Address";
            this.gotocustomeraddressbtn.UseVisualStyleBackColor = true;
            // 
            // gotoCustomerSalesbtn
            // 
            this.gotoCustomerSalesbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gotoCustomerSalesbtn.Location = new System.Drawing.Point(892, 422);
            this.gotoCustomerSalesbtn.Margin = new System.Windows.Forms.Padding(2);
            this.gotoCustomerSalesbtn.Name = "gotoCustomerSalesbtn";
            this.gotoCustomerSalesbtn.Size = new System.Drawing.Size(59, 41);
            this.gotoCustomerSalesbtn.TabIndex = 24;
            this.gotoCustomerSalesbtn.Text = "Customer Sales";
            this.gotoCustomerSalesbtn.UseVisualStyleBackColor = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // SalesPersontxtbox
            // 
            this.SalesPersontxtbox.Location = new System.Drawing.Point(86, 540);
            this.SalesPersontxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.SalesPersontxtbox.Name = "SalesPersontxtbox";
            this.SalesPersontxtbox.Size = new System.Drawing.Size(157, 20);
            this.SalesPersontxtbox.TabIndex = 26;
            // 
            // SalesPersonlbl
            // 
            this.SalesPersonlbl.AutoSize = true;
            this.SalesPersonlbl.Location = new System.Drawing.Point(12, 543);
            this.SalesPersonlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SalesPersonlbl.Name = "SalesPersonlbl";
            this.SalesPersonlbl.Size = new System.Drawing.Size(69, 13);
            this.SalesPersonlbl.TabIndex = 25;
            this.SalesPersonlbl.Text = "Sales Person";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 580);
            this.Controls.Add(this.SalesPersontxtbox);
            this.Controls.Add(this.SalesPersonlbl);
            this.Controls.Add(this.gotoCustomerSalesbtn);
            this.Controls.Add(this.gotocustomeraddressbtn);
            this.Controls.Add(this.gotoproductbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxtbox);
            this.Controls.Add(this.phonetxtbox);
            this.Controls.Add(this.Phonelbl);
            this.Controls.Add(this.emailtxtbox);
            this.Controls.Add(this.Emaillbl);
            this.Controls.Add(this.companytxtbox);
            this.Controls.Add(this.Companylbl);
            this.Controls.Add(this.suffixtxtbox);
            this.Controls.Add(this.Suffixlbl);
            this.Controls.Add(this.titletxtbox);
            this.Controls.Add(this.Titlelbl);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.middletxtbox);
            this.Controls.Add(this.MiddleNamelbl);
            this.Controls.Add(this.lasttxtbox);
            this.Controls.Add(this.LastNamelbl);
            this.Controls.Add(this.firsttxtbox);
            this.Controls.Add(this.FirstNamelbl);
            this.Controls.Add(this.customergrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Customers";
            this.Text = "AdventureWorks Data";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customergrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2017DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customergrid;
        private System.Windows.Forms.Label FirstNamelbl;
        private System.Windows.Forms.TextBox firsttxtbox;
        private System.Windows.Forms.TextBox lasttxtbox;
        private System.Windows.Forms.Label LastNamelbl;
        private System.Windows.Forms.TextBox middletxtbox;
        private System.Windows.Forms.Label MiddleNamelbl;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.TextBox companytxtbox;
        private System.Windows.Forms.Label Companylbl;
        private System.Windows.Forms.TextBox suffixtxtbox;
        private System.Windows.Forms.Label Suffixlbl;
        private System.Windows.Forms.TextBox titletxtbox;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.TextBox phonetxtbox;
        private System.Windows.Forms.Label Phonelbl;
        private System.Windows.Forms.TextBox emailtxtbox;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.TextBox searchtxtbox;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button gotoproductbtn;
        private System.Windows.Forms.Button gotocustomeraddressbtn;
        private System.Windows.Forms.Button gotoCustomerSalesbtn;
        private AdventureWorksLT2017DataSet adventureWorksLT2017DataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private AdventureWorksLT2017DataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nameStyleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suffixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordHashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordSaltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox SalesPersontxtbox;
        private System.Windows.Forms.Label SalesPersonlbl;
    }
}

