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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelhome.Hide();
            pUseAb1.Show();
            pUseAb1.BringToFront();
            pUseCon2.Hide();
            pUseLog1.Hide();
            pUseProj1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelhome.Hide();
            pUseAb1.Hide();
            pUseCon2.Hide();
            pUseLog1.Show();
            pUseProj1.Hide();
            pUseLog1.BringToFront();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelhome.Hide();
            pUseAb1.Hide();
            pUseCon2.Hide();
            pUseLog1.Hide();
            pUseProj1.Hide();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            panelhome.Show();
            pUseAb1.Hide();
            pUseCon2.Hide();
            pUseLog1.Hide();
            pUseProj1.Hide();
        }

        private void btnproj_Click(object sender, EventArgs e)
        {
            panelhome.Hide();
            pUseAb1.Hide();
            pUseCon2.Hide();
            pUseLog1.Hide();

            pUseProj1.Show();
            pUseProj1.BringToFront();
        }

        private void btncon_Click(object sender, EventArgs e)
        {
            panelhome.Hide();
            pUseProj1.Hide();
            pUseAb1.Hide();
            pUseCon2.Show();
            pUseLog1.Hide();
            pUseCon2.BringToFront();
        }

        private void pUseProj1_Load(object sender, EventArgs e)
        {

        }
    }
}
