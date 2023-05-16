namespace Banking_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UnameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RoleCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 446);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(241, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank Management System";
            // 
            // UnameTb
            // 
            this.UnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnameTb.Location = new System.Drawing.Point(247, 212);
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.Size = new System.Drawing.Size(317, 31);
            this.UnameTb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Moccasin;
            this.label2.Location = new System.Drawing.Point(242, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Moccasin;
            this.label3.Location = new System.Drawing.Point(242, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // PasswordTb
            // 
            this.PasswordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.Location = new System.Drawing.Point(247, 279);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.Size = new System.Drawing.Size(317, 31);
            this.PasswordTb.TabIndex = 4;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Moccasin;
            this.LoginBtn.Font = new System.Drawing.Font("Myriad Pro Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(307, 361);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(216, 41);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(618, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RoleCb
            // 
            this.RoleCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleCb.FormattingEnabled = true;
            this.RoleCb.Items.AddRange(new object[] {
            "Admin",
            "Agent"});
            this.RoleCb.Location = new System.Drawing.Point(247, 145);
            this.RoleCb.Name = "RoleCb";
            this.RoleCb.Size = new System.Drawing.Size(317, 32);
            this.RoleCb.TabIndex = 13;
            this.RoleCb.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Moccasin;
            this.label4.Location = new System.Drawing.Point(383, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Reset";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(670, 446);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RoleCb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UnameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UnameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox RoleCb;
        private System.Windows.Forms.Label label4;
    }
}