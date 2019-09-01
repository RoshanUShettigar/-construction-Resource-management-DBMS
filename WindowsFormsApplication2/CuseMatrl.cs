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
    public partial class CuseMatrl : UserControl
    {
        public CuseMatrl()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CuseMatrl_Load(object sender, EventArgs e)
        {
            this.Refresh();
            con.Open();
            panel1.BringToFront();
            con.Close();
            this.Refresh();
        }

        private void btnsrch_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            matuseSrch1.Show();
            matuseSrch1.BringToFront();
            matuseIn1.Hide();
            matuseDel1.Hide();
            matuseUp1.Hide();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            matuseIn1.Show();
            matuseIn1.BringToFront();
            matuseDel1.Hide();
            matuseSrch1.Hide();
            matuseUp1.Hide();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            matuseUp1.Show();
            matuseUp1.BringToFront();
            matuseIn1.Hide();
            matuseSrch1.Hide();
            matuseDel1.Hide();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            matuseDel1.Show();
            matuseDel1.BringToFront();
            matuseIn1.Hide();
            matuseSrch1.Hide();
            matuseUp1.Hide();
                
        }

        private void matuseIn1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
