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
    public partial class PjuseSrch : UserControl
    {
        public PjuseSrch()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");
        private void btnscrh_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand query = new SqlCommand("select * from Project where( pj_id ='" + srchtextBox1.Text + "')", con);
            string str = "select * from Project where( pj_id='" + srchtextBox1.Text + "')";
            SqlDataAdapter adpt = new SqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewProjSRCH.DataSource = dt;

            query.ExecuteNonQuery();

            MessageBox.Show(" search successfully");

            con.Close();
        }

        private void PjuseSrch_Load(object sender, EventArgs e)
        {
            con.Open();
            string str = "exec Proj_count";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            count.Text = rd[""].ToString();
            rd.Close();
            con.Close();

        }
    }
}
