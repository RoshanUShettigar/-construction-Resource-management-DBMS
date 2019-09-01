using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication2
{
    public partial class SiteRuseIn : UserControl
    {
        public SiteRuseIn()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");
        DataTable dt = new DataTable();
        private void btnInsert_Click(object sender, EventArgs e)
        {

            con.Open();
            string str = "select * from Site_req ";

            SqlCommand cmd = new SqlCommand("siteRen", con)
            {
                CommandType = CommandType.StoredProcedure

            };
            cmd.Parameters.AddWithValue("@Labr", intextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@Matr_stock", intextBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@Estimation", intextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@Site_id", intextBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@Schedule", intextBox5.Text.Trim());
            cmd.Parameters.AddWithValue("@Delivery", dateTimePicker1.Text.Trim());
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(str, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewSiteReqIN.DataSource = dt;



            MessageBox.Show("inserted successfully");
            con.Close();
            this.Refresh();
        }
    }
}
