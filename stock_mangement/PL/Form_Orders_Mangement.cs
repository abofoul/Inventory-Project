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
    public partial class Form_Orders_Mangement : Form
    {
        BL.CLS_Orders orders = new BL.CLS_Orders();
        public Form_Orders_Mangement()
        {
            InitializeComponent();
            dataGridView1.DataSource = orders.Search_Orders("");
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            try {
                dataGridView1.DataSource = orders.Search_Orders(textSearch.Text);
            }
            catch
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Reports.Report_Orders rep = new Reports.Report_Orders();
            rep.Refresh();
            rep.SetDataSource(orders.Get_Order_Details(id));
            Reports.Product_Report frm = new Reports.Product_Report();
            frm.crystalReportViewer1.ReportSource = rep;
            frm.ShowDialog();
        }
    }
}
