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
    public partial class SiteRuseUp : UserControl
    {
        public SiteRuseUp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnup_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "select * from Site_req ";

            SqlCommand query = new SqlCommand("update  Site_req set Labr ='" + uptextBox1.Text + "',Matr_stock='" + uptextBox2.Text + "',Estimation='" + uptextBox3.Text + "',Schedule='" + uptextBox5.Text + "',Delivery ='" + dateTimePicker1.Text + "' where (Site_id='" + uptextBox4.Text + "')", con);
            SqlDataAdapter adpt = new SqlDataAdapter(str, con);

            query.ExecuteNonQuery();
            DataTable dt = new DataTable();

            adpt.Fill(dt);
            dataGridViewSiteReqUP.DataSource = dt;

            MessageBox.Show("updated successfully");
            this.Refresh();
            con.Close();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SiteRuseUp_Load(object sender, EventArgs e)
        {

        }
    }
}
