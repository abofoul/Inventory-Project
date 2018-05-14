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
    public partial class Add_User : Form
    {
        BL.CLS_Login login = new BL.CLS_Login();
        public Add_User()
        {
            InitializeComponent();
            radioButtonAdmin.Checked = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textName.Text!= string.Empty && textUpassword.Text!= string.Empty && textReupassword.Text!= string.Empty && textName.Text!= string.Empty )
            {
                if (textUpassword.Text != textReupassword.Text)
                {
                    MessageBox.Show("كلمة المرور غير متطابقه");
                    return;
                }
                if (radioButtonAdmin.Checked == true)
                {
                    login.Add_User(textUname.Text, textUpassword.Text, radioButtonAdmin.Text, textName.Text);
                    MessageBox.Show("تمت الاضافه بنجاح");
                    textName.Clear();
                    textReupassword.Clear();
                    textUpassword.Clear();
                    textUname.Clear();
                }
                else if (radioButtonUser.Checked == true)
                {
                    login.Add_User(textUname.Text, textUpassword.Text, radioButtonUser.Text, textName.Text);
                    MessageBox.Show("تمت الاضافه بنجاح");
                    textName.Clear();
                    textReupassword.Clear();
                    textUpassword.Clear();
                    textUname.Clear();
                }
            }
            else
            {
                MessageBox.Show("هناك حقول فارغه");
            }
        }
    }
}
