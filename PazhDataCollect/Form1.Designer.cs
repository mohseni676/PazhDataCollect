namespace PazhDataCollect
{
    partial class mainFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDBUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDBPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtRserver = new System.Windows.Forms.TextBox();
            this.lbl_RServer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDBList = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbLDBname = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLDBUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtLServer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 594);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Location = new System.Drawing.Point(3, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات سرور فروشگاه";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1022, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مشخصات سرور راه دور";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDBUser);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDBPassword);
            this.panel2.Controls.Add(this.txtRserver);
            this.panel2.Controls.Add(this.lbl_RServer);
            this.panel2.Location = new System.Drawing.Point(518, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 100);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "رمز عبور";
            // 
            // txtDBUser
            // 
            this.txtDBUser.Location = new System.Drawing.Point(187, 23);
            this.txtDBUser.Name = "txtDBUser";
            this.txtDBUser.Size = new System.Drawing.Size(109, 23);
            this.txtDBUser.TabIndex = 14;
            this.txtDBUser.Text = "sa";
            this.txtDBUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "نام کاربری";
            // 
            // txtDBPassword
            // 
            this.txtDBPassword.Location = new System.Drawing.Point(81, 23);
            this.txtDBPassword.Name = "txtDBPassword";
            this.txtDBPassword.PasswordChar = '*';
            this.txtDBPassword.Size = new System.Drawing.Size(100, 23);
            this.txtDBPassword.TabIndex = 12;
            this.txtDBPassword.Text = "lemon7430";
            this.txtDBPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRserver
            // 
            this.txtRserver.Location = new System.Drawing.Point(302, 23);
            this.txtRserver.Name = "txtRserver";
            this.txtRserver.Size = new System.Drawing.Size(180, 23);
            this.txtRserver.TabIndex = 9;
            this.txtRserver.Text = "2.180.2.45";
            this.txtRserver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_RServer
            // 
            this.lbl_RServer.AutoSize = true;
            this.lbl_RServer.Location = new System.Drawing.Point(353, 4);
            this.lbl_RServer.Name = "lbl_RServer";
            this.lbl_RServer.Size = new System.Drawing.Size(70, 16);
            this.lbl_RServer.TabIndex = 8;
            this.lbl_RServer.Text = "آدرس سرور";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "تست ارتباط و ادامه>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbDBList);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(0, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 100);
            this.panel3.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 39);
            this.button2.TabIndex = 16;
            this.button2.Text = "ذخیره سازی اطلاعات";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "لیست بانک های اطلاعاتی";
            // 
            // cbDBList
            // 
            this.cbDBList.FormattingEnabled = true;
            this.cbDBList.Location = new System.Drawing.Point(136, 23);
            this.cbDBList.Name = "cbDBList";
            this.cbDBList.Size = new System.Drawing.Size(195, 24);
            this.cbDBList.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbLDBname);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(4, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 100);
            this.panel4.TabIndex = 3;
            // 
            // cbLDBname
            // 
            this.cbLDBname.FormattingEnabled = true;
            this.cbLDBname.Location = new System.Drawing.Point(136, 23);
            this.cbLDBname.Name = "cbLDBname";
            this.cbLDBname.Size = new System.Drawing.Size(195, 24);
            this.cbLDBname.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 39);
            this.button3.TabIndex = 16;
            this.button3.Text = "ذخیره سازی اطلاعات";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "لیست بانک های اطلاعاتی";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtLDBUser);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtLPassword);
            this.panel5.Controls.Add(this.txtLServer);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(522, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(498, 100);
            this.panel5.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(152, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 39);
            this.button4.TabIndex = 16;
            this.button4.Text = "تست ارتباط و ادامه>>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "رمز عبور";
            // 
            // txtLDBUser
            // 
            this.txtLDBUser.Location = new System.Drawing.Point(187, 23);
            this.txtLDBUser.Name = "txtLDBUser";
            this.txtLDBUser.Size = new System.Drawing.Size(109, 23);
            this.txtLDBUser.TabIndex = 14;
            this.txtLDBUser.Text = "sa";
            this.txtLDBUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "نام کاربری";
            // 
            // txtLPassword
            // 
            this.txtLPassword.Location = new System.Drawing.Point(81, 23);
            this.txtLPassword.Name = "txtLPassword";
            this.txtLPassword.PasswordChar = '*';
            this.txtLPassword.Size = new System.Drawing.Size(100, 23);
            this.txtLPassword.TabIndex = 12;
            this.txtLPassword.Text = "lemon7430";
            this.txtLPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLServer
            // 
            this.txtLServer.Location = new System.Drawing.Point(302, 23);
            this.txtLServer.Name = "txtLServer";
            this.txtLServer.Size = new System.Drawing.Size(180, 23);
            this.txtLServer.TabIndex = 9;
            this.txtLServer.Text = "2.180.2.45";
            this.txtLServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "آدرس سرور";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(836, 277);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 39);
            this.button5.TabIndex = 18;
            this.button5.Text = "تطبیق فیلدها";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 594);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "برنامه برداشت اطلاعات پاژ";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDBUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDBPassword;
        private System.Windows.Forms.TextBox txtRserver;
        private System.Windows.Forms.Label lbl_RServer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDBList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbLDBname;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLDBUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtLPassword;
        private System.Windows.Forms.TextBox txtLServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
    }
}

