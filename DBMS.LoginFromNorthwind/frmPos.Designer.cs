namespace dbms_Notrhwind
{
    partial class frmPos
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
            txtEmployeeID = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            txtTotal = new TextBox();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            txtEmployeeName = new TextBox();
            lsvProducts = new ListView();
            btnAdd = new Button();
            btnClear = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            GroupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblNetPrice = new Label();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(90, 41);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(80, 23);
            txtEmployeeID.TabIndex = 0;
            txtEmployeeID.KeyDown += txtEmployeeID_KeyDown;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(233, 49);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(80, 23);
            txtUnitPrice.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(349, 49);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(80, 23);
            txtQuantity.TabIndex = 2;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(483, 49);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(80, 23);
            txtTotal.TabIndex = 4;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(122, 49);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(80, 23);
            txtProductName.TabIndex = 5;
            txtProductName.Text = " ";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(20, 49);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(80, 23);
            txtProductID.TabIndex = 6;
            txtProductID.KeyDown += txtProductID_KeyDown;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(316, 41);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.ReadOnly = true;
            txtEmployeeName.Size = new Size(80, 23);
            txtEmployeeName.TabIndex = 7;
            // 
            // lsvProducts
            // 
            lsvProducts.Location = new Point(20, 91);
            lsvProducts.Name = "lsvProducts";
            lsvProducts.Size = new Size(543, 198);
            lsvProducts.TabIndex = 8;
            lsvProducts.UseCompatibleStateImageBehavior = false;
            lsvProducts.DoubleClick += lsvProducts_DoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(678, 147);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "เพิ่มรายการ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(678, 186);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(678, 341);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(655, 388);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 23);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "ยกเลิกรายการสั่งซื้อ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 49);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 13;
            label1.Text = "รหัสพนักงาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 49);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 14;
            label2.Text = "ชื่อ - สกุล";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(label8);
            GroupBox1.Controls.Add(label7);
            GroupBox1.Controls.Add(label6);
            GroupBox1.Controls.Add(label5);
            GroupBox1.Controls.Add(label4);
            GroupBox1.Controls.Add(txtProductName);
            GroupBox1.Controls.Add(txtTotal);
            GroupBox1.Controls.Add(txtQuantity);
            GroupBox1.Controls.Add(txtUnitPrice);
            GroupBox1.Controls.Add(lsvProducts);
            GroupBox1.Controls.Add(txtProductID);
            GroupBox1.Location = new Point(70, 137);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(579, 305);
            GroupBox1.TabIndex = 15;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "groupBox1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(483, 31);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 21;
            label8.Text = "รวมเป็นเงิน";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(349, 31);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 20;
            label7.Text = "จำนวน";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(233, 31);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 19;
            label6.Text = "ราคาขาย";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 31);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 18;
            label5.Text = "ชื่อสินค้า";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 31);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 17;
            label4.Text = "รหัสสินค้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(716, 21);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 16;
            label3.Text = "รวมเป็นเงิน";
            // 
            // lblNetPrice
            // 
            lblNetPrice.AutoSize = true;
            lblNetPrice.BackColor = Color.MediumBlue;
            lblNetPrice.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNetPrice.ForeColor = SystemColors.ButtonFace;
            lblNetPrice.Location = new Point(641, 49);
            lblNetPrice.Name = "lblNetPrice";
            lblNetPrice.Size = new Size(147, 37);
            lblNetPrice.TabIndex = 17;
            lblNetPrice.Text = "lblNetPrice";
            // 
            // frmPos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNetPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtEmployeeID);
            Controls.Add(GroupBox1);
            Name = "frmPos";
            Text = "frmPos";
            Load += frmPos_Load;
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmployeeID;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private TextBox txtTotal;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private TextBox txtEmployeeName;
        private ListView lsvProducts;
        private Button btnAdd;
        private Button btnClear;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private GroupBox GroupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblNetPrice;
    }
}