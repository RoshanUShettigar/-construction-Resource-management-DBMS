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
    public partial class CuseCost : UserControl
    {
        public CuseCost()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");

      

        private void btnDel_Click(object sender, EventArgs e)
        {
        }

        private void btnsrch_Click(object sender, EventArgs e)
        {
        }

        private void btnIns_Click(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }

        private void CuseCost_Load(object sender, EventArgs e)
        {
            this.Refresh();
            con.Open();
            panel1.BringToFront();
            con.Close();
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            costuseDel2.Show();
            costuseDel2.BringToFront();
            costuseIn2.Hide();
            costuseSrch2.Hide();
            costuseUp2.Hide();

        }

        private void btnSrch2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            costuseSrch2.Show();
            costuseSrch2.BringToFront();
            costuseIn2.Hide();
            costuseDel2.Hide();
            costuseUp2.Hide();
        }

        private void btnIn2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            costuseIn2.Show();
            costuseIn2.BringToFront();
            costuseDel2.Hide();
            costuseSrch2.Hide();
            costuseUp2.Hide();

        }

        private void btnUp2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            costuseUp2.Show();
            costuseUp2.BringToFront();
            costuseIn2.Hide();
            costuseSrch2.Hide();
            costuseDel2.Hide();

        }
    }
}
