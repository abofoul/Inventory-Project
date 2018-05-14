namespace stock_mangement.PL
{
    partial class Add_User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textUname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textUpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textReupassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uName
            // 
            this.uName.AutoSize = true;
            this.uName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uName.Location = new System.Drawing.Point(43, 58);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(65, 15);
            this.uName.TabIndex = 0;
            this.uName.Text = "اسم المستخدم";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(129, 55);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(240, 20);
            this.textName.TabIndex = 1;
            // 
            // textUname
            // 
            this.textUname.Location = new System.Drawing.Point(129, 81);
            this.textUname.Name = "textUname";
            this.textUname.Size = new System.Drawing.Size(240, 20);
            this.textUname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم الدخول";
            // 
            // textUpassword
            // 
            this.textUpassword.Location = new System.Drawing.Point(129, 107);
            this.textUpassword.Name = "textUpassword";
            this.textUpassword.PasswordChar = '*';
            this.textUpassword.Size = new System.Drawing.Size(240, 20);
            this.textUpassword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "الرقم السرى";
            // 
            // textReupassword
            // 
            this.textReupassword.Location = new System.Drawing.Point(129, 133);
            this.textReupassword.Name = "textReupassword";
            this.textReupassword.PasswordChar = '*';
            this.textReupassword.Size = new System.Drawing.Size(240, 20);
            this.textReupassword.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = " تأكيد الرقم السرى";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "نوع المستخدم";
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdmin.Location = new System.Drawing.Point(161, 160);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(44, 19);
            this.radioButtonAdmin.TabIndex = 9;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "مدير";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonUser.Location = new System.Drawing.Point(268, 160);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(53, 19);
            this.radioButtonUser.TabIndex = 10;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "موظف";
            this.radioButtonUser.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 311);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات المستخدم";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(546, 276);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "إضافه المستخدم";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(252, 275);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "تفريغ الحقول";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 385);
            this.Controls.Add(this.radioButtonUser);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textReupassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textUpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textUname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.uName);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_User";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافه مستخدم";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textUname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textReupassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
    }
}