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
            this.lbResualt = new System.Windows.Forms.ListBox();
            this.gbRemote.SuspendLayout();
            this.gbLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRemote
            // 
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
            this.lbRemote.Size = new System.Drawing.Size(295, 388);
            this.lbRemote.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 35);
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
            this.lbLocal.Size = new System.Drawing.Size(295, 388);
            this.lbLocal.TabIndex = 9;
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
            this.label1.Location = new System.Drawing.Point(799, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "پیش نمایش نگاشت فیلدها";
            // 
            // lbResualt
            // 
            this.lbResualt.FormattingEnabled = true;
            this.lbResualt.ItemHeight = 16;
            this.lbResualt.Location = new System.Drawing.Point(680, 49);
            this.lbResualt.Name = "lbResualt";
            this.lbResualt.Size = new System.Drawing.Size(368, 484);
            this.lbResualt.TabIndex = 4;
            // 
            // DataSchemeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 558);
            this.Controls.Add(this.lbResualt);
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
        private System.Windows.Forms.ListBox lbResualt;
    }
}