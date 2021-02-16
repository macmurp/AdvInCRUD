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
            // TODO: This line of code loads data into the 'adventureWorksLT2017DataSet.SalesOrderDetail' table. You can move, or remove it, as needed.
            this.salesOrderDetailTableAdapter.Fill(this.adventureWorksLT2017DataSet.SalesOrderDetail);
            // TODO: This line of code loads data into the 'adventureWorksLT2017DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.adventureWorksLT2017DataSet.Product);

        }

        private void getData()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("getAllCustomers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter sqld = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqld.Fill(dt);
                productgrid.DataSource = dt;
                conn.Close();
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

        }

        private void gotocustomersbtn_Click(object sender, EventArgs e)
        {
            var c = new Customers();
            c.Show();
            this.Close();
        }
    }
}
