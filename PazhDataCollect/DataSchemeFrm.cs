using System;
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
using System.Linq;
using System.Globalization;
namespace PazhDataCollect
{
    public partial class DataSchemeFrm : Form
    {
        SqlConnection RemoteCN = new SqlConnection();
        SqlConnection LocalCN = new SqlConnection();
        Utility UT = new Utility();
        public DataSchemeFrm()
        {
            InitializeComponent();
        }

        private void DataSchemeFrm_Load(object sender, EventArgs e)
        {
            RemoteCN.ConnectionString = Properties.Settings.Default.Connection1;
            LocalCN.ConnectionString = Properties.Settings.Default.Connection2;
            cbRemote.Items.AddRange(UT.FN_GetDBTableList(RemoteCN).ToArray());
            cbLocal.Items.AddRange(UT.FN_GetDBTableList(LocalCN).ToArray());
            txtLocalSQL.Text = Properties.Settings.Default.LocalSQL;
            txtRemoteSQL.Text = Properties.Settings.Default.RemoteSQL;
            comboBox1.Text = Properties.Settings.Default.DateField;
            if (Properties.Settings.Default.ShamsiDate == false)
                chbDate.Checked = true;
            if (Properties.Settings.Default.Digitz8 == true)
                chbFormatDate.Checked = true;
            maskedTextBox1.Text = Properties.Settings.Default.DaysBefore.ToString();
        }

        private void BtnRemote_Click(object sender, EventArgs e)
        {
            RemoteCN.ConnectionString = Properties.Settings.Default.Connection1;
           
            //MessageBox.Show("select COLUMN_NAME,TABLE_NAME from INFORMATION_SCHEMA.COLUMNS where  TABLE_NAME=\"" + "TEST" + "\"");
            if (cbRemote.Text != "" && RemoteCN.ConnectionString !="")
            {
                lbRemote.Items.Clear();
                lbRemote.Items.AddRange(UT.FN_GetTbColumnList(RemoteCN, cbRemote.Text).ToArray());
            }
            else
            {
                MessageBox.Show("لطفا یک جدول را انتخاب نمایید.");
            }
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            LocalCN.ConnectionString = Properties.Settings.Default.Connection2;
            if (cbLocal.Text != "" && LocalCN.ConnectionString != "")
            {
                lbLocal.Items.Clear();
                lbLocal.Items.AddRange(UT.FN_GetTbColumnList(LocalCN, cbLocal.Text).ToArray());
            }
            else
            {
                MessageBox.Show("لطفا یک جدول را انتخاب نمایید.");
            }
        }

        private void lbRemote_Click(object sender, EventArgs e)
        {
            
        }

        private void lbRemote_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbRemote_DoubleClick(object sender, EventArgs e)
        {
          //  txtResualt.Text += lbRemote.SelectedItem.ToString() + " = ";
            lbRemoteAdded.Items.Add(lbRemote.SelectedItem);
            lbRemote.Items.Remove(lbRemote.SelectedItem);
            
            
        }

        private void lbLocal_DoubleClick(object sender, EventArgs e)
        {
           // txtResualt.Text += lbLocal.SelectedItem.ToString() + " , ";
            lbLocalAdded.Items.Add(lbLocal.SelectedItem);
            lbLocal.Items.Remove(lbLocal.SelectedItem);
        }

        private void lbRemoteAdded_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbRemoteAdded_DoubleClick(object sender, EventArgs e)
        {
            lbRemote.Items.Add(lbRemoteAdded.SelectedItem);
            lbRemoteAdded.Items.Remove(lbRemoteAdded.SelectedItem);

        }

        private void lbLocalAdded_DoubleClick(object sender, EventArgs e)
        {
            lbLocal.Items.Add(lbLocalAdded.SelectedItem);
            lbLocalAdded.Items.Remove(lbLocalAdded.SelectedItem);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbLocalAdded.Items.Count != lbRemoteAdded.Items.Count)
                MessageBox.Show("تعداد فیلدهای انتخابی در جدول محلی و جدول راه دور باید یکسان باشد");
            else
            {
                string txt = "";
                txt += "SELECT ";
                //int i = lbRemote.Items.Count;
                for (int i = 0; i < lbRemoteAdded.Items.Count; i++)
                {
                    if(i< lbRemoteAdded.Items.Count-1)
                    txt += lbLocalAdded.Items[i] + " AS '" + lbRemoteAdded.Items[i] + "' , ";
                    else
                    txt += lbLocalAdded.Items[i] + " AS '" + lbRemoteAdded.Items[i] + "' From ";


                }
                txt += cbLocal.Text;
                txtLocalSQL.Text = txt;

                txt = "";
                txt += "SELECT ";
                //int i = lbRemote.Items.Count;
                for (int i = 0; i < lbRemoteAdded.Items.Count; i++)
                {
                    if (i < lbRemoteAdded.Items.Count - 1)
                        txt += lbRemoteAdded.Items[i] +" , ";
                    else
                        txt += lbRemoteAdded.Items[i] + " From ";


                }
                txt += cbRemote.Text;
                txtRemoteSQL.Text = txt;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LocalSQL = txtLocalSQL.Text;
            Properties.Settings.Default.RemoteSQL = txtRemoteSQL.Text;
            Properties.Settings.Default.DateField = comboBox1.Text;
            if (chbDate.Checked)
                Properties.Settings.Default.ShamsiDate = false;
            if (chbFormatDate.Checked)
                Properties.Settings.Default.Digitz8 = true;
            Properties.Settings.Default.DaysBefore =Convert.ToInt32( maskedTextBox1.Text);
            Properties.Settings.Default.Save();
            MessageBox.Show("تنظیمات ذخیره شد.");
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            foreach(string item in lbRemoteAdded.Items)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            LocalCN.ConnectionString = Properties.Settings.Default.Connection2;
            using (LocalCN)
            {
                using (SqlDataAdapter a = new SqlDataAdapter(
                                   "SELECT TOP 100 * FROM " + cbLocal.Text, LocalCN))
                {
                    
                    DataTable t = new DataTable();
                    a.Fill(t);
                    
                    dgSQLView.DataSource = t;
                }
            }
        }
    }
}
