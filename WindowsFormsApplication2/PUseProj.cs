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
    public partial class PUseProj : UserControl
    {

        private static PUseProj _instance;
        public static PUseProj Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PUseProj();
                return _instance;
            }
        }
        public PUseProj()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
