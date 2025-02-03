using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS.LoginFromNorthwind
{
    internal class connectDB
    {
        public static SqlConnection ConnecNorthwind()
        {
            string server = @"LAPTOP-7KNTOGM4\SQLEXPRESS02";
            string db = "Northwind";
            string strCon = string.Format(@"Data Source={0}; Initial Catalog={1};"
                      + "Integrated Security=True;Encrypt=False", server, db);
            /*string strCon = "Data Source=LAPTOP-7KNTOGM4\\SQLEXPRESS02;Initial Catalog=Northwind;Integrated Security=True;Encrypt=False";*/
            /*conn = new SqlConnection(strCon);*/
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            return conn;
        }
    }
}
