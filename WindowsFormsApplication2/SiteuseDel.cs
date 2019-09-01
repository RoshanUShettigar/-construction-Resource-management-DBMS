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
    public partial class SiteuseDel : UserControl
    {
        public SiteuseDel()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "select * from Site ";

            SqlCommand query = new SqlCommand("delete  from Site where (pj_id = '"+ deltextBox1.Text +"')",con);
            SqlDataAdapter adpt = new SqlDataAdapter(str, con);

            query.ExecuteNonQuery();
            DataTable dt = new DataTable();

            adpt.Fill(dt);
            dataGridViewSiteDEL.DataSource = dt;

            MessageBox.Show("deletion successfully");
            con.Close();
        }

        private void SiteuseDel_Load(object sender, EventArgs e)
        {

        }
    }

}
