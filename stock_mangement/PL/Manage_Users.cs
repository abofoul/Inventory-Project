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
    public partial class Manage_Users : Form
    {
        BL.CLS_Login log = new BL.CLS_Login();
        public Manage_Users()
        {
            InitializeComponent();            
            this.dgvusers.DataSource =log.Search_User("");
            
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.Text == string.Empty)
            {                
                this.dgvusers.DataSource = log.Search_User(""); 
            }
            else
            {
                this.dgvusers.DataSource = log.Search_User(this.textSearch.Text); 
            }
        }
    }
}
