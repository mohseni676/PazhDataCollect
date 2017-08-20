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
            PersianCalendar calendar = new PersianCalendar();
            DateTime date = DateTime.Now.AddDays(Convert.ToDouble(maskedTextBox1.Text)*-1);
            string txt="";
            txt +="INSERT INTO [" + cbRemote.Text+"]";
            txt += "(";
            int i=0;
            foreach(string item in lbRemoteAdded.Items)
            {
                
                if (i < lbRemoteAdded.Items.Count-1)
                    txt += item + ",";
                else
                    txt += item+") ";

                i++;
            }
            txt += "SELECT (";
            int j = 0;
            foreach (string item in lbLocalAdded.Items)
            {

                if (j < lbLocalAdded.Items.Count - 1)
                    txt += item + ",";
                else
                    txt += item + ") FROM [";

                j++;
            }
            txt += cbLocal.Text + "] WHERE ";
           
            txt += cbSelectedDateField.Text + "< '" + calendar.GetYear(date)+"/"+calendar.GetMonth(date).ToString().PadLeft(2,'0')+"/"+calendar.GetDayOfMonth(date).ToString().PadLeft(2, '0') + "'";
            txtResualt.Text=txt;
        }

        private void cbSelectedDateField_MouseClick(object sender, MouseEventArgs e)
        {
            cbSelectedDateField.Items.Clear();
            foreach (string item in lbLocalAdded.Items)
            {
                cbSelectedDateField.Items.Add(item);
            }
        }
    }
}
