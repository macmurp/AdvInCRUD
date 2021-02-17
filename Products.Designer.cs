
namespace AdvInCRUD
{
    partial class Products
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
            this.productgrid = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productModelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discontinuedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thumbNailPhotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.thumbnailPhotoFileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowguidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorksLT2017DataSet = new AdvInCRUD.AdventureWorksLT2017DataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new AdvInCRUD.AdventureWorksLT2017DataSetTableAdapters.ProductTableAdapter();
            this.fKSalesOrderDetailProductProductIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesOrderDetailTableAdapter = new AdvInCRUD.AdventureWorksLT2017DataSetTableAdapters.SalesOrderDetailTableAdapter();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxtbox = new System.Windows.Forms.TextBox();
            this.gotocustomersbtn = new System.Windows.Forms.Button();
            this.gotoproductmodelbtn = new System.Windows.Forms.Button();
            this.gotoProductDescriptionbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesOrderDetailProductProductIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productgrid
            // 
            this.productgrid.AllowUserToAddRows = false;
            this.productgrid.AllowUserToDeleteRows = false;
            this.productgrid.AutoGenerateColumns = false;
            this.productgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.productNumberDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.standardCostDataGridViewTextBoxColumn,
            this.listPriceDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.productCategoryIDDataGridViewTextBoxColumn,
            this.productModelIDDataGridViewTextBoxColumn,
            this.sellStartDateDataGridViewTextBoxColumn,
            this.sellEndDateDataGridViewTextBoxColumn,
            this.discontinuedDateDataGridViewTextBoxColumn,
            this.thumbNailPhotoDataGridViewImageColumn,
            this.thumbnailPhotoFileNameDataGridViewTextBoxColumn,
            this.rowguidDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn});
            this.productgrid.DataSource = this.productBindingSource1;
            this.productgrid.Location = new System.Drawing.Point(14, 6);
            this.productgrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productgrid.Name = "productgrid";
            this.productgrid.ReadOnly = true;
            this.productgrid.RowHeadersWidth = 82;
            this.productgrid.RowTemplate.Height = 33;
            this.productgrid.Size = new System.Drawing.Size(984, 481);
            this.productgrid.TabIndex = 1;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Visible = false;
            this.productIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // productNumberDataGridViewTextBoxColumn
            // 
            this.productNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductNumber";
            this.productNumberDataGridViewTextBoxColumn.HeaderText = "ProductNumber";
            this.productNumberDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
            this.productNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorDataGridViewTextBoxColumn.Width = 200;
            // 
            // standardCostDataGridViewTextBoxColumn
            // 
            this.standardCostDataGridViewTextBoxColumn.DataPropertyName = "StandardCost";
            this.standardCostDataGridViewTextBoxColumn.HeaderText = "StandardCost";
            this.standardCostDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.standardCostDataGridViewTextBoxColumn.Name = "standardCostDataGridViewTextBoxColumn";
            this.standardCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.standardCostDataGridViewTextBoxColumn.Width = 200;
            // 
            // listPriceDataGridViewTextBoxColumn
            // 
            this.listPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice";
            this.listPriceDataGridViewTextBoxColumn.HeaderText = "ListPrice";
            this.listPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
            this.listPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.listPriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn.Width = 200;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn.Width = 200;
            // 
            // productCategoryIDDataGridViewTextBoxColumn
            // 
            this.productCategoryIDDataGridViewTextBoxColumn.DataPropertyName = "ProductCategoryID";
            this.productCategoryIDDataGridViewTextBoxColumn.HeaderText = "ProductCategoryID";
            this.productCategoryIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productCategoryIDDataGridViewTextBoxColumn.Name = "productCategoryIDDataGridViewTextBoxColumn";
            this.productCategoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productCategoryIDDataGridViewTextBoxColumn.Visible = false;
            this.productCategoryIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // productModelIDDataGridViewTextBoxColumn
            // 
            this.productModelIDDataGridViewTextBoxColumn.DataPropertyName = "ProductModelID";
            this.productModelIDDataGridViewTextBoxColumn.HeaderText = "ProductModelID";
            this.productModelIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productModelIDDataGridViewTextBoxColumn.Name = "productModelIDDataGridViewTextBoxColumn";
            this.productModelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productModelIDDataGridViewTextBoxColumn.Visible = false;
            this.productModelIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // sellStartDateDataGridViewTextBoxColumn
            // 
            this.sellStartDateDataGridViewTextBoxColumn.DataPropertyName = "SellStartDate";
            this.sellStartDateDataGridViewTextBoxColumn.HeaderText = "SellStartDate";
            this.sellStartDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.sellStartDateDataGridViewTextBoxColumn.Name = "sellStartDateDataGridViewTextBoxColumn";
            this.sellStartDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellStartDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // sellEndDateDataGridViewTextBoxColumn
            // 
            this.sellEndDateDataGridViewTextBoxColumn.DataPropertyName = "SellEndDate";
            this.sellEndDateDataGridViewTextBoxColumn.HeaderText = "SellEndDate";
            this.sellEndDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.sellEndDateDataGridViewTextBoxColumn.Name = "sellEndDateDataGridViewTextBoxColumn";
            this.sellEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellEndDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // discontinuedDateDataGridViewTextBoxColumn
            // 
            this.discontinuedDateDataGridViewTextBoxColumn.DataPropertyName = "DiscontinuedDate";
            this.discontinuedDateDataGridViewTextBoxColumn.HeaderText = "DiscontinuedDate";
            this.discontinuedDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.discontinuedDateDataGridViewTextBoxColumn.Name = "discontinuedDateDataGridViewTextBoxColumn";
            this.discontinuedDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.discontinuedDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // thumbNailPhotoDataGridViewImageColumn
            // 
            this.thumbNailPhotoDataGridViewImageColumn.DataPropertyName = "ThumbNailPhoto";
            this.thumbNailPhotoDataGridViewImageColumn.HeaderText = "ThumbNailPhoto";
            this.thumbNailPhotoDataGridViewImageColumn.MinimumWidth = 10;
            this.thumbNailPhotoDataGridViewImageColumn.Name = "thumbNailPhotoDataGridViewImageColumn";
            this.thumbNailPhotoDataGridViewImageColumn.ReadOnly = true;
            this.thumbNailPhotoDataGridViewImageColumn.Width = 200;
            // 
            // thumbnailPhotoFileNameDataGridViewTextBoxColumn
            // 
            this.thumbnailPhotoFileNameDataGridViewTextBoxColumn.DataPropertyName = "ThumbnailPhotoFileName";
            this.thumbnailPhotoFileNameDataGridViewTextBoxColumn.HeaderText = "ThumbnailPhotoFileName";
            this.thumbnailPhotoFileNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.thumbnailPhotoFileNameDataGridViewTextBoxColumn.Name = "thumbnailPhotoFileNameDataGridViewTextBoxColumn";
            this.thumbnailPhotoFileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.thumbnailPhotoFileNameDataGridViewTextBoxColumn.Visible = false;
            this.thumbnailPhotoFileNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // rowguidDataGridViewTextBoxColumn
            // 
            this.rowguidDataGridViewTextBoxColumn.DataPropertyName = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.HeaderText = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.rowguidDataGridViewTextBoxColumn.Name = "rowguidDataGridViewTextBoxColumn";
            this.rowguidDataGridViewTextBoxColumn.ReadOnly = true;
            this.rowguidDataGridViewTextBoxColumn.Visible = false;
            this.rowguidDataGridViewTextBoxColumn.Width = 200;
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
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.adventureWorksLT2017DataSet;
            // 
            // adventureWorksLT2017DataSet
            // 
            this.adventureWorksLT2017DataSet.DataSetName = "AdventureWorksLT2017DataSet";
            this.adventureWorksLT2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.adventureWorksLT2017DataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // fKSalesOrderDetailProductProductIDBindingSource
            // 
            this.fKSalesOrderDetailProductProductIDBindingSource.DataMember = "FK_SalesOrderDetail_Product_ProductID";
            this.fKSalesOrderDetailProductProductIDBindingSource.DataSource = this.productBindingSource;
            // 
            // salesOrderDetailTableAdapter
            // 
            this.salesOrderDetailTableAdapter.ClearBeforeFill = true;
            // 
            // searchbtn
            // 
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchbtn.Location = new System.Drawing.Point(755, 503);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(58, 22);
            this.searchbtn.TabIndex = 23;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxtbox
            // 
            this.searchtxtbox.Location = new System.Drawing.Point(817, 503);
            this.searchtxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchtxtbox.Name = "searchtxtbox";
            this.searchtxtbox.Size = new System.Drawing.Size(181, 20);
            this.searchtxtbox.TabIndex = 22;
            // 
            // gotocustomersbtn
            // 
            this.gotocustomersbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gotocustomersbtn.Location = new System.Drawing.Point(903, 539);
            this.gotocustomersbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gotocustomersbtn.Name = "gotocustomersbtn";
            this.gotocustomersbtn.Size = new System.Drawing.Size(95, 41);
            this.gotocustomersbtn.TabIndex = 24;
            this.gotocustomersbtn.Text = "Customers";
            this.gotocustomersbtn.UseVisualStyleBackColor = true;
            this.gotocustomersbtn.Click += new System.EventHandler(this.gotocustomersbtn_Click);
            // 
            // gotoproductmodelbtn
            // 
            this.gotoproductmodelbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gotoproductmodelbtn.Location = new System.Drawing.Point(71, 503);
            this.gotoproductmodelbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gotoproductmodelbtn.Name = "gotoproductmodelbtn";
            this.gotoproductmodelbtn.Size = new System.Drawing.Size(66, 41);
            this.gotoproductmodelbtn.TabIndex = 25;
            this.gotoproductmodelbtn.Text = "Product Model";
            this.gotoproductmodelbtn.UseVisualStyleBackColor = true;
            // 
            // gotoProductDescriptionbtn
            // 
            this.gotoProductDescriptionbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gotoProductDescriptionbtn.Location = new System.Drawing.Point(153, 503);
            this.gotoProductDescriptionbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gotoProductDescriptionbtn.Name = "gotoProductDescriptionbtn";
            this.gotoProductDescriptionbtn.Size = new System.Drawing.Size(66, 41);
            this.gotoProductDescriptionbtn.TabIndex = 26;
            this.gotoProductDescriptionbtn.Text = "Product Description";
            this.gotoProductDescriptionbtn.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 591);
            this.Controls.Add(this.gotoProductDescriptionbtn);
            this.Controls.Add(this.gotoproductmodelbtn);
            this.Controls.Add(this.gotocustomersbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxtbox);
            this.Controls.Add(this.productgrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesOrderDetailProductProductIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productgrid;
        private AdventureWorksLT2017DataSet adventureWorksLT2017DataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private AdventureWorksLT2017DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource fKSalesOrderDetailProductProductIDBindingSource;
        private AdventureWorksLT2017DataSetTableAdapters.SalesOrderDetailTableAdapter salesOrderDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productModelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discontinuedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn thumbNailPhotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thumbnailPhotoFileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxtbox;
        private System.Windows.Forms.Button gotocustomersbtn;
        private System.Windows.Forms.Button gotoproductmodelbtn;
        private System.Windows.Forms.Button gotoProductDescriptionbtn;
    }
}