using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS.LoginFromNorthwind
{
    public partial class FRMLogin : Form
    {
        public FRMLogin()
        {
            InitializeComponent();
        }

        public string Loging_status { get; set; }
        public int employeeID { get; set; }
        public string employeeName { get; set; }
        public string title { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            /*string username = txtUsername.Text;
            string password = txtPassword.Text;
*/
            string username = "";
            string password = "";
            string sql = "select EmployeeID,TitleOfCourtesy+FirstName+''+LastName employeeName,title "
                         +" from Employees where username = @username and Password = @password";

            cmd = new SqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count==1)
            {
                this.Loging_status = "pass";
                this.employeeID = Convert.ToInt16(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
                this.employeeName = ds.Tables[0].Rows[0]["EmployeeName"].ToString();
                this.title = ds.Tables[0].Rows[0]["title"].ToString();
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "เกิดข้อผิดพลาด");
            }
            this.Close();
        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }


        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection conn;
        private void FRMLogin_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnecNorthwind();
            conn.Close();
        }
    }
}
