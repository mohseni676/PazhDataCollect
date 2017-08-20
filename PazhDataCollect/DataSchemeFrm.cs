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
    }
}
