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
    public partial class PjuseUp : UserControl
    {
        public PjuseUp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");


        private void btnup_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "select * from Project ";

            SqlCommand query = new SqlCommand("update  Project set pj_name ='" + uptextBox2.Text + "',pj_status='" + uptextBox3.Text + "',pj_detail='" + uptextBox4.Text + "',owner='" + uptextBox5.Text + "',pj_cost='" + uptextBox6.Text + "' where (pj_id='" + uptextBox1.Text + "')", con);
            SqlDataAdapter adpt = new SqlDataAdapter(str, con);

            query.ExecuteNonQuery();
            DataTable dt = new DataTable();

            adpt.Fill(dt);
            dataGridViewProjUP.DataSource = dt;

            MessageBox.Show("updated successfully");
            con.Close();

        }
    }
}
