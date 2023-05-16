namespace Banking_System
{
    partial class AddAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccounts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AcNameTb = new System.Windows.Forms.TextBox();
            this.AcPhoneTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AcAddressTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GenCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EducationCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.OccupationTb = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.IncomeTb = new System.Windows.Forms.TextBox();
            this.AccountDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 600);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(390, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Account Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(945, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Moccasin;
            this.label4.Location = new System.Drawing.Point(103, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // AcNameTb
            // 
            this.AcNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcNameTb.Location = new System.Drawing.Point(108, 146);
            this.AcNameTb.Name = "AcNameTb";
            this.AcNameTb.Size = new System.Drawing.Size(183, 31);
            this.AcNameTb.TabIndex = 10;
            // 
            // AcPhoneTb
            // 
            this.AcPhoneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcPhoneTb.Location = new System.Drawing.Point(336, 146);
            this.AcPhoneTb.Name = "AcPhoneTb";
            this.AcPhoneTb.Size = new System.Drawing.Size(183, 31);
            this.AcPhoneTb.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Moccasin;
            this.label3.Location = new System.Drawing.Point(331, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phone";
            // 
            // AcAddressTb
            // 
            this.AcAddressTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcAddressTb.Location = new System.Drawing.Point(558, 146);
            this.AcAddressTb.Multiline = true;
            this.AcAddressTb.Name = "AcAddressTb";
            this.AcAddressTb.Size = new System.Drawing.Size(183, 108);
            this.AcAddressTb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Moccasin;
            this.label5.Location = new System.Drawing.Point(553, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Moccasin;
            this.label6.Location = new System.Drawing.Point(331, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gender";
            // 
            // GenCb
            // 
            this.GenCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenCb.FormattingEnabled = true;
            this.GenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenCb.Location = new System.Drawing.Point(336, 222);
            this.GenCb.Name = "GenCb";
            this.GenCb.Size = new System.Drawing.Size(183, 32);
            this.GenCb.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Moccasin;
            this.label7.Location = new System.Drawing.Point(777, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Occupation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Moccasin;
            this.label8.Location = new System.Drawing.Point(103, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "Education";
            // 
            // EducationCb
            // 
            this.EducationCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EducationCb.FormattingEnabled = true;
            this.EducationCb.Items.AddRange(new object[] {
            "Uneducated",
            "Diploma"});
            this.EducationCb.Location = new System.Drawing.Point(108, 222);
            this.EducationCb.Name = "EducationCb";
            this.EducationCb.Size = new System.Drawing.Size(183, 32);
            this.EducationCb.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Moccasin;
            this.label9.Location = new System.Drawing.Point(777, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 26);
            this.label9.TabIndex = 11;
            this.label9.Text = "Income";
            // 
            // OccupationTb
            // 
            this.OccupationTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OccupationTb.Location = new System.Drawing.Point(782, 146);
            this.OccupationTb.Name = "OccupationTb";
            this.OccupationTb.Size = new System.Drawing.Size(183, 31);
            this.OccupationTb.TabIndex = 10;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.Moccasin;
            this.SubmitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitBtn.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(250, 306);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(176, 41);
            this.SubmitBtn.TabIndex = 13;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.BackColor = System.Drawing.Color.Moccasin;
            this.Editbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Editbtn.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbtn.Location = new System.Drawing.Point(455, 306);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(176, 41);
            this.Editbtn.TabIndex = 13;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = false;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Moccasin;
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBtn.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(660, 306);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(176, 41);
            this.CancelBtn.TabIndex = 13;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // IncomeTb
            // 
            this.IncomeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeTb.Location = new System.Drawing.Point(782, 223);
            this.IncomeTb.Name = "IncomeTb";
            this.IncomeTb.Size = new System.Drawing.Size(183, 31);
            this.IncomeTb.TabIndex = 10;
            // 
            // AccountDGV
            // 
            this.AccountDGV.AllowUserToAddRows = false;
            this.AccountDGV.AllowUserToDeleteRows = false;
            this.AccountDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountDGV.Location = new System.Drawing.Point(64, 375);
            this.AccountDGV.Name = "AccountDGV";
            this.AccountDGV.ReadOnly = true;
            this.AccountDGV.Size = new System.Drawing.Size(931, 213);
            this.AccountDGV.TabIndex = 14;
            this.AccountDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(997, 600);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AccountDGV);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.EducationCb);
            this.Controls.Add(this.GenCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AcAddressTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IncomeTb);
            this.Controls.Add(this.OccupationTb);
            this.Controls.Add(this.AcPhoneTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AcNameTb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAccounts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AcNameTb;
        private System.Windows.Forms.TextBox AcPhoneTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AcAddressTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox GenCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox EducationCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox OccupationTb;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox IncomeTb;
        private System.Windows.Forms.DataGridView AccountDGV;
    }
}