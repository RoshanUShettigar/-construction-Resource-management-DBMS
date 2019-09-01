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
    public partial class MatuseIn : UserControl
    {
        public MatuseIn()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "select * from Materials ";

            SqlCommand sda = new SqlCommand("insert into Materials(Mat_req,quantity,Delivery,Ven_name,Grade) values('" + intextBox1.Text + "','" + intextBox2.Text + "','" + dateTimePicker1.Text + "','" + intextBox4.Text + "','" + intextBox5.Text + "')", con);
            sda.ExecuteNonQuery();
            SqlDataAdapter adpt = new SqlDataAdapter(str, con);

            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewMatIN.DataSource = dt;

            MessageBox.Show("inserted successfully");
            con.Close();
            this.Refresh();
            
        }

        private void intextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MatuseIn_Load(object sender, EventArgs e)
        {

        }
    }
}
