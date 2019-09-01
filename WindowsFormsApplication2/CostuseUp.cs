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
    public partial class CostuseUp : UserControl
    {
        public CostuseUp()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");
        private void btnup_Click(object sender, EventArgs e)
        {


        }

        private void btnup_Click_1(object sender, EventArgs e)
        {

            con.Open();
            string str = "select * from Cost ";

            SqlCommand query = new SqlCommand("update  Cost set ven_bid ='" + uptextBox1.Text + "',labr_cst='" + uptextBox2.Text + "',pj_basecst='" + uptextBox3.Text + "',pj_soldcst='" + uptextBox4.Text + "',overrun='" + uptextBox6.Text + "' where (pj_id='" + uptextBox5.Text + "')", con);
            SqlDataAdapter adpt = new SqlDataAdapter(str, con);

            query.ExecuteNonQuery();
            DataTable dt = new DataTable();

            adpt.Fill(dt);
            dataGridViewCostUP.DataSource = dt;

            MessageBox.Show("updated successfully");
            this.Refresh();
            con.Close();
        }

        private void CostuseUp_Load(object sender, EventArgs e)
        {

        }
    }
}
