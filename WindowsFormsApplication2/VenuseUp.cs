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
    public partial class VenuseUp : UserControl
    {
        public VenuseUp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");

        private void btnup_Click(object sender, EventArgs e)
        {

            con.Open();
            string str = "select * from Vendor ";

            SqlCommand query = new SqlCommand("update  Vendor set Name ='" + uptextBox1.Text + "',Addr ='" + uptextBox3.Text + "',Cont_no ='" + uptextBox4.Text + "',bid ='" + uptextBox5.Text + "',Mkt_rtg='" + uptextBox6.Text + "' where (pj_id='" + uptextBox2.Text + "')", con);
            SqlDataAdapter adpt = new SqlDataAdapter(str, con);

            query.ExecuteNonQuery();
            DataTable dt = new DataTable();

            adpt.Fill(dt);
            dataGridViewVenUP.DataSource = dt;

            MessageBox.Show("updated successfully");
            con.Close();
        }
    }
}
