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
    public partial class SiteuseIns : UserControl
    {
        public SiteuseIns()
        {
            InitializeComponent();
        }
         SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");
        private void intextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            con.Open();
            string str = "select * from Site ";

            String query = "insert into Site(Site_id,Site_owner,Site_vend,pj_id,Addr,Site_Mg) values('" + intextBox1.Text + "','" + intextBox2.Text + "','" + intextBox3.Text + "','" + intextBox4.Text + "','" + intextBox5.Text + "','" + intextBox6.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(str,con);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
        sda.Fill(dt);
            dataGridViewSiteIN.DataSource = dt;

            MessageBox.Show("inserted successfully");

            this.Refresh();
           
            con.Close();

            
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SiteuseIns_Load(object sender, EventArgs e)
        {
            
        }
    }
}
