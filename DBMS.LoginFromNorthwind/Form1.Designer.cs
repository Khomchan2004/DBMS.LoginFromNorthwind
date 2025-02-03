namespace DBMS.LoginFromNorthwind
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnLogin = new Button();
            btnLogout = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(74, 31);
            button1.Name = "button1";
            button1.Size = new Size(211, 70);
            button1.TabIndex = 0;
            button1.Text = "Employees พนักงาน";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(74, 116);
            button2.Name = "button2";
            button2.Size = new Size(211, 70);
            button2.TabIndex = 2;
            button2.Text = "Customer ลูกค้า";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(74, 208);
            button3.Name = "button3";
            button3.Size = new Size(211, 70);
            button3.TabIndex = 3;
            button3.Text = "Suppliers ตัวแทนจำหน่าย";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(74, 296);
            button4.Name = "button4";
            button4.Size = new Size(211, 70);
            button4.TabIndex = 4;
            button4.Text = "Shippers บริษัทขนส่ง";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(262, 50);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(95, 28);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(380, 50);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(95, 28);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Visible = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(35, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 413);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 561);
            Controls.Add(btnLogout);
            Controls.Add(btnLogin);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnLogin;
        private Button btnLogout;
        private GroupBox groupBox1;
    }
}
