namespace DBMS.LoginFromNorthwind
{
    partial class frmEmployee
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
            dgvEmployee = new DataGridView();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(23, 12);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.Size = new Size(751, 336);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellMouseUp += dgvEmployee_CellMouseUp;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(68, 387);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(131, 50);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "เพิ่ม";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(331, 387);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 50);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "แก้ไข";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(585, 387);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 50);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "ลบ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dgvEmployee);
            Name = "frmEmployee";
            Text = "frmEmployee";
            Load += frmEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmployee;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
    }
}