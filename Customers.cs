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

        private void getData()
        {
            using(SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
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

        private void customergrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
                {

                    SqlCommand acmd = new SqlCommand("UpdateCustomer", conn);
                    acmd.CommandType = CommandType.StoredProcedure;
                    acmd.Parameters.AddWithValue("@mode", "Add");
                    acmd.Parameters.AddWithValue("@ContactID", 0);
                    acmd.Parameters.AddWithValue("@Title", titletxtbox.Text.Trim());
                    acmd.Parameters.AddWithValue("@LastName", lasttxtbox.Text.Trim());
                    acmd.Parameters.AddWithValue("@MiddleName", middletxtbox.Text.Trim());
                    acmd.Parameters.AddWithValue("@FirstName", firsttxtbox.Text.Trim());
                    acmd.Parameters.AddWithValue("@Suffix", suffixtxtbox.Text.Trim());
                    acmd.Parameters.AddWithValue("@CompanyName", companytxtbox.Text.Trim());
                    acmd.Parameters.AddWithValue("@EmailAddress", emailtxtbox.Text.Trim());
                    acmd.Parameters.AddWithValue("@Phone", phonetxtbox.Text.Trim());
                    acmd.Parameters.AddWithValue("@PasswordHash", 0);
                    acmd.Parameters.AddWithValue("@PasswordSalt", 0);
                    conn.Close();
                    
                }
                getData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void getDataSearch()
        {
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
            try
            {
                getDataSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void gotoproductbtn_Click(object sender, EventArgs e)
        {
            var p = new Products();
            p.Show();
            this.Hide();
        }
    }
}
