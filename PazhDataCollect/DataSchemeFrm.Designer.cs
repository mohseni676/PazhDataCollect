namespace PazhDataCollect
{
    partial class DataSchemeFrm
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
            this.gbRemote = new System.Windows.Forms.GroupBox();
            this.lbRemote = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRemote = new System.Windows.Forms.Button();
            this.cbRemote = new System.Windows.Forms.ComboBox();
            this.gbLocal = new System.Windows.Forms.GroupBox();
            this.lbLocal = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLocal = new System.Windows.Forms.Button();
            this.cbLocal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResualt = new System.Windows.Forms.TextBox();
            this.lbRemoteAdded = new System.Windows.Forms.ListBox();
            this.lbLocalAdded = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSelectedDateField = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.gbRemote.SuspendLayout();
            this.gbLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRemote
            // 
            this.gbRemote.Controls.Add(this.lbRemoteAdded);
            this.gbRemote.Controls.Add(this.lbRemote);
            this.gbRemote.Controls.Add(this.label2);
            this.gbRemote.Controls.Add(this.BtnRemote);
            this.gbRemote.Controls.Add(this.cbRemote);
            this.gbRemote.Location = new System.Drawing.Point(346, 17);
            this.gbRemote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbRemote.Name = "gbRemote";
            this.gbRemote.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbRemote.Size = new System.Drawing.Size(328, 513);
            this.gbRemote.TabIndex = 0;
            this.gbRemote.TabStop = false;
            this.gbRemote.Text = "سرور ریموت(مادر)";
            // 
            // lbRemote
            // 
            this.lbRemote.FormattingEnabled = true;
            this.lbRemote.ItemHeight = 16;
            this.lbRemote.Location = new System.Drawing.Point(17, 103);
            this.lbRemote.Name = "lbRemote";
            this.lbRemote.Size = new System.Drawing.Size(295, 196);
            this.lbRemote.TabIndex = 5;
            this.lbRemote.Click += new System.EventHandler(this.lbRemote_Click);
            this.lbRemote.SelectedIndexChanged += new System.EventHandler(this.lbRemote_SelectedIndexChanged);
            this.lbRemote.DoubleClick += new System.EventHandler(this.lbRemote_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "لیست جداول";
            // 
            // BtnRemote
            // 
            this.BtnRemote.Location = new System.Drawing.Point(17, 63);
            this.BtnRemote.Name = "BtnRemote";
            this.BtnRemote.Size = new System.Drawing.Size(222, 34);
            this.BtnRemote.TabIndex = 1;
            this.BtnRemote.Text = "دریافت لیست فیلدها";
            this.BtnRemote.UseVisualStyleBackColor = true;
            this.BtnRemote.Click += new System.EventHandler(this.BtnRemote_Click);
            // 
            // cbRemote
            // 
            this.cbRemote.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbRemote.FormattingEnabled = true;
            this.cbRemote.Location = new System.Drawing.Point(17, 32);
            this.cbRemote.Name = "cbRemote";
            this.cbRemote.Size = new System.Drawing.Size(222, 21);
            this.cbRemote.TabIndex = 0;
            // 
            // gbLocal
            // 
            this.gbLocal.Controls.Add(this.lbLocalAdded);
            this.gbLocal.Controls.Add(this.lbLocal);
            this.gbLocal.Controls.Add(this.label3);
            this.gbLocal.Controls.Add(this.btnLocal);
            this.gbLocal.Controls.Add(this.cbLocal);
            this.gbLocal.Location = new System.Drawing.Point(12, 17);
            this.gbLocal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbLocal.Name = "gbLocal";
            this.gbLocal.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbLocal.Size = new System.Drawing.Size(328, 513);
            this.gbLocal.TabIndex = 1;
            this.gbLocal.TabStop = false;
            this.gbLocal.Text = "سرور محلی(فرزند)";
            // 
            // lbLocal
            // 
            this.lbLocal.FormattingEnabled = true;
            this.lbLocal.ItemHeight = 16;
            this.lbLocal.Location = new System.Drawing.Point(6, 103);
            this.lbLocal.Name = "lbLocal";
            this.lbLocal.Size = new System.Drawing.Size(295, 196);
            this.lbLocal.TabIndex = 9;
            this.lbLocal.DoubleClick += new System.EventHandler(this.lbLocal_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "لیست جداول";
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(6, 63);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(222, 34);
            this.btnLocal.TabIndex = 7;
            this.btnLocal.Text = "دریافت لیست فیلدها";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // cbLocal
            // 
            this.cbLocal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbLocal.FormattingEnabled = true;
            this.cbLocal.Location = new System.Drawing.Point(6, 32);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(222, 21);
            this.cbLocal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(780, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "پیش نمایش نگاشت فیلدها SQL";
            // 
            // txtResualt
            // 
            this.txtResualt.Location = new System.Drawing.Point(680, 193);
            this.txtResualt.Multiline = true;
            this.txtResualt.Name = "txtResualt";
            this.txtResualt.Size = new System.Drawing.Size(368, 111);
            this.txtResualt.TabIndex = 4;
            this.txtResualt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbRemoteAdded
            // 
            this.lbRemoteAdded.FormattingEnabled = true;
            this.lbRemoteAdded.ItemHeight = 16;
            this.lbRemoteAdded.Location = new System.Drawing.Point(17, 305);
            this.lbRemoteAdded.Name = "lbRemoteAdded";
            this.lbRemoteAdded.Size = new System.Drawing.Size(295, 196);
            this.lbRemoteAdded.TabIndex = 6;
            this.lbRemoteAdded.SelectedIndexChanged += new System.EventHandler(this.lbRemoteAdded_SelectedIndexChanged);
            this.lbRemoteAdded.DoubleClick += new System.EventHandler(this.lbRemoteAdded_DoubleClick);
            // 
            // lbLocalAdded
            // 
            this.lbLocalAdded.FormattingEnabled = true;
            this.lbLocalAdded.ItemHeight = 16;
            this.lbLocalAdded.Location = new System.Drawing.Point(6, 305);
            this.lbLocalAdded.Name = "lbLocalAdded";
            this.lbLocalAdded.Size = new System.Drawing.Size(295, 196);
            this.lbLocalAdded.TabIndex = 10;
            this.lbLocalAdded.DoubleClick += new System.EventHandler(this.lbLocalAdded_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(752, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "<تبدیل به دستور SQL ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(951, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "تعداد روز برداشت";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(881, 14);
            this.maskedTextBox1.Mask = "000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(64, 23);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(951, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "فیلد تاریخ";
            // 
            // cbSelectedDateField
            // 
            this.cbSelectedDateField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbSelectedDateField.FormattingEnabled = true;
            this.cbSelectedDateField.Location = new System.Drawing.Point(780, 49);
            this.cbSelectedDateField.Name = "cbSelectedDateField";
            this.cbSelectedDateField.Size = new System.Drawing.Size(165, 21);
            this.cbSelectedDateField.TabIndex = 11;
            this.cbSelectedDateField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbSelectedDateField_MouseClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(913, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "تاریخ میلادی";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(913, 106);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox2.Size = new System.Drawing.Size(102, 20);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "سال دو رقمی";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // DataSchemeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 568);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbSelectedDateField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResualt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbLocal);
            this.Controls.Add(this.gbRemote);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DataSchemeFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "DataSchemeFrm";
            this.Load += new System.EventHandler(this.DataSchemeFrm_Load);
            this.gbRemote.ResumeLayout(false);
            this.gbRemote.PerformLayout();
            this.gbLocal.ResumeLayout(false);
            this.gbLocal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRemote;
        private System.Windows.Forms.ListBox lbRemote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRemote;
        private System.Windows.Forms.ComboBox cbRemote;
        private System.Windows.Forms.GroupBox gbLocal;
        private System.Windows.Forms.ListBox lbLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.ComboBox cbLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResualt;
        private System.Windows.Forms.ListBox lbRemoteAdded;
        private System.Windows.Forms.ListBox lbLocalAdded;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSelectedDateField;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}