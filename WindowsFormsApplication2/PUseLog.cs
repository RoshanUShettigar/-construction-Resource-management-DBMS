using System;
using System.Data.SqlClient;
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
    public partial class PUseLog : UserControl
    {
        String str;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");


        private static PUseLog _instance;
        public static PUseLog Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PUseLog();
                return _instance;
            }
        }


        public PUseLog()
        {
            InitializeComponent();
        }

        private void lusename_Click(object sender, EventArgs e)
        {

        }

        private void txtUname_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtPasswd_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            str = "select * from Login where Username ='" + txtUname.Text + "' and Password ='" + txtPasswd.Text + "'";
            da = new SqlDataAdapter(str, con);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login successfull");
                this.Hide();

                CRM ss = new CRM();
                ss.Show();
            }
            else
                MessageBox.Show("Login UnSuccessfull");
        }

        private void btnsubmit(object sender, MouseEventArgs e)
        {
          
            
        }

        private void PUseLog_Load(object sender, EventArgs e)
        {

        }

        private void txtPasswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void llog_Click(object sender, EventArgs e)
        {

        }
    }
}
