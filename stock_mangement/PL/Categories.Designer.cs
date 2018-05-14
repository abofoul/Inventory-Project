namespace stock_mangement.PL
{
    partial class Categories
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelpos = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.textname = new System.Windows.Forms.TextBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPall = new System.Windows.Forms.Button();
            this.buttonPDFcurrent = new System.Windows.Forms.Button();
            this.buttonPDFall = new System.Windows.Forms.Button();
            this.buttonPcurrent = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvcategories = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategories)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelpos);
            this.groupBox1.Controls.Add(this.buttonLast);
            this.groupBox1.Controls.Add(this.buttonNext);
            this.groupBox1.Controls.Add(this.buttonPrevious);
            this.groupBox1.Controls.Add(this.buttonFirst);
            this.groupBox1.Controls.Add(this.textname);
            this.groupBox1.Controls.Add(this.textid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الصنف";
            // 
            // labelpos
            // 
            this.labelpos.AutoSize = true;
            this.labelpos.Location = new System.Drawing.Point(546, 109);
            this.labelpos.Name = "labelpos";
            this.labelpos.Size = new System.Drawing.Size(35, 13);
            this.labelpos.TabIndex = 8;
            this.labelpos.Text = "label3";
            this.labelpos.Click += new System.EventHandler(this.labelpos_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(384, 109);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 7;
            this.buttonLast.Text = "الاخير";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(465, 109);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "التالى";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(587, 109);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 5;
            this.buttonPrevious.Text = "السابق";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(668, 109);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 4;
            this.buttonFirst.Text = "الاول";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(465, 70);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(176, 20);
            this.textname.TabIndex = 3;
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(546, 28);
            this.textid.Name = "textid";
            this.textid.ReadOnly = true;
            this.textid.Size = new System.Drawing.Size(95, 20);
            this.textid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم الصنف";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "معرف الصنف";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.buttonPall);
            this.groupBox2.Controls.Add(this.buttonPDFcurrent);
            this.groupBox2.Controls.Add(this.buttonPDFall);
            this.groupBox2.Controls.Add(this.buttonPcurrent);
            this.groupBox2.Controls.Add(this.buttonRemove);
            this.groupBox2.Controls.Add(this.buttonModify);
            this.groupBox2.Controls.Add(this.buttonClear);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحه";
            // 
            // buttonPall
            // 
            this.buttonPall.Location = new System.Drawing.Point(192, 53);
            this.buttonPall.Name = "buttonPall";
            this.buttonPall.Size = new System.Drawing.Size(173, 23);
            this.buttonPall.TabIndex = 4;
            this.buttonPall.Text = "طباعة كل الاصناف";
            this.buttonPall.UseVisualStyleBackColor = true;
            this.buttonPall.Click += new System.EventHandler(this.buttonPall_Click);
            // 
            // buttonPDFcurrent
            // 
            this.buttonPDFcurrent.Location = new System.Drawing.Point(6, 80);
            this.buttonPDFcurrent.Name = "buttonPDFcurrent";
            this.buttonPDFcurrent.Size = new System.Drawing.Size(180, 23);
            this.buttonPDFcurrent.TabIndex = 7;
            this.buttonPDFcurrent.Text = "تخزين الصنف الحالى PDF";
            this.buttonPDFcurrent.UseVisualStyleBackColor = true;
            this.buttonPDFcurrent.Click += new System.EventHandler(this.buttonPDFcurrent_Click);
            // 
            // buttonPDFall
            // 
            this.buttonPDFall.Location = new System.Drawing.Point(192, 82);
            this.buttonPDFall.Name = "buttonPDFall";
            this.buttonPDFall.Size = new System.Drawing.Size(173, 23);
            this.buttonPDFall.TabIndex = 6;
            this.buttonPDFall.Text = "تخزين الاصناف PDF";
            this.buttonPDFall.UseVisualStyleBackColor = true;
            this.buttonPDFall.Click += new System.EventHandler(this.buttonPDFall_Click);
            // 
            // buttonPcurrent
            // 
            this.buttonPcurrent.Location = new System.Drawing.Point(6, 53);
            this.buttonPcurrent.Name = "buttonPcurrent";
            this.buttonPcurrent.Size = new System.Drawing.Size(180, 23);
            this.buttonPcurrent.TabIndex = 5;
            this.buttonPcurrent.Text = "طباعة الصنف الحالى";
            this.buttonPcurrent.UseVisualStyleBackColor = true;
            this.buttonPcurrent.Click += new System.EventHandler(this.buttonPcurrent_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(6, 26);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(78, 23);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "حذف";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(97, 26);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(89, 23);
            this.buttonModify.TabIndex = 3;
            this.buttonModify.Text = "تعديل";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(287, 26);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(78, 23);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "جديد";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(192, 26);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(89, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "إضافه";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvcategories);
            this.groupBox3.Location = new System.Drawing.Point(12, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(754, 211);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لائحه المنتجات";
            // 
            // dgvcategories
            // 
            this.dgvcategories.AllowUserToAddRows = false;
            this.dgvcategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategories.Location = new System.Drawing.Point(6, 19);
            this.dgvcategories.Name = "dgvcategories";
            this.dgvcategories.Size = new System.Drawing.Size(742, 186);
            this.dgvcategories.TabIndex = 0;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 385);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Categories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الاصناف";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label labelpos;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvcategories;
        private System.Windows.Forms.Button buttonPDFcurrent;
        private System.Windows.Forms.Button buttonPDFall;
        private System.Windows.Forms.Button buttonPcurrent;
        private System.Windows.Forms.Button buttonPall;
    }
}