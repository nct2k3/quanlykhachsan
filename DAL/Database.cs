using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using DevExpress.Map.Kml.Model;

namespace QuanLyKhachSan.DAL
{
    class Database
    {
        MySqlConnection sqlConn; // Database connection object
        MySqlDataAdapter da; // Data adapter for coordinating data
        DataSet ds; // Dataset for holding data when communicating

        public Database()
        {
           
            string strCnn = "server=localhost;database=hotel_management;user=root;PwD=;port = 3306"; // MySQL connection string
            sqlConn = new MySqlConnection(strCnn);
        }

        // Method to execute SQL query and retrieve data
        public DataTable Execute(string sqlStr)
        {
                da = new MySqlDataAdapter(sqlStr, sqlConn);
                ds = new DataSet();
                da.Fill(ds);
   
            return ds.Tables[0];
        }
        public void ExecuteNonQuery(string strSQL)
        {
            MySqlCommand sqlcmd = new MySqlCommand(strSQL, sqlConn);
            sqlConn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }
    }
}