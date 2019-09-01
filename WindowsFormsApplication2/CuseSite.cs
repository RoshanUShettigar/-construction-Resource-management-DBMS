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
    public partial class CuseSite : UserControl
    {
        public CuseSite()
        {
            InitializeComponent();
        }
        SqlDataAdapter sda;
        
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            siteuseDel1.Hide();
            siteuseSrch1.Hide();
            siteuseUp1.Hide();
            siteuseIns1.Show();
            siteuseIns1.BringToFront();

           
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void CuseSite_Load(object sender, EventArgs e)
        {
            this.Refresh();
            con.Open();
            panel1.BringToFront();


            con.Close();
            this.Refresh();
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            siteuseDel2.Hide();
            siteuseIns2.Hide();
            siteuseUp2.Hide();
            siteuseSrch2.Show();
            siteuseSrch2.BringToFront();
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            siteuseDel2.Hide();
            siteuseSrch2.Hide();
            siteuseUp2.Hide();
            siteuseIns2.Show();
            siteuseIns2.BringToFront();
        }

        private void btnupS_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            siteuseDel2.Hide();
            siteuseIns2.Hide();
            siteuseSrch2.Hide();
            siteuseUp2.Show();
            siteuseUp2.BringToFront();
        }

        private void btndelS_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            siteuseSrch2.Hide();
            siteuseIns2.Hide();
            siteuseUp2.Hide();
            siteuseDel2.Show();
            siteuseDel2.BringToFront();
        }
        
        private void dataGridViewSite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            this.Refresh();

        }

        private void siteuseUp2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewSite_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            this.Refresh();
           }
    }
}
