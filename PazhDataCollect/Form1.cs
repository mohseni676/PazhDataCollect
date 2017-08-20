﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace PazhDataCollect
{
    public partial class mainFrm : Form
    {
        Utility UT = new Utility();
        SqlConnectionStringBuilder RemoteCN = new SqlConnectionStringBuilder();
        SqlConnectionStringBuilder LocalCN = new SqlConnectionStringBuilder();
        public mainFrm()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (UT.CheckServerAvailablity(txtRserver.Text.Trim())==true)
                {
                    //MessageBox.Show("ارتباط با سرور بر قرار است.");
                    cbDBList.Items.Clear();
                    List<string> DBs = new List<string>();
                    DBs = UT.FN_GetDBList(txtRserver.Text.Trim(),  txtDBUser.Text.Trim(), txtDBPassword.Text);
                    cbDBList.Items.AddRange(DBs.ToArray());
                    MessageBox.Show("بانک اطلاعاتی مد نظر را از لیست انتخاب نمایید.");
                    panel3.Enabled = true;
                    panel2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("خطا: ارتباط با سرور بر قرار نمی باشد، آدرس و پورت را بررسی کنید.");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("خطا: " + er.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder cn = new SqlConnectionStringBuilder();
            cn.DataSource = txtRserver.Text.Trim();
            cn.UserID = txtDBUser.Text.Trim();
            cn.Password = txtDBPassword.Text;
            cn.InitialCatalog = cbDBList.Text.Trim();
            
            Properties.Settings.Default.Connection1 = cn.ConnectionString.ToString();
            Properties.Settings.Default.Save();
            MessageBox.Show("تنظیمات مربوط به سرور راه دور ذخیره شد.");
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Connection1 != "")
            {
                RemoteCN.ConnectionString = Properties.Settings.Default.Connection1;
                txtRserver.Text = RemoteCN.DataSource.ToString();
                txtDBUser.Text = RemoteCN.UserID.ToString();
                txtDBPassword.Text = RemoteCN.Password.ToString();
                cbDBList.Text = RemoteCN.InitialCatalog.ToString();
            }
            if (Properties.Settings.Default.Connection2 != "")
            {
                LocalCN.ConnectionString = Properties.Settings.Default.Connection2;
                txtLServer.Text = LocalCN.DataSource.ToString();
                txtLDBUser.Text = LocalCN.UserID.ToString();
                txtLPassword.Text = LocalCN.Password.ToString();
                cbLDBname.Text = LocalCN.InitialCatalog.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (UT.CheckServerAvailablity(txtLServer.Text.Trim()) == true)
                {
                    //MessageBox.Show("ارتباط با سرور بر قرار است.");
                    cbLDBname.Items.Clear();
                    List<string> DBs = new List<string>();
                    DBs = UT.FN_GetDBList(txtLServer.Text.Trim(), txtLDBUser.Text.Trim(), txtLPassword.Text);
                    cbLDBname.Items.AddRange(DBs.ToArray());
                    MessageBox.Show("بانک اطلاعاتی مد نظر را از لیست انتخاب نمایید.");
                    panel4.Enabled = true;
                    panel5.Enabled = false;
                }
                else
                {
                    MessageBox.Show("خطا: ارتباط با سرور بر قرار نمی باشد، آدرس و پورت را بررسی کنید.");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("خطا: " + er.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder cn = new SqlConnectionStringBuilder();
            cn.DataSource = txtLServer.Text.Trim();
            cn.UserID = txtLDBUser.Text.Trim();
            cn.Password = txtLPassword.Text;
            cn.InitialCatalog = cbLDBname.Text.Trim();

            Properties.Settings.Default.Connection2 = cn.ConnectionString.ToString();
            Properties.Settings.Default.Save();
            MessageBox.Show("تنظیمات مربوط به سرور فروشگاه ذخیره شد.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataSchemeFrm Dform = new DataSchemeFrm();
            Dform.ShowDialog();
        }
    }


}
