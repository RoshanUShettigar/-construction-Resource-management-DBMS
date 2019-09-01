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
    public partial class CostuseIn : UserControl
    {
        public CostuseIn()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");

        private void btnInsert_Click(object sender, EventArgs e)
        {

           
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string str = "select * from Cost ";

            SqlCommand cmd = new SqlCommand("CostInsert", con);
            {
               cmd.CommandType = CommandType.StoredProcedure;

            }
            cmd.Parameters.AddWithValue("@ven_bid", intextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@labr_cst", intextBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@pj_basecst", intextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@pj_soldcst", intextBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@pj_id", intextBox5.Text.Trim());
            cmd.Parameters.AddWithValue("@overrun", intextBox6.Text.Trim());
            
            cmd.ExecuteNonQuery();
            SqlDataAdapter adpt = new SqlDataAdapter(str, con);

            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewCostIN.DataSource = dt;

            MessageBox.Show("inserted successfully");
            con.Close();
            this.Refresh();
        }
    }
}
