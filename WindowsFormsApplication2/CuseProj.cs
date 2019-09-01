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
    public partial class CuseProj : UserControl
    {
        public CuseProj()
        {
            InitializeComponent();
        }
        SqlDataAdapter sda;

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");

        private void CuseProj_Load(object sender, EventArgs e)
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
            pjuseSrch1.Show();
            pjuseSrch1.BringToFront();
            pjuseIn1.Hide();
            pjuseDel1.Hide();
            pjuseUp1.Hide();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            pjuseIn1.Show();
            pjuseIn1.BringToFront();
            pjuseDel1.Hide();
            pjuseSrch1.Hide();
            pjuseUp1.Hide();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            pjuseUp1.Show();
            pjuseUp1.BringToFront();
            pjuseIn1.Hide();
            pjuseSrch1.Hide();
            pjuseDel1.Hide();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            pjuseDel1.Show();
            pjuseDel1.BringToFront();
            pjuseIn1.Hide();
            pjuseSrch1.Hide();
            pjuseUp1.Hide();

        }
    }
}
