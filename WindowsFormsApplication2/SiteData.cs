using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class SiteData : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P674M5ML\SQLEXPRESS;Initial Catalog=porject;Integrated Security=True");

        public SiteData()
        {
            InitializeComponent();
        }

        private void SiteData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'porjectDataSet6.Site' table. You can move, or remove it, as needed.
            this.siteTableAdapter.Fill(this.porjectDataSet6.Site);
            con.Open();
           

            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
