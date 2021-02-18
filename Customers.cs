using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AdvInCRUD
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            //this.getAllCustomersTableAdapter.Fill(this.adventureWorksLT2017DataSet1.getAllCustomers);
            // load table initial
            getData();

        }

        private void getData()
        {
            using(SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                //reload on command
                SqlCommand cmd = new SqlCommand("getAllCustomers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter sqld = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqld.Fill(dt);
                customergrid.DataSource = dt;
                conn.Close();
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void getDataSearch()
        {
            //search button to make testing for successful updates and adds easier
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                SqlDataAdapter da = new SqlDataAdapter("SearchCustomers", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Name", searchtxtbox.Text.Trim());
                DataTable dt = new DataTable();
                da.Fill(dt);
                customergrid.DataSource = dt;
                conn.Close();
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            getDataSearch();

        }

        private void gotoproductbtn_Click(object sender, EventArgs e)
        {
            //open the products (read only) form
            var p = new Products();
            p.Show();
            this.Hide();
        }

        private void customergrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if(customergrid.CurrentRow != null)
            //{
                //try
                //{
                //    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                //    {
                //        conn.Open();
                //        DataGridViewRow drow = customergrid.CurrentRow;
                //        SqlCommand cmd = new SqlCommand("UpdateCustomer", conn);
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        if (drow.Cells["txtid"].Value == DBNull.Value)
                //        {
                //            //if the id of the current row being edited is null, that means you are adding a new row
                //            //make a new ID instead
                //            //logic inside the stored procedure will see this and know it is an insert
                //            cmd.Parameters.AddWithValue("@CustomerID", 0);
                //            cmd.Parameters.AddWithValue("@AddressID", 0);
                //        }
                //        else
                //        {
                //            //if editing a row, id of current row will be used
                //            //logic inside the stored procedure will see this and know it is an update
                //            cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(drow.Cells["txtid"].Value));
                //            cmd.Parameters.AddWithValue("@AddressID", Convert.ToInt32(drow.Cells["txtaddressid"].Value));

                //        }
                //        //if value of cell is null, pass empty string
                //        cmd.Parameters.AddWithValue("@Title", drow.Cells["txttitle"].Value == DBNull.Value ? "" : drow.Cells["txttitle"].Value);
                //        cmd.Parameters.AddWithValue("@FirstName", drow.Cells["txtfirst"].Value == DBNull.Value ? "" : drow.Cells["txtfirst"].Value);
                //        cmd.Parameters.AddWithValue("@LastName", drow.Cells["txtlast"].Value == DBNull.Value ? "" : drow.Cells["txtlast"].Value);
                //        cmd.Parameters.AddWithValue("@MiddleName", drow.Cells["txtmiddle"].Value == DBNull.Value ? "" : drow.Cells["txtmiddle"].Value);
                //        cmd.Parameters.AddWithValue("@Suffix", drow.Cells["txtsuffix"].Value == DBNull.Value ? "" : drow.Cells["txtsuffix"].Value);
                //        cmd.Parameters.AddWithValue("@CompanyName", drow.Cells["txtcompany"].Value == DBNull.Value ? "" : drow.Cells["txtcompany"].Value);
                //        cmd.Parameters.AddWithValue("@EmailAddress", drow.Cells["txtemail"].Value == DBNull.Value ? "" : drow.Cells["txtemail"].Value);
                //        cmd.Parameters.AddWithValue("@Phone", drow.Cells["txtphone"].Value == DBNull.Value ? "" : drow.Cells["txtphone"].Value);
                //        cmd.Parameters.AddWithValue("@SalesPerson", drow.Cells["txtsalesperson"].Value == DBNull.Value ? "" : drow.Cells["txtsalesperson"].Value);
                //        cmd.Parameters.AddWithValue("@PasswordHash", 0);
                //        cmd.Parameters.AddWithValue("@PasswordSalt", 0);

                //        cmd.Parameters.AddWithValue("@AddressType", drow.Cells["txtaddresstype"].Value == DBNull.Value ? "" : drow.Cells["txtaddresstype"].Value);
                //        cmd.Parameters.AddWithValue("@AddressLine1", drow.Cells["txtaddressline1"].Value == DBNull.Value ? "" : drow.Cells["txtaddressline1"].Value);
                //        cmd.Parameters.AddWithValue("@AddressLine2", drow.Cells["txtaddressline2"].Value == DBNull.Value ? "" : drow.Cells["txtaddressline2"].Value);
                //        cmd.Parameters.AddWithValue("@City", drow.Cells["txtcity"].Value == DBNull.Value ? "" : drow.Cells["txtcity"].Value);
                //        cmd.Parameters.AddWithValue("@StateProvince", drow.Cells["txtstateprovince"].Value == DBNull.Value ? "" : drow.Cells["txtstateprovince"].Value);
                //        cmd.Parameters.AddWithValue("@CountryRegion", drow.Cells["txtcountryregion"].Value == DBNull.Value ? "" : drow.Cells["txtcountryregion"].Value);
                //        cmd.Parameters.AddWithValue("@PostalCode", drow.Cells["txtpostalcode"].Value == DBNull.Value ? "" : drow.Cells["txtpostalcode"].Value);

                //        cmd.ExecuteNonQuery();
                //    }
                //    //need to press refresh to see results
                //    //change to update button later?
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, "Error");
                //}
            //}
        }

        private void customergrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if(customergrid.CurrentRow.Cells["txtid"].Value != DBNull.Value)
            {
                if(MessageBox.Show("Confirm deletion of row?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //to avoid accidental deletion, a message box confirmation is required to continue
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                    {
                        SqlCommand cmd = new SqlCommand("DeleteCustomer", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(customergrid.CurrentRow.Cells["txtid"].Value));
                        cmd.Parameters.AddWithValue("@AddressID", Convert.ToInt32(customergrid.CurrentRow.Cells["txtaddressid"].Value));
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                else
                {
                    e.Cancel = true;
                    //if user says no or closes, then the event e is canceled
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {
                    conn.Open();
                    DataGridViewRow drow = customergrid.CurrentRow;
                    SqlCommand cmd = new SqlCommand("UpdateCustomer", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (drow.Cells["txtid"].Value == DBNull.Value)
                    {
                        //if the id of the current row being edited is null, that means you are adding a new row
                        //make a new ID instead
                        //logic inside the stored procedure will see this and know it is an insert
                        cmd.Parameters.AddWithValue("@CustomerID", 0);
                        cmd.Parameters.AddWithValue("@AddressID", 0);
                    }
                    else
                    {
                        //if editing a row, id of current row will be used
                        //logic inside the stored procedure will see this and know it is an update
                        cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(drow.Cells["txtid"].Value));
                        cmd.Parameters.AddWithValue("@AddressID", Convert.ToInt32(drow.Cells["txtaddressid"].Value));

                    }

                    //drow.Cells["txtlast"].Value == DBNull.Value ? "" : 
                    cmd.Parameters.AddWithValue("@Title", drow.Cells["txttitle"].Value);
                    cmd.Parameters.AddWithValue("@FirstName", drow.Cells["txtfirst"].Value);
                    cmd.Parameters.AddWithValue("@LastName", drow.Cells["txtlast"].Value);
                    cmd.Parameters.AddWithValue("@MiddleName", drow.Cells["txtmiddle"].Value);
                    cmd.Parameters.AddWithValue("@Suffix", drow.Cells["txtsuffix"].Value);
                    cmd.Parameters.AddWithValue("@CompanyName", drow.Cells["txtcompany"].Value);
                    cmd.Parameters.AddWithValue("@EmailAddress", drow.Cells["txtemail"].Value);
                    cmd.Parameters.AddWithValue("@Phone", drow.Cells["txtphone"].Value);
                    cmd.Parameters.AddWithValue("@SalesPerson", drow.Cells["txtsalesperson"].Value);
                    cmd.Parameters.AddWithValue("@PasswordHash", 0);
                    cmd.Parameters.AddWithValue("@PasswordSalt", 0);

                    cmd.Parameters.AddWithValue("@AddressType", drow.Cells["txtaddresstype"].Value);
                    cmd.Parameters.AddWithValue("@AddressLine1", drow.Cells["txtaddressline1"].Value);
                    cmd.Parameters.AddWithValue("@AddressLine2", drow.Cells["txtaddressline2"].Value);
                    cmd.Parameters.AddWithValue("@City", drow.Cells["txtcity"].Value);
                    cmd.Parameters.AddWithValue("@StateProvince", drow.Cells["txtstateprovince"].Value);
                    cmd.Parameters.AddWithValue("@CountryRegion", drow.Cells["txtcountryregion"].Value);
                    cmd.Parameters.AddWithValue("@PostalCode", drow.Cells["txtpostalcode"].Value);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Customers_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
