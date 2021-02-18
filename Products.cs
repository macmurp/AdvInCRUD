using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AdvInCRUD
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            //this.getAllProductsTableAdapter.Fill(this.adventureWorksLT2017DataSet2.getAllProducts);
            //initial load
            getData();

        }

        private void getData()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("getAllProducts", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter sqld = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqld.Fill(dt);
                productgrid.DataSource = dt;
                conn.Close();
            }
        }
        private void getDataSearch()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                SqlDataAdapter da = new SqlDataAdapter("SearchProducts", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Name", searchtxtbox.Text.Trim());
                DataTable dt = new DataTable();
                da.Fill(dt);
                productgrid.DataSource = dt;
                conn.Close();
            }
        }
        private void searchbtn_Click(object sender, EventArgs e)
        {
            getDataSearch();
        }

        private void gotocustomersbtn_Click(object sender, EventArgs e)
        {
            var c = new Customers();
            c.Show();
            this.Close();
        }
    }
}
