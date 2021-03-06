﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System.Globalization;



namespace PazhDataCollect
{
    class Utility
    {
        public List<string> FN_GetDBList(string ServerAddress,string DBUser,string DBPassword)
        {
            List<String> databases = new List<String>();

            SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
            
            connection.DataSource = ServerAddress;
            
            
            // enter credentials if you want
            connection.UserID = DBUser;
            connection.Password = DBPassword;
            //connection.IntegratedSecurity = true;

            String strConn = connection.ToString();

            //create connection
            SqlConnection sqlConn = new SqlConnection(strConn);
            try
            {
                //open connection
                sqlConn.Open();

                //get databases
                DataTable tblDatabases = sqlConn.GetSchema("Databases");


                //close connection
                sqlConn.Close();

                //add to list
                foreach (DataRow row in tblDatabases.Rows)
                {
                    String strDatabaseName = row["database_name"].ToString();

                    databases.Add(strDatabaseName);


                }
                return databases;
            }catch (Exception er)
            {

                throw (er);
            }
        }

        public bool CheckServerAvailablity(string serverIPAddress)
        {
            try
            {
                IPHostEntry ipHostEntry = Dns.Resolve(serverIPAddress);
                IPAddress ipAddress = ipHostEntry.AddressList[0];

                TcpClient TcpClient = new TcpClient();
                TcpClient.Connect(ipAddress, 1433);
                TcpClient.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public List<string> FN_GetDBTableList(SqlConnection CN)
        {
            List<string> TbList = new List<string>();
            using (CN)
            {
                SqlCommand CMD = new SqlCommand("select name from sys.tables union select name from sys.views", CN);
                CN.Open();
                SqlDataReader Reader = CMD.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {

                        TbList.Add(Reader.GetString(0));
                            
                    }
                }
                return TbList;
                CN.Close();
            }
        }

        public List<string> FN_GetTbColumnList(SqlConnection CN,String TbName)
        {
            List<string> TbList = new List<string>();
            using (CN)
            {
                try
                {
                    SqlCommand CMD = new SqlCommand("exec sp_columns " + TbName , CN);
                    
                    CN.Open();
                    SqlDataReader Reader = CMD.ExecuteReader();
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {

                            TbList.Add(Reader.GetString(3));

                        }
                    }
                    return TbList;
                    CN.Close();
                }catch (Exception er)
                {
                   throw (er);
                }
            }
        }
        public string FN_FormatDate(DateTime date,bool IsShamsi,bool Is8DigitFormat)
        {
            string Cdate = "";
            PersianCalendar CLD = new PersianCalendar();
            
            if (IsShamsi == false)
            {
                Cdate +=date.Year + "/" + date.Month.ToString().PadLeft(2,'0')+"/"+date.Day.ToString().PadLeft(2,'0');
            }else
            {
                Cdate += CLD.GetYear(date) + "/" + CLD.GetMonth(date).ToString().PadLeft(2, '0') + "/" + CLD.GetDayOfMonth(date).ToString().PadLeft(2, '0');
            }
            if (Is8DigitFormat == true)
            {
                Cdate = Cdate.Remove(0, 2);
            }
            return Cdate;
        }
    }
}
