
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
            this.customergrid = new System.Windows.Forms.DataGridView();
            this.txtCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSuffix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNamelbl = new System.Windows.Forms.Label();
            this.firsttxtbox = new System.Windows.Forms.TextBox();
            this.lasttxtbox = new System.Windows.Forms.TextBox();
            this.LastNamelbl = new System.Windows.Forms.Label();
            this.middletxtbox = new System.Windows.Forms.TextBox();
            this.MiddleNamelbl = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.customergrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customergrid
            // 
            this.customergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customergrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtCustomerID,
            this.txtFirstName,
            this.txtMiddleName,
            this.txtLastName,
            this.txtTitle,
            this.txtSuffix,
            this.txtCompanyName,
            this.txtEmailAddress,
            this.txtPhone});
            this.customergrid.Location = new System.Drawing.Point(12, 12);
            this.customergrid.Name = "customergrid";
            this.customergrid.RowHeadersWidth = 82;
            this.customergrid.RowTemplate.Height = 33;
            this.customergrid.Size = new System.Drawing.Size(1709, 712);
            this.customergrid.TabIndex = 0;
            this.customergrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customergrid_CellContentClick);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.DataPropertyName = "CustomerID";
            this.txtCustomerID.HeaderText = "Customer ID";
            this.txtCustomerID.MinimumWidth = 10;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Visible = false;
            this.txtCustomerID.Width = 200;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataPropertyName = "FirstName";
            this.txtFirstName.HeaderText = "First Name";
            this.txtFirstName.MinimumWidth = 10;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Width = 200;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.DataPropertyName = "MiddleName";
            this.txtMiddleName.HeaderText = "Middle Name";
            this.txtMiddleName.MinimumWidth = 10;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Width = 200;
            // 
            // txtLastName
            // 
            this.txtLastName.DataPropertyName = "LastName";
            this.txtLastName.HeaderText = "Last Name";
            this.txtLastName.MinimumWidth = 10;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Width = 200;
            // 
            // txtTitle
            // 
            this.txtTitle.DataPropertyName = "Title";
            this.txtTitle.HeaderText = "Title";
            this.txtTitle.MinimumWidth = 10;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Width = 200;
            // 
            // txtSuffix
            // 
            this.txtSuffix.DataPropertyName = "Suffix";
            this.txtSuffix.HeaderText = "Suffix";
            this.txtSuffix.MinimumWidth = 10;
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Width = 200;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.DataPropertyName = "CompanyName";
            this.txtCompanyName.HeaderText = "Company Name";
            this.txtCompanyName.MinimumWidth = 10;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Width = 200;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.DataPropertyName = "EmailAddress";
            this.txtEmailAddress.HeaderText = "Email Address";
            this.txtEmailAddress.MinimumWidth = 10;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Width = 200;
            // 
            // txtPhone
            // 
            this.txtPhone.DataPropertyName = "Phone";
            this.txtPhone.HeaderText = "Phone";
            this.txtPhone.MinimumWidth = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Width = 200;
            // 
            // FirstNamelbl
            // 
            this.FirstNamelbl.AutoSize = true;
            this.FirstNamelbl.Location = new System.Drawing.Point(25, 757);
            this.FirstNamelbl.Name = "FirstNamelbl";
            this.FirstNamelbl.Size = new System.Drawing.Size(116, 25);
            this.FirstNamelbl.TabIndex = 1;
            this.FirstNamelbl.Text = "First Name";
            // 
            // firsttxtbox
            // 
            this.firsttxtbox.Location = new System.Drawing.Point(171, 751);
            this.firsttxtbox.Name = "firsttxtbox";
            this.firsttxtbox.Size = new System.Drawing.Size(310, 31);
            this.firsttxtbox.TabIndex = 2;
            // 
            // lasttxtbox
            // 
            this.lasttxtbox.Location = new System.Drawing.Point(171, 820);
            this.lasttxtbox.Name = "lasttxtbox";
            this.lasttxtbox.Size = new System.Drawing.Size(310, 31);
            this.lasttxtbox.TabIndex = 4;
            // 
            // LastNamelbl
            // 
            this.LastNamelbl.AutoSize = true;
            this.LastNamelbl.Location = new System.Drawing.Point(25, 824);
            this.LastNamelbl.Name = "LastNamelbl";
            this.LastNamelbl.Size = new System.Drawing.Size(115, 25);
            this.LastNamelbl.TabIndex = 3;
            this.LastNamelbl.Text = "Last Name";
            // 
            // middletxtbox
            // 
            this.middletxtbox.Location = new System.Drawing.Point(171, 785);
            this.middletxtbox.Name = "middletxtbox";
            this.middletxtbox.Size = new System.Drawing.Size(310, 31);
            this.middletxtbox.TabIndex = 6;
            // 
            // MiddleNamelbl
            // 
            this.MiddleNamelbl.AutoSize = true;
            this.MiddleNamelbl.Location = new System.Drawing.Point(25, 791);
            this.MiddleNamelbl.Name = "MiddleNamelbl";
            this.MiddleNamelbl.Size = new System.Drawing.Size(138, 25);
            this.MiddleNamelbl.TabIndex = 5;
            this.MiddleNamelbl.Text = "Middle Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(48, 1056);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 43);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(197, 1056);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 43);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // refreshbtn
            // 
            this.refreshbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refreshbtn.Location = new System.Drawing.Point(349, 1056);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(116, 43);
            this.refreshbtn.TabIndex = 9;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // companytxtbox
            // 
            this.companytxtbox.Location = new System.Drawing.Point(172, 925);
            this.companytxtbox.Name = "companytxtbox";
            this.companytxtbox.Size = new System.Drawing.Size(310, 31);
            this.companytxtbox.TabIndex = 15;
            // 
            // Companylbl
            // 
            this.Companylbl.AutoSize = true;
            this.Companylbl.Location = new System.Drawing.Point(26, 931);
            this.Companylbl.Name = "Companylbl";
            this.Companylbl.Size = new System.Drawing.Size(103, 25);
            this.Companylbl.TabIndex = 14;
            this.Companylbl.Text = "Company";
            // 
            // suffixtxtbox
            // 
            this.suffixtxtbox.Location = new System.Drawing.Point(172, 890);
            this.suffixtxtbox.Name = "suffixtxtbox";
            this.suffixtxtbox.Size = new System.Drawing.Size(310, 31);
            this.suffixtxtbox.TabIndex = 13;
            // 
            // Suffixlbl
            // 
            this.Suffixlbl.AutoSize = true;
            this.Suffixlbl.Location = new System.Drawing.Point(26, 895);
            this.Suffixlbl.Name = "Suffixlbl";
            this.Suffixlbl.Size = new System.Drawing.Size(66, 25);
            this.Suffixlbl.TabIndex = 12;
            this.Suffixlbl.Text = "Suffix";
            // 
            // titletxtbox
            // 
            this.titletxtbox.Location = new System.Drawing.Point(172, 855);
            this.titletxtbox.Name = "titletxtbox";
            this.titletxtbox.Size = new System.Drawing.Size(310, 31);
            this.titletxtbox.TabIndex = 11;
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Location = new System.Drawing.Point(26, 860);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(53, 25);
            this.Titlelbl.TabIndex = 10;
            this.Titlelbl.Text = "Title";
            // 
            // phonetxtbox
            // 
            this.phonetxtbox.Location = new System.Drawing.Point(171, 996);
            this.phonetxtbox.Name = "phonetxtbox";
            this.phonetxtbox.Size = new System.Drawing.Size(310, 31);
            this.phonetxtbox.TabIndex = 19;
            // 
            // Phonelbl
            // 
            this.Phonelbl.AutoSize = true;
            this.Phonelbl.Location = new System.Drawing.Point(25, 1002);
            this.Phonelbl.Name = "Phonelbl";
            this.Phonelbl.Size = new System.Drawing.Size(74, 25);
            this.Phonelbl.TabIndex = 18;
            this.Phonelbl.Text = "Phone";
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.Location = new System.Drawing.Point(171, 961);
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.Size = new System.Drawing.Size(310, 31);
            this.emailtxtbox.TabIndex = 17;
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Location = new System.Drawing.Point(25, 966);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(65, 25);
            this.Emaillbl.TabIndex = 16;
            this.Emaillbl.Text = "Email";
            // 
            // searchtxtbox
            // 
            this.searchtxtbox.Location = new System.Drawing.Point(1363, 764);
            this.searchtxtbox.Name = "searchtxtbox";
            this.searchtxtbox.Size = new System.Drawing.Size(358, 31);
            this.searchtxtbox.TabIndex = 20;
            // 
            // searchbtn
            // 
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchbtn.Location = new System.Drawing.Point(1230, 758);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(116, 43);
            this.searchbtn.TabIndex = 21;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // gotoproductbtn
            // 
            this.gotoproductbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gotoproductbtn.Location = new System.Drawing.Point(799, 765);
            this.gotoproductbtn.Name = "gotoproductbtn";
            this.gotoproductbtn.Size = new System.Drawing.Size(116, 43);
            this.gotoproductbtn.TabIndex = 22;
            this.gotoproductbtn.Text = "Products";
            this.gotoproductbtn.UseVisualStyleBackColor = true;
            this.gotoproductbtn.Click += new System.EventHandler(this.gotoproductbtn_Click);
            // 
            // gotocustomeraddressbtn
            // 
            this.gotocustomeraddressbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gotocustomeraddressbtn.Location = new System.Drawing.Point(655, 764);
            this.gotocustomeraddressbtn.Name = "gotocustomeraddressbtn";
            this.gotocustomeraddressbtn.Size = new System.Drawing.Size(120, 63);
            this.gotocustomeraddressbtn.TabIndex = 23;
            this.gotocustomeraddressbtn.Text = "Customer Address";
            this.gotocustomeraddressbtn.UseVisualStyleBackColor = true;
            // 
            // gotoCustomerSalesbtn
            // 
            this.gotoCustomerSalesbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gotoCustomerSalesbtn.Location = new System.Drawing.Point(938, 764);
            this.gotoCustomerSalesbtn.Name = "gotoCustomerSalesbtn";
            this.gotoCustomerSalesbtn.Size = new System.Drawing.Size(118, 60);
            this.gotoCustomerSalesbtn.TabIndex = 24;
            this.gotoCustomerSalesbtn.Text = "Customer Sales";
            this.gotoCustomerSalesbtn.UseVisualStyleBackColor = true;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1823, 1169);
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
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.middletxtbox);
            this.Controls.Add(this.MiddleNamelbl);
            this.Controls.Add(this.lasttxtbox);
            this.Controls.Add(this.LastNamelbl);
            this.Controls.Add(this.firsttxtbox);
            this.Controls.Add(this.FirstNamelbl);
            this.Controls.Add(this.customergrid);
            this.Name = "Customers";
            this.Text = "AdventureWorks Data";
            ((System.ComponentModel.ISupportInitialize)(this.customergrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customergrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSuffix;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPhone;
        private System.Windows.Forms.Label FirstNamelbl;
        private System.Windows.Forms.TextBox firsttxtbox;
        private System.Windows.Forms.TextBox lasttxtbox;
        private System.Windows.Forms.Label LastNamelbl;
        private System.Windows.Forms.TextBox middletxtbox;
        private System.Windows.Forms.Label MiddleNamelbl;
        private System.Windows.Forms.Button btnUpdate;
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
    }
}

