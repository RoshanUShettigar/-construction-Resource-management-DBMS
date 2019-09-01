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
    public partial class MatuseUp : UserControl
    {
        public MatuseUp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");
        private void btnup_Click(object sender, EventArgs e)
        {

            con.Open();
            string str = "select * from Materials ";

            SqlCommand query = new SqlCommand("update  Materials set Mat_req ='" + uptextBox1.Text + "',quantity='" + uptextBox2.Text + "',Delivery='" + dateTimePicker1.Text + "',Grade='" + uptextBox5.Text + "' where (Ven_name='" + uptextBox4.Text + "')", con);
            SqlDataAdapter adpt = new SqlDataAdapter(str, con);

            query.ExecuteNonQuery();
            DataTable dt = new DataTable();

            adpt.Fill(dt);
            dataGridViewMatUP.DataSource = dt;

            MessageBox.Show("updated successfully");
            con.Close();
        }
    }
}
