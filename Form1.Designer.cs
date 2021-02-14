
namespace AdvInCRUD
{
    partial class Form1
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
            this.customergrid.Size = new System.Drawing.Size(1702, 1067);
            this.customergrid.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 1144);
            this.Controls.Add(this.customergrid);
            this.Name = "Form1";
            this.Text = "AdventureWorks Data";
            ((System.ComponentModel.ISupportInitialize)(this.customergrid)).EndInit();
            this.ResumeLayout(false);

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
    }
}

