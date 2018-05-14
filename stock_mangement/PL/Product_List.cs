﻿using System;
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
    
    public partial class Product_List : Form
    {
        BL.CLS_Products prod = new BL.CLS_Products();
        public Product_List()
        {
            InitializeComponent();
            dataGridView1.DataSource = prod.Get_Products();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
