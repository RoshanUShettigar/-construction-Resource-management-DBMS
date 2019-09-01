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
    public partial class PUseAb : UserControl
    {
        private static PUseAb _instance;
        public static PUseAb Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PUseAb();
                return _instance;
            }
        }
        public PUseAb()
        {
            InitializeComponent();
        }

        private void PUseAb_Load(object sender, EventArgs e)
        {

        }
    }
}
