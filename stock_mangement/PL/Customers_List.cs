using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_mangement.PL
{
    public partial class Customers_List : Form
    {
        BL.CLS_Customers customer = new BL.CLS_Customers();
        public Customers_List()
        {
            InitializeComponent();
            dataGridView1.DataSource = customer.Get_All_Customers();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
