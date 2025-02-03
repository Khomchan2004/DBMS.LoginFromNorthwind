namespace DBMS.LoginFromNorthwind
{
    partial class FRMLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancel = new Button();
            btnOK = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(389, 216);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 28);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(271, 216);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(95, 28);
            btnOK.TabIndex = 7;
            btnOK.Text = "Ok";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(267, 78);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(247, 23);
            txtUsername.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(267, 122);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = 'x';
            txtPassword.Size = new Size(247, 23);
            txtPassword.TabIndex = 10;
            txtPassword.UseWaitCursor = true;
            txtPassword.MouseLeave += txtPassword_MouseLeave;
            txtPassword.MouseHover += txtPassword_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 85);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 11;
            label1.Text = "ชื่อผู้ใช้";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 130);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 12;
            label2.Text = "รหัสผ่าน";
            // 
            // FRMLogin
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(558, 289);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Name = "FRMLogin";
            Text = "FRMLogin";
            Load += FRMLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnOK;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
    }
}