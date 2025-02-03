using dbms_Notrhwind;

namespace DBMS.LoginFromNorthwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FRMLogin f = new FRMLogin();
            f.ShowDialog();
            if (f.Loging_status == "pass")
            {
                this.Text = "โปรแกรม Northwind : รหัส : " + f.employeeID.ToString();
                this.Text += " ชื่อ-สกุล: " + f.employeeName + "ตำแหน่ง :" + f.title;
                groupBox1.Visible = true;
                btnLogin.Visible = false;
                btnLogout.Visible = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Text = "โปรแกรม Northwind";
            groupBox1.Visible = false;
            btnLogin.Visible = false;
            btnLogout.Visible = true;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee em = new frmEmployee();
            em.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmPos pos = new frmPos();
            pos.ShowDialog();
        }
    }
}
