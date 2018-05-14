using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using System.IO;

namespace stock_mangement.PL
{
    public partial class Categories : Form
    {
        SqlConnection con = new SqlConnection(@"server=OMAR-PC;Database=Sales_Mangement; Integrated Security=true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bm;
        SqlCommandBuilder cmd;
        public Categories()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select cat_ID as 'معرف الصنف' , Description as 'اسم الصنف' from Categories", con);
            da.Fill(dt);
            dgvcategories.DataSource = dt;
            textid.DataBindings.Add("text", dt, "معرف الصنف");
            textname.DataBindings.Add("text", dt, "اسم الصنف");
            bm = this.BindingContext[dt];
            labelpos.Text = (bm.Position+1) + "  /  " + bm.Count;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            bm.RemoveAt(bm.Position);
            bm.EndCurrentEdit();
            cmd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Deleted Succesffuly", "Delete Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            labelpos.Text = (bm.Position + 1) + " / " + bm.Count;
        }

        private void labelpos_Click(object sender, EventArgs e)
        {

        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            bm.Position = 0;
            labelpos.Text = (bm.Position + 1) + " / " + bm.Count;
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            bm.Position = bm.Count;
            labelpos.Text = (bm.Position + 1) + " / " + bm.Count;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            bm.Position -= 1; ;
            labelpos.Text = (bm.Position + 1) + " / " + bm.Count;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            bm.Position += 1;
            labelpos.Text = (bm.Position + 1) + " / " + bm.Count;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            bm.AddNew();
            buttonAdd.Enabled = true;
            buttonClear.Enabled = false;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0])+1;
            textid.Text = id.ToString();
            textname.Focus();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bm.EndCurrentEdit();
            cmd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Added Succesffuly", "Add Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonAdd.Enabled = false;
            buttonClear.Enabled = true;
            labelpos.Text = (bm.Position + 1) + " / " + bm.Count;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            bm.EndCurrentEdit();
            cmd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Edited Succesffuly", "Edit Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            labelpos.Text = (bm.Position + 1) + " / " + bm.Count;
        }

        private void buttonPcurrent_Click(object sender, EventArgs e)
        {
            Reports.Single_Cat_Report rep = new Reports.Single_Cat_Report();
            Reports.Product_Report form = new Reports.Product_Report();
            rep.Refresh();
            rep.SetParameterValue("@id", int.Parse(textid.Text));
            form.crystalReportViewer1.ReportSource = rep;
            form.ShowDialog();

        }

        private void buttonPall_Click(object sender, EventArgs e)
        {
            Reports.All_Categories_Report rep = new Reports.All_Categories_Report();
            Reports.Product_Report form = new Reports.Product_Report();
            rep.Refresh();
            form.crystalReportViewer1.ReportSource = rep;
            form.ShowDialog();
        }

        private void buttonPDFall_Click(object sender, EventArgs e)
        {
            string filedes = @"D:\stock proj\Categories.pdf";
            if (File.Exists(filedes))
            {
                File.Delete(filedes);
            }
            Reports.All_Categories_Report report = new Reports.All_Categories_Report();
            //export options obj
            report.Refresh();
            ExportOptions ex = new ExportOptions();
            //create disk obj
            DiskFileDestinationOptions disk = new DiskFileDestinationOptions();
            PdfFormatOptions pdfformat = new PdfFormatOptions();
            
            //set the path
            disk.DiskFileName = @"D:\stock proj\Categories.pdf";
            ex = report.ExportOptions;
            ex.ExportDestinationType = ExportDestinationType.DiskFile;
            ex.ExportFormatType = ExportFormatType.PortableDocFormat;
            ex.ExportFormatOptions = pdfformat;
            ex.ExportDestinationOptions = disk;            
            report.Export();
            MessageBox.Show("Successfuly Stored", "Stored Report", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonPDFcurrent_Click(object sender, EventArgs e)
        {
            string filedes = @"D:\stock proj\CategoryDetails.pdf";
            if (File.Exists(filedes))
            {
                File.Delete(filedes);
            }
            Reports.Single_Cat_Report report = new Reports.Single_Cat_Report();
            report.Refresh();
            //export options obj
            report.SetParameterValue("@id", int.Parse(textid.Text));
            ExportOptions ex = new ExportOptions();
            //create disk obj
            DiskFileDestinationOptions disk = new DiskFileDestinationOptions();
            PdfFormatOptions pdfformat = new PdfFormatOptions();
            //set the path
            disk.DiskFileName = @"D:\stock proj\CategoryDetails.pdf";
            ex = report.ExportOptions;
            ex.ExportDestinationType = ExportDestinationType.DiskFile;
            ex.ExportFormatType = ExportFormatType.PortableDocFormat;
            ex.ExportFormatOptions = pdfformat;
            ex.ExportDestinationOptions = disk;
            report.Export();
            MessageBox.Show("Successfuly Stored", "Stored Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}
