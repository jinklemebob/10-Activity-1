namespace Activity10
{
    partial class Form1
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
            this.idbox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comparebtn = new System.Windows.Forms.Button();
            this.createaccbtn = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.RadioButton();
            this.User = new System.Windows.Forms.RadioButton();
            this.namebox = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.passcomp = new System.Windows.Forms.TextBox();
            this.idcomp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adminname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(217, 53);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(100, 20);
            this.idbox.TabIndex = 0;
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(217, 92);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(100, 20);
            this.passwordbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Password";
            // 
            // comparebtn
            // 
            this.comparebtn.Location = new System.Drawing.Point(23, 151);
            this.comparebtn.Name = "comparebtn";
            this.comparebtn.Size = new System.Drawing.Size(75, 26);
            this.comparebtn.TabIndex = 5;
            this.comparebtn.Text = "Compare";
            this.comparebtn.UseVisualStyleBackColor = true;
            this.comparebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // createaccbtn
            // 
            this.createaccbtn.Location = new System.Drawing.Point(229, 163);
            this.createaccbtn.Name = "createaccbtn";
            this.createaccbtn.Size = new System.Drawing.Size(75, 24);
            this.createaccbtn.TabIndex = 6;
            this.createaccbtn.Text = "Create ";
            this.createaccbtn.UseVisualStyleBackColor = true;
            this.createaccbtn.Click += new System.EventHandler(this.createaccbtn_Click);
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Location = new System.Drawing.Point(143, 81);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(53, 17);
            this.Admin.TabIndex = 7;
            this.Admin.TabStop = true;
            this.Admin.Text = "admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.CheckedChanged += new System.EventHandler(this.Admin_CheckedChanged);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(143, 104);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(45, 17);
            this.User.TabIndex = 8;
            this.User.TabStop = true;
            this.User.Text = "user";
            this.User.UseVisualStyleBackColor = true;
            this.User.CheckedChanged += new System.EventHandler(this.User_CheckedChanged);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(217, 137);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 20);
            this.namebox.TabIndex = 9;
            this.namebox.Visible = false;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(237, 121);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 10;
            this.Username.Text = "Username";
            this.Username.Visible = false;
            // 
            // passcomp
            // 
            this.passcomp.Location = new System.Drawing.Point(12, 97);
            this.passcomp.Name = "passcomp";
            this.passcomp.Size = new System.Drawing.Size(100, 20);
            this.passcomp.TabIndex = 11;
            // 
            // idcomp
            // 
            this.idcomp.Location = new System.Drawing.Point(12, 53);
            this.idcomp.Name = "idcomp";
            this.idcomp.Size = new System.Drawing.Size(100, 20);
            this.idcomp.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(39, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "User ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Comparison";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Create/Update name";
            // 
            // adminname
            // 
            this.adminname.AutoSize = true;
            this.adminname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminname.Location = new System.Drawing.Point(38, 128);
            this.adminname.Name = "adminname";
            this.adminname.Size = new System.Drawing.Size(44, 16);
            this.adminname.TabIndex = 17;
            this.adminname.Text = "Name";
            this.adminname.Visible = false;
            this.adminname.Click += new System.EventHandler(this.adminname_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(358, 202);
            this.Controls.Add(this.adminname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idcomp);
            this.Controls.Add(this.passcomp);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.createaccbtn);
            this.Controls.Add(this.comparebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.idbox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "10 Activity 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button comparebtn;
        private System.Windows.Forms.Button createaccbtn;
        private System.Windows.Forms.RadioButton Admin;
        private System.Windows.Forms.RadioButton User;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox passcomp;
        private System.Windows.Forms.TextBox idcomp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label adminname;
    }
}

