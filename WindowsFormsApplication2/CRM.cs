using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class CRM : Form
    {
        public CRM()
        {
            InitializeComponent();
        }

        private void CRM_Load(object sender, EventArgs e)
        {
            
        }

        private void cuseCost1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cuseCost1.Hide();
            cuseMatrl1.Hide();
            cuseProj1.Hide();
            cuseSite1.Hide();
            cuseSiterq1.Hide();
            cuseVen1.Hide();

        }

        private void btnven_Click(object sender, EventArgs e)
        {
            
            cuseCost1.Hide();
            cuseMatrl1.Hide();
            cuseProj1.Hide();
            cuseSite1.Hide();
            cuseSiterq1.Hide();
            cuseVen1.Show();
            cuseVen1.BringToFront();
        }

        private void btnsite_Click(object sender, EventArgs e)
        {

            cuseCost1.Hide();
            cuseMatrl1.Hide();
            cuseProj1.Hide();
            cuseSite1.Show();
            cuseSite1.BringToFront();
            cuseSiterq1.Hide();
            cuseVen1.Hide();
        }

        private void btnsiterq_Click(object sender, EventArgs e)
        {

            cuseCost1.Hide();
            cuseMatrl1.Hide();
            cuseProj1.Hide();
            cuseSite1.Hide();
            cuseSiterq1.Show();
            cuseSiterq1.BringToFront();
            cuseVen1.Hide();
        }

        private void btnprj_Click(object sender, EventArgs e)
        {

            cuseCost1.Hide();
            cuseMatrl1.Hide();
            cuseProj1.Show();
            cuseProj1.BringToFront();
            cuseSite1.Hide();
            cuseSiterq1.Hide();
            cuseVen1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            cuseCost1.Show();
            cuseCost1.BringToFront();
            cuseMatrl1.Hide();
            cuseProj1.Hide();
            cuseSite1.Hide();
            cuseSiterq1.Hide();
            cuseVen1.Hide();
        }

        private void btnMat_Click(object sender, EventArgs e)
        {
            cuseCost1.Hide();
            cuseMatrl1.Show();
            cuseMatrl1.BringToFront();
            cuseProj1.Hide();
            cuseSite1.Hide();
            cuseSiterq1.Hide();
            cuseVen1.Hide();
        }

        private void btnven_Click_1(object sender, EventArgs e)
        {
            cuseCost1.Hide();
            cuseMatrl1.Hide();
            cuseSite1.Hide();
            cuseProj1.Hide();
            
            cuseSiterq1.Hide();
            cuseVen1.Show();
            cuseVen1.BringToFront();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
      
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
