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
    public partial class CuseSiterq : UserControl
    {
        public CuseSiterq()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            panelSR.Hide();

            siteRuseDel1.Hide();
            siteRuseIn1.Hide();
            siteRuseUp1.Hide();
            siteRuseSrch1.Show();
            siteRuseSrch1.BringToFront();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            panelSR.Hide();
            siteRuseDel1.Hide();
            siteRuseSrch1.Hide();
            siteRuseUp1.Hide();
            siteRuseIn1.Show();
            siteRuseIn1.BringToFront();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            panelSR.Hide();
            siteRuseDel1.Hide();
            siteRuseIn1.Hide();
            siteRuseSrch1.Hide();
            siteRuseUp1.Show();
            siteRuseUp1.BringToFront();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            panelSR.Hide();
            siteRuseSrch1.Hide();
            siteRuseIn1.Hide();
            siteRuseUp1.Hide();
            siteRuseDel1.Show();
            siteRuseDel1.BringToFront();
        }

        private void CuseSiterq_Load(object sender, EventArgs e)
        {
            this.Refresh();
            con.Open();
            panelSR.BringToFront();
            con.Close();
            this.Refresh();
        }

        private void dataGridViewSiteReq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
