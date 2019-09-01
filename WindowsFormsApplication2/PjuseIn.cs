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
    public partial class PjuseIn : UserControl
    {
        public PjuseIn()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "select * from Project ";


            String query = "insert into Project(pj_id,pj_name,pj_status,pj_detail,owner,pj_cost) values('" + intextBox1.Text + "','" + intextBox2.Text + "','" + intextBox3.Text + "','" + intextBox4.Text + "','" + intextBox5.Text + "','" + intextBox6.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(str, con);
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewProjIN.DataSource = dt;


            MessageBox.Show("inserted successfully");
            con.Close();
            this.Refresh();

        }
    }
}
