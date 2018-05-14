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
    public partial class Login : Form
    {
        BL.CLS_Login log = new BL.CLS_Login();
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            DataTable dt = log.Login(textId.Text, textPassword.Text);
            if (dt.Rows.Count > 0)
            {
                Main.getmainform.المنتوجاتToolStripMenuItem.Enabled = true;
                Main.getmainform.العملاءToolStripMenuItem.Enabled = true;
                Main.getmainform.المستخدمونToolStripMenuItem.Enabled = true;
                Main.getmainform.انشاءنسخهاحتياطيهToolStripMenuItem.Enabled = true;
                Main.getmainform.استادةنسخهسابقهToolStripMenuItem.Enabled = true;
                Orders form = new Orders();
                Program.salesman = textId.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login FAiled !!!");
            }
        }
    }
}
