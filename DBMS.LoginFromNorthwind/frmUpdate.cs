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
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        private string connectionString;

        public string Status { get; set; }
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string PhotoPath { get; set; }
        public string Notes { get; set; }
        public string Extension { get; set; }
        public int ReportsTo { get; set; }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            txtAddress.Text = Address;
            txtBirthDate.Text = BirthDate.ToString();
            txtCity.Text = City;
            txtCountry.Text = Country;
            txtEmployeeID.Text = EmployeeID.ToString();
            txtExtension.Text = Extension;
            txtFirstName.Text = FirstName;
            txtHireDate.Text = HireDate.ToString();
            txtLastName.Text = LastName;
            txtNotes.Text = Notes;
            txtHomePhone.Text = HomePhone;
            txtPhotoPath.Text = PhotoPath;
            txtPostalCode.Text = PostalCode;
            txtRegion.Text = Region;
            txtReportsTo.Text = ReportsTo.ToString();
            txtTitle.Text = Title;
            txtTitleOfCourtesy.Text = TitleOfCourtesy;

            // แสดงรูปภาพใน PictureBox โดยใช้เส้นทางจาก PhotoPath
            if (!string.IsNullOrEmpty(PhotoPath) && File.Exists(PhotoPath))
            {
                img.Image = Image.FromFile(PhotoPath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn = connectDB.ConnecNorthwind();
            if (Status == "insert")
            {
                InsertEmployees();
            }
            else if (Status == "update")
            {
                UpdateEmployees();
            }
            this.Close();
        }

        private void InsertEmployees()
        {
            MessageBox.Show("เพิ่มข้อมูล");

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("โปรดกรอกข้อมูล", "เกิดข้อผิดพลาด");
                return;
            }

            string sql = "Insert into Employees(LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Notes,PhotoPath,Extension,ReportsTo) " +
                         "Values(@LastName,@FirstName,@Title,@TitleOfCourtesy,@BirthDate,@HireDate,@Address,@City,@Region,@PostalCode,@Country,@HomePhone,@Notes,@PhotoPath,@Extension,@ReportsTo)";

            using (SqlConnection conn = connectDB.ConnecNorthwind())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@TitleOfCourtesy", txtTitleOfCourtesy.Text);

                    if (DateTime.TryParse(txtBirthDate.Text, out DateTime birthDate) && birthDate >= new DateTime(1753, 1, 1))
                    {
                        cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@BirthDate", DBNull.Value);
                    }

                    if (DateTime.TryParse(txtHireDate.Text, out DateTime hireDate) && hireDate >= new DateTime(1753, 1, 1))
                    {
                        cmd.Parameters.AddWithValue("@HireDate", hireDate);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@HireDate", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@City", txtCity.Text);
                    cmd.Parameters.AddWithValue("@Region", txtRegion.Text);
                    cmd.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text);
                    cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
                    cmd.Parameters.AddWithValue("@HomePhone", txtHomePhone.Text);
                    cmd.Parameters.AddWithValue("@Notes", txtNotes.Text);
                    cmd.Parameters.AddWithValue("@PhotoPath", txtPhotoPath.Text); // เก็บเส้นทางรูปภาพ
                    cmd.Parameters.AddWithValue("@Extension", txtExtension.Text);

                    // ตรวจสอบค่า ReportsTo
                    if (string.IsNullOrEmpty(txtReportsTo.Text) || !int.TryParse(txtReportsTo.Text, out int reportsTo) || reportsTo == EmployeeID)
                    {
                        cmd.Parameters.AddWithValue("@ReportsTo", DBNull.Value);
                    }
                    else
                    {
                        // ตรวจสอบว่า ReportsTo มีอยู่ในตาราง Employees หรือไม่
                        string checkSql = "SELECT COUNT(*) FROM Employees WHERE EmployeeID = @ReportsTo";
                        using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@ReportsTo", reportsTo);
                            if (conn.State != ConnectionState.Open)
                            {
                                conn.Open();
                            }
                            int count = (int)checkCmd.ExecuteScalar();
                            if (count == 0)
                            {
                                MessageBox.Show("ค่า ReportsTo ไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                                return;
                            }
                        }
                        cmd.Parameters.AddWithValue("@ReportsTo", reportsTo);
                    }

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้ว");
        }

        private void UpdateEmployees()
        {
            MessageBox.Show("ปรับปรุงข้อมูล");

            if (string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะปรับปรุงแก้ไข", "เกิดข้อผิดพลาด");
                return;
            }

            string sql = "Update Employees set LastName = @LastName, FirstName= @FirstName,Title = @Title," +
                         "TitleOfCourtesy=@TitleOfCourtesy,BirthDate=@BirthDate,HireDate=@HireDate,Address=@Address," +
                         "City=@City,Region=@Region,PostalCode=@PostalCode,Country=@Country,HomePhone=@HomePhone," +
                         "Notes=@Notes,PhotoPath=@PhotoPath,Extension=@Extension,ReportsTo=@ReportsTo where EmployeeID=@EmployeeID";

            using (SqlConnection conn = connectDB.ConnecNorthwind())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@TitleOfCourtesy", txtTitleOfCourtesy.Text);

                    if (DateTime.TryParse(txtBirthDate.Text, out DateTime birthDate) && birthDate >= new DateTime(1753, 1, 1))
                    {
                        cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@BirthDate", DBNull.Value);
                    }

                    if (DateTime.TryParse(txtHireDate.Text, out DateTime hireDate) && hireDate >= new DateTime(1753, 1, 1))
                    {
                        cmd.Parameters.AddWithValue("@HireDate", hireDate);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@HireDate", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@City", txtCity.Text);
                    cmd.Parameters.AddWithValue("@Region", txtRegion.Text);
                    cmd.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text);
                    cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
                    cmd.Parameters.AddWithValue("@HomePhone", txtHomePhone.Text);
                    cmd.Parameters.AddWithValue("@Notes", txtNotes.Text);
                    cmd.Parameters.AddWithValue("@PhotoPath", txtPhotoPath.Text); // เก็บเส้นทางรูปภาพ
                    cmd.Parameters.AddWithValue("@Extension", txtExtension.Text);

                    // ตรวจสอบค่า ReportsTo
                    if (string.IsNullOrEmpty(txtReportsTo.Text) || !int.TryParse(txtReportsTo.Text, out int reportsTo) || reportsTo == EmployeeID)
                    {
                        cmd.Parameters.AddWithValue("@ReportsTo", DBNull.Value);
                    }
                    else
                    {
                        // ตรวจสอบว่า ReportsTo มีอยู่ในตาราง Employees หรือไม่
                        string checkSql = "SELECT COUNT(*) FROM Employees WHERE EmployeeID = @ReportsTo";
                        using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@ReportsTo", reportsTo);
                            if (conn.State != ConnectionState.Open)
                            {
                                conn.Open();
                            }
                            int count = (int)checkCmd.ExecuteScalar();
                            if (count == 0)
                            {
                                MessageBox.Show("ค่า ReportsTo ไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                                return;
                            }
                        }
                        cmd.Parameters.AddWithValue("@ReportsTo", reportsTo);
                    }

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("ปรับปรุงข้อมูลเรียบร้อยแล้ว");
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void img_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // สร้างคำสั่ง SQL สำหรับการบันทึกรูปภาพ
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Employees (Photo) VALUES (@Photo)", conn))
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    conn.Open();

                    // ตรวจสอบว่ามีภาพใน PictureBox หรือไม่
                    if (img.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            // แปลงภาพใน PictureBox เป็นไบต์
                            img.Image.Save(ms, img.Image.RawFormat);

                            // เพิ่มภาพในรูปแบบไบต์ลงใน SqlParameter
                            cmd.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = ms.ToArray();
                        }
                    }
                    else
                    {
                        // ถ้าไม่มีภาพ ให้ใส่ค่า null ลงในฐานข้อมูล
                        cmd.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = DBNull.Value;
                    }

                    // รันคำสั่ง SQL
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
