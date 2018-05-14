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
    public partial class Main : Form
    {
        private static Main form;
        static void form_closed(object sender,FormClosedEventArgs e)
        {
            form = null;
        }

        public static Main getmainform
        {
            get
            {
                if (form == null)
                {
                    form = new Main();
                    form.FormClosed += new FormClosedEventHandler(form_closed);
                }
                return form;
            }
        }
        public Main()
        {
            InitializeComponent();
            if (form == null)
            {
                form = this;
            }
            this.المنتوجاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.انشاءنسخهاحتياطيهToolStripMenuItem.Enabled = false;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            this.استادةنسخهسابقهToolStripMenuItem.Enabled = false;
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.ShowDialog();
        }

        private void استادةنسخهسابقهToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافهمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addProduct form = new addProduct();
            form.ShowDialog();
        }

        private void ادارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Products form = new Manage_Products();
            form.ShowDialog();
        }

        private void ادارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories form = new Categories();
            form.ShowDialog();
        }

        private void إدارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Customers form = new Manage_Customers();
            form.ShowDialog();
        }

        private void إضافةبيعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders form = new Orders();
            form.ShowDialog();
        }

        private void إدارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Orders_Mangement form = new Form_Orders_Mangement();
            form.ShowDialog();
        }

        private void إضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_User form = new Add_User();
            form.ShowDialog();
        }

        
    }
}
