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
    public partial class CuseVen : UserControl
    {
        public CuseVen()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");

        private void CuseVen_Load(object sender, EventArgs e)
        {
            this.Refresh();
            con.Open();
            panel1.BringToFront();
           con.Close();
            this.Refresh();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            venuseDel1.Hide();
            venuseIn1.Show();
            venuseIn1.BringToFront();
            venuseSrch1.Hide();
            venuseUp1.Hide();

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            venuseDel1.Hide();
            venuseUp1.Show();
            venuseUp1.BringToFront();
            venuseSrch1.Hide();
            venuseIn1.Hide();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            venuseIn1.Hide();
            venuseDel1.Show();
            venuseDel1.BringToFront();
            venuseSrch1.Hide();
            venuseUp1.Hide();
        }

        private void btnsrch_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            venuseIn1.Hide();
            venuseSrch1.Show();
            venuseSrch1.BringToFront();
            venuseDel1.Hide();
            venuseUp1.Hide();
        }
    }
}
