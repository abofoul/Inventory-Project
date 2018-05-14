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

namespace stock_mangement.PL
{
    public partial class Orders : Form
    {
        BL.CLS_Orders orders = new BL.CLS_Orders();
        DataTable dt = new DataTable();

        public void Data()
        {
            dt.Columns.Add("معرف المنتج");
            dt.Columns.Add("اسم المنتج");
            dt.Columns.Add("ثمن الوحده");
            dt.Columns.Add("الكميه ");
            dt.Columns.Add("الثمن الكلى");
            dt.Columns.Add("الخصم(%)");
            dt.Columns.Add("إجمالى المطلوب");
            dataGridView1.DataSource = dt;
        }
        public void dgvresize()
        {
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Columns[0].Width = 106;
            dataGridView1.Columns[1].Width = 214;
            dataGridView1.Columns[2].Width = 113;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 108;
            dataGridView1.Columns[5].Width = 110;
            dataGridView1.Columns[6].Width = 134;
        }
        public Orders()
        {
            InitializeComponent();
            Data();
            dgvresize();
            textOseller.Text = Program.salesman;
            buttonSave.Enabled = false;
            
        }
        void calculate()
        {
            if (textOneprice.Text != string.Empty && textQuantity.Text != string.Empty)
            {
                double result = (Convert.ToDouble(textOneprice.Text) * Convert.ToDouble(textQuantity.Text));
                textTotal.Text = result.ToString();
            }
        }
        void calctobepaid()
        {
            double payment = double.Parse(textTotal.Text) - ((double.Parse(textTotal.Text) * (double.Parse(textDis.Text)) / 100));
            textPay.Text = payment.ToString();
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            textOid.Text = orders.Get_Last_Id().Rows[0][0].ToString();
            buttonNew.Enabled = false;
            buttonSave.Enabled = true;            
        }
        private void cleardata()
        {
            textOid.Clear();
            textOdes.Clear();
            textOseller.Clear();
            textCid.Clear();
            textLname.Clear();
            textFname.Clear();
            textPhone.Clear();
            textMail.Clear();
            pictureBox1.Image = null;
            textPid.Clear();
            textPname.Clear();
            textOneprice.Clear();
            textQuantity.Clear();
            textTotal.Clear();
            textDis.Clear();
            textPay.Clear();
            textSum.Clear();
            dt.Reset();
            dataGridView1.DataSource = null;

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            Customers_List form = new Customers_List();
            form.ShowDialog();
            textCid.Text = form.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textFname.Text = form.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textLname.Text = form.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textPhone.Text = form.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textMail.Text = form.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (form.dataGridView1.CurrentRow.Cells[5].Value != System.DBNull.Value)
            {
                byte[] mat = (byte[])form.dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(mat);
                pictureBox1.Image = Image.FromStream(ms);
            }
            else
            {
                pictureBox1.Image = null;
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
            Product_List form = new Product_List();
            form.ShowDialog();
            textPid.Text = form.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textPname.Text = form.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textOneprice.Text = form.dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void textOneprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != (char)(Keys.Decimal) && e.KeyChar != (char)(Keys.Back) && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void textQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textOneprice_KeyUp(object sender, KeyEventArgs e)
        {
            calculate();
        }

        private void textQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            calculate();
        }

        private void textDis_KeyUp(object sender, KeyEventArgs e)
        {
            if (textTotal.Text.Length == 0 || string.IsNullOrEmpty(textTotal.Text))
            {
                return;
            }
            calctobepaid();
        }

        private void textDis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)(Keys.Back))
            {
                e.Handled = true;
            }
        }
        void clear()
        {
            textPid.Clear();
            textPname.Clear();
            textQuantity.Clear();
            textTotal.Clear();
            textDis.Clear();
            textPay.Clear();
            textOneprice.Clear();
        }
        private void textDis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textPid.Text)
                    {
                        MessageBox.Show("المنتج تم إضافته سابقا", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                DataRow dr = dt.NewRow();
                dr[0] = textPid.Text;
                dr[1] = textPname.Text;
                dr[2] = textOneprice.Text;
                dr[3] = textQuantity.Text;
                dr[4] = textTotal.Text;
                dr[5] = textDis.Text;
                dr[6] = textPay.Text;
                dt.Rows.Add(dr);
                dataGridView1.DataSource = dt;
                clear();
                button1.Focus();
                double sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    sum += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                }
                textSum.Text = sum.ToString();
                sum = 0;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textPid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textPname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textOneprice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textQuantity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textTotal.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textDis.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textPay.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                sum += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
            }
            textSum.Text = sum.ToString();
            sum = 0;


        }

        private void buttonDeleterow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                double sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    sum += double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                }
                textSum.Text = sum.ToString();
                sum = 0;
                MessageBox.Show("تم الحذف");
            }
            else
                MessageBox.Show("Nothing to remove");
        }


        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1_DoubleClick(sender, e);
        }

        private void حذفالسطرالحالىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void تفريغالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.Refresh();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textCid.Text == string.Empty || textOid.Text == string.Empty || dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("هناك بيانات مفقوده");
                return;
            }
            orders.Add_Order(dateTimePicker1.Value, textOdes.Text, textOseller.Text, Convert.ToInt32(textCid.Text));
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                orders.Add_oDetails(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value),
                    Convert.ToInt32(textOid.Text),
                    dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value.ToString()),
                    dataGridView1.Rows[i].Cells[4].Value.ToString(),
                    dataGridView1.Rows[i].Cells[6].Value.ToString(),
                    Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value)
                  );
            }
            MessageBox.Show("Order Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonNew.Enabled = true;
            buttonSave.Enabled = false;
            buttonPrint.Enabled = true;
            cleardata();
            buttonNew_Click(sender, e);

        }

        private void textQuantity_Leave(object sender, EventArgs e)
        {
            if (textQuantity.Text.Length != 0)
            {
                if (orders.Verify_Quantity(Convert.ToInt32(textPid.Text), Convert.ToInt32(textQuantity.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("الكميه فى المخزن غير كافيه", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textQuantity.Focus();
                    return;
                }
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int id = Convert.ToInt32(orders.Get_Last_Id_For_Print().Rows[0][0]);
            Reports.Report_Orders rep = new Reports.Report_Orders();
            rep.Refresh();
            rep.SetDataSource(orders.Get_Order_Details(id));
            Reports.Product_Report frm = new Reports.Product_Report();
            frm.crystalReportViewer1.ReportSource = rep;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
            
        }


    }
}
