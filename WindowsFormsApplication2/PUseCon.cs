using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class PUseCon : UserControl
    {
        private static PUseCon _instance;
        public static PUseCon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PUseCon();
                return _instance;
            }
        }
        public PUseCon()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PUseCon_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
