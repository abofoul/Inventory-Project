using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports;

namespace stock_mangement.PL
{
    public partial class Manage_Products : Form
    {
        private static Manage_Products form;
        static void form_closed(object sender, FormClosedEventArgs e)
        {
            form = null;
        }

        public static Manage_Products getmainform
        {
            get
            {
                if (form == null)
                {
                    form = new Manage_Products();
                    form.FormClosed += new FormClosedEventHandler(form_closed);
                }
                return form;
            }
        }
        BL.CLS_Products prod = new BL.CLS_Products();
        public Manage_Products()
        {
            InitializeComponent();
            if (form == null)
                form = this;
            this.dataGridView1.DataSource = prod.Get_Products();
        }

        private void Manage_Products_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); ;
            dt = prod.Sarch_Product(textSearch.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                prod.Delete_Product(Convert.ToInt32( this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تم الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = prod.Get_Products();

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addProduct form = new addProduct();
            form.pid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form.textDes.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.textQuantity.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form.textPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form.cmbCAT.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            form.Text = "تحديث بيانات منتج";
            form.btnAdd.Text = "تحديث";
            form.state = "update";
            form.pid.ReadOnly = true;
            if (prod.Get_Image(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0] != System.DBNull.Value)
            {
                byte[] image = (byte[])prod.Get_Image(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
                MemoryStream m = new MemoryStream(image);
                form.pbox.Image = Image.FromStream(m);
                form.ShowDialog();
                
            }
            else
            {
                form.pbox.Image = null;
                form.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Image_Preview form = new Image_Preview();
            byte[] image = (byte[])prod.Get_Image(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream m = new MemoryStream(image);
            form.pictureBox1.Image = Image.FromStream(m);
            form.ShowDialog();
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports.Single_Product_Report myreport = new Reports.Single_Product_Report();
            myreport.SetParameterValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Reports.Product_Report form = new Reports.Product_Report();
            form.crystalReportViewer1.ReportSource = myreport;
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reports.All_Products_Report myrep = new Reports.All_Products_Report();
            Reports.Product_Report form = new Reports.Product_Report();
            myrep.Refresh();
            form.crystalReportViewer1.ReportSource = myrep;
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string filedes = @"D:\stock proj\Products.xls";
            if (File.Exists(filedes))
            {
                File.Delete(filedes);
            }
            Reports.All_Products_Report report = new Reports.All_Products_Report();
            report.Refresh();
            //export options obj
            ExportOptions ex = new ExportOptions();
            //create disk obj
            DiskFileDestinationOptions disk = new DiskFileDestinationOptions();
            ExcelFormatOptions excel = new ExcelFormatOptions();
            //set the path
            disk.DiskFileName=@"D:\stock proj\Products.xls";
            ex = report.ExportOptions;
            ex.ExportDestinationType = ExportDestinationType.DiskFile;
            ex.ExportFormatType = ExportFormatType.Excel;
            ex.ExportFormatOptions = excel;
            ex.ExportDestinationOptions = disk;
            report.Export();
            MessageBox.Show("Successfuly Stored", "Stored Report", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
