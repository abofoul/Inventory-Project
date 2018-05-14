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
    public partial class Manage_Customers : Form
    {
        BL.CLS_Customers customer = new BL.CLS_Customers();
        int position=0,id;
        public Manage_Customers()
        {
            InitializeComponent();
            dataGridView1.DataSource = customer.Get_All_Customers();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.AllowUserToAddRows = false;
            textFname.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            textLname.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            textPhone.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            textMail.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            id = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
            buttonAdd.Enabled = false;

            Cuspbox.Image = null;
            if (dataGridView1.Rows[0].Cells[5].Value != System.DBNull.Value)
            {
                byte[] pic = (byte[])dataGridView1.Rows[0].Cells[5].Value;
                MemoryStream ms = new MemoryStream(pic);
                Cuspbox.Image = Image.FromStream(ms);
            }
            else
            {
                Cuspbox.Image = null;
            }


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            byte[] mat;
            if (Cuspbox.Image == null)
            {

                mat = new byte[0];
                customer.Add_Customer(textFname.Text, textLname.Text, textPhone.Text, textMail.Text, mat, "nopic");
                MessageBox.Show("Added Successfuly", "Add operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = customer.Get_All_Customers();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.AllowUserToAddRows = false;
            }
            else
            {
                MemoryStream mem = new MemoryStream();
                Cuspbox.Image.Save(mem, Cuspbox.Image.RawFormat);
                mat = mem.ToArray();
                customer.Add_Customer(textFname.Text, textLname.Text, textPhone.Text, textMail.Text, mat, "pic");
                MessageBox.Show("Added Successfuly", "Add operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = customer.Get_All_Customers();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.AllowUserToAddRows = false;
            }
            buttonClear.Enabled = true;
        }

        private void Cuspbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Images files |*.JPG;*.PNG;*.GIF;*.BMP";
            if (op.ShowDialog() == DialogResult.OK)
            {
                Cuspbox.Image = Image.FromFile(op.FileName);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textFname.Clear();
            textLname.Clear();
            textMail.Clear();
            textPhone.Clear();
            Cuspbox.Image = null;
            buttonAdd.Enabled = true;
            buttonClear.Enabled = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Cuspbox.Image = null;
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            textFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textMail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            position = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex);
            if (dataGridView1.CurrentRow.Cells[5].Value != System.DBNull.Value)
            {
                byte[] pic = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(pic);
                Cuspbox.Image = Image.FromStream(ms);
            }
            else
            {
                Cuspbox.Image = null;
            }

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            byte[] mat;
            if (Cuspbox.Image == null)
            {

                mat = new byte[0];
                customer.Update_Customer(textFname.Text, textLname.Text, textPhone.Text, textMail.Text, mat, "nopic", id);
                MessageBox.Show("Data modified Successfuly", "Modify operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = customer.Get_All_Customers();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.AllowUserToAddRows = false;
            }
            else
            {
                MemoryStream mem = new MemoryStream();
                Cuspbox.Image.Save(mem, Cuspbox.Image.RawFormat);
                mat = mem.ToArray();
                customer.Update_Customer(textFname.Text, textLname.Text, textPhone.Text, textMail.Text, mat, "pic", id);
                MessageBox.Show("Data Modified Successfuly", "Add operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = customer.Get_All_Customers();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.AllowUserToAddRows = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Do you want to delete ?", "Deletion Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    customer.Delete_Customer(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    dataGridView1.DataSource = customer.Get_All_Customers();
                }
            }
            else
            {
                MessageBox.Show("There is no selected customers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customer.Search_Customer(textSearch.Text);
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch_Click(sender, e);
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.Text.Length == 0)
            {
                dataGridView1.DataSource = customer.Get_All_Customers();
            }
        }
        public void Naviagte(int index)
        {
            Cuspbox.Image = null;            
            DataRowCollection drc = customer.Get_All_Customers().Rows;
            id = Convert.ToInt32(drc[index][0]);
            textFname.Text = drc[index][1].ToString();
            textLname.Text = drc[index][2].ToString();
            textPhone.Text = drc[index][3].ToString();
            textMail.Text = drc[index][4].ToString();
            if (drc[index][5] == System.DBNull.Value)
            {
                Cuspbox.Image = null;
                return;
            }
            byte[] pic = (byte[])drc[index][5];
            MemoryStream ms = new MemoryStream(pic);
            Cuspbox.Image = Image.FromStream(ms);
            //make changes according to navigation            
            
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            Naviagte(0);
            position = 0;
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            position = customer.Get_All_Customers().Rows.Count-1;
            Naviagte(position);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (position == 0)
            {
                MessageBox.Show("This is the first element", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            position -= 1;
            Naviagte(position);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (position == customer.Get_All_Customers().Rows.Count-1)
            {
                MessageBox.Show("This is the last element", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            position += 1;
            Naviagte(position);
        }

    }
}

