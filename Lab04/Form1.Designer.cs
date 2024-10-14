namespace Lab04
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcountNam = new System.Windows.Forms.TextBox();
            this.txtcountNu = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(445, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbKhoa);
            this.groupBox1.Controls.Add(this.radioNu);
            this.groupBox1.Controls.Add(this.radioNam);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.lblDiem);
            this.groupBox1.Controls.Add(this.lblKhoa);
            this.groupBox1.Controls.Add(this.lblGioitinh);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblMa);
            this.groupBox1.Location = new System.Drawing.Point(40, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 429);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(128, 362);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 43);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(264, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 43);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 362);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 43);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(146, 249);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(242, 24);
            this.cmbKhoa.TabIndex = 10;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(264, 187);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(45, 20);
            this.radioNu.TabIndex = 9;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(146, 187);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(57, 20);
            this.radioNam.TabIndex = 8;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(151, 310);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(237, 22);
            this.txtDiem.TabIndex = 6;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(151, 59);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(237, 22);
            this.txtMa.TabIndex = 5;
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(6, 316);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(105, 16);
            this.lblDiem.TabIndex = 4;
            this.lblDiem.Text = "Điểm Trung Bình";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(6, 249);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(38, 16);
            this.lblKhoa.TabIndex = 3;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Location = new System.Drawing.Point(6, 191);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(60, 16);
            this.lblGioitinh.TabIndex = 2;
            this.lblGioitinh.Text = "Giới Tính";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 121);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Họ Tên";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(6, 59);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(47, 16);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã SV";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colName,
            this.colGioitinh,
            this.colDiem,
            this.colKhoa});
            this.dataGridView1.Location = new System.Drawing.Point(493, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(880, 355);
            this.dataGridView1.TabIndex = 2;
            // 
            // colMa
            // 
            this.colMa.HeaderText = "Mã Sinh Viên";
            this.colMa.MinimumWidth = 6;
            this.colMa.Name = "colMa";
            this.colMa.Width = 125;
            // 
            // colName
            // 
            this.colName.HeaderText = "Họ Và Tên";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 125;
            // 
            // colGioitinh
            // 
            this.colGioitinh.HeaderText = "Giới Tính";
            this.colGioitinh.MinimumWidth = 6;
            this.colGioitinh.Name = "colGioitinh";
            this.colGioitinh.Width = 125;
            // 
            // colDiem
            // 
            this.colDiem.HeaderText = "Điểm Trung Bình";
            this.colDiem.MinimumWidth = 6;
            this.colDiem.Name = "colDiem";
            this.colDiem.Width = 125;
            // 
            // colKhoa
            // 
            this.colKhoa.HeaderText = "Tên Khoa";
            this.colKhoa.MinimumWidth = 6;
            this.colKhoa.Name = "colKhoa";
            this.colKhoa.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng Số Sinh Viên Nam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(831, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng Số Sinh Viên Nữ";
            // 
            // txtcountNam
            // 
            this.txtcountNam.Location = new System.Drawing.Point(712, 511);
            this.txtcountNam.Name = "txtcountNam";
            this.txtcountNam.Size = new System.Drawing.Size(100, 22);
            this.txtcountNam.TabIndex = 5;
            // 
            // txtcountNu
            // 
            this.txtcountNu.Location = new System.Drawing.Point(990, 511);
            this.txtcountNu.Name = "txtcountNu";
            this.txtcountNu.Size = new System.Drawing.Size(100, 22);
            this.txtcountNu.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heToolStripMenuItem,
            this.thongKeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1373, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heToolStripMenuItem
            // 
            this.heToolStripMenuItem.Name = "heToolStripMenuItem";
            this.heToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.heToolStripMenuItem.Text = "HeThong";
            // 
            // thongKeToolStripMenuItem
            // 
            this.thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            this.thongKeToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.thongKeToolStripMenuItem.Text = "ThongKe";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripButton2,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1373, 27);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(99, 24);
            this.toolStripLabel1.Text = "Quản Lý Khoa";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.Text = "Tìm Kiếm";
            this.toolStripTextBox1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1181, 498);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 43);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Lab04.Properties.Resources.knowledge;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Lab04.Properties.Resources.search;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 569);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtcountNu);
            this.Controls.Add(this.txtcountNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcountNam;
        private System.Windows.Forms.TextBox txtcountNu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}

