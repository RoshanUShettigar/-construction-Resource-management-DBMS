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
    public partial class SiteuseSrch : UserControl
    {
        public SiteuseSrch()
        {
            InitializeComponent();

        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");
        private static SiteuseSrch _instance;
        public static SiteuseSrch Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SiteuseSrch();
               }
                return _instance;

            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void btnscrh_Click(object sender, EventArgs e)
        {

            con.Open();
            string str = "select * from Site where( pj_id='" + srchtextBox1.Text + "')";
            SqlCommand query = new SqlCommand("select * from Site where( pj_id='" + srchtextBox1.Text + "')", con);
            SqlDataAdapter adpt = new SqlDataAdapter(str, con);
            query.ExecuteNonQuery();
            DataTable dt = new DataTable();

           adpt.Fill(dt);
            dataGridViewSiteSRCH.DataSource = dt;
            MessageBox.Show(" search successfully");


            con.Close();
            
        }
     

        private void SiteuseSrch_Load(object sender, EventArgs e)
       {
      
      }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }




}