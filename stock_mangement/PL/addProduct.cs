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
    public partial class addProduct : Form
    {
        BL.CLS_Products prod = new BL.CLS_Products();
        public string state = "add";
        public addProduct()
        {
            InitializeComponent();
            cmbCAT.DataSource = prod.Get_Categories();
            cmbCAT.DisplayMember = "Description";
            cmbCAT.ValueMember = "cat_ID";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.Filter = "Images files |*.JPG;*.PNG;*.GIF;*.BMP";
            if (browse.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(browse.FileName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textAdd_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                byte[] bt;
                if (pbox.Image == null)
                {
                    
                     bt = new byte[0];
                    prod.Add_Product(Convert.ToInt32(pid.Text), textDes.Text, textPrice.Text, Convert.ToInt32(textQuantity.Text), bt, Convert.ToInt32(cmbCAT.SelectedValue),"nopic");
                    MessageBox.Show("Data added Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Controls.Clear();
                    InitializeComponent();
                    cmbCAT.DataSource = prod.Get_Categories();
                    cmbCAT.DisplayMember = "Description";
                    cmbCAT.ValueMember = "cat_ID";
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    bt = ms.ToArray();
                    prod.Add_Product(Convert.ToInt32(pid.Text), textDes.Text, textPrice.Text, Convert.ToInt32(textQuantity.Text), bt, Convert.ToInt32(cmbCAT.SelectedValue),"pic");
                    MessageBox.Show("Data added Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Controls.Clear();
                    InitializeComponent();
                    cmbCAT.DataSource = prod.Get_Categories();
                    cmbCAT.DisplayMember = "Description";
                    cmbCAT.ValueMember = "cat_ID";
                }
                
            }
            else
            {
                byte[] bt;
                if (pbox.Image != null)
                {
                    MemoryStream mem = new MemoryStream();
                    pbox.Image.Save(mem, pbox.Image.RawFormat);
                    bt = mem.ToArray();
                    prod.Update_Products(Convert.ToInt32(pid.Text), textDes.Text, textPrice.Text, Convert.ToInt32(textQuantity.Text), bt, Convert.ToInt32(cmbCAT.SelectedValue),"pic");
                    MessageBox.Show("Data Modified Successfully", "Successfuly Modified", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bt = new byte[0];
                    prod.Update_Products(Convert.ToInt32(pid.Text), textDes.Text, textPrice.Text, Convert.ToInt32(textQuantity.Text), bt, Convert.ToInt32(cmbCAT.SelectedValue), "nopic");
                    MessageBox.Show("Data Modified Successfully", "Successfuly Modified", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            Manage_Products.getmainform.dataGridView1.DataSource = prod.Get_Products();

            

            
        }

        private void pid_Validated(object sender, EventArgs e)
        {
            if (pid.TextLength == 0)
            {
                MessageBox.Show("Can't be empty");
            }
            else
            {
                if (state == "add")
                {
                    DataTable dt = new DataTable();
                    dt = prod.VerifyID(Convert.ToInt32(pid.Text));
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("المعرف موجوجد مسبقاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        pid.Focus();
                    }
                }
            }
        }

        private void textClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
