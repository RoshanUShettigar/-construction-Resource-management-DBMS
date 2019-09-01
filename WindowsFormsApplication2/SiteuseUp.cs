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
    public partial class SiteuseUp : UserControl
    {
        public SiteuseUp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");
        private void btnup_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "select * from Site ";

            SqlCommand query = new SqlCommand( "update  Site set Site_id ='" + uptextBox1.Text + "',Site_owner='" + uptextBox2.Text + "',Site_vend='" + uptextBox3.Text + "',Addr='" + uptextBox5.Text + "',Site_Mg='" + uptextBox6.Text + "' where (pj_id='" + uptextBox4.Text + "')",con);
            SqlDataAdapter adpt = new SqlDataAdapter(str, con);

            query.ExecuteNonQuery();
            DataTable dt = new DataTable();

            adpt.Fill(dt);
            dataGridViewSiteUP.DataSource = dt;

            MessageBox.Show("updated successfully");
            this.Refresh();
            con.Close();
           
        }

        private void uptextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void SiteuseUp_Load(object sender, EventArgs e)
        {

        }
    }
}
