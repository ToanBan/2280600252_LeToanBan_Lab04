namespace Lab04
{
    partial class Search
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbKhoa);
            this.groupBox1.Controls.Add(this.radioNu);
            this.groupBox1.Controls.Add(this.radioNam);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblGioitinh);
            this.groupBox1.Controls.Add(this.lblKhoa);
            this.groupBox1.Controls.Add(this.lblMa);
            this.groupBox1.Location = new System.Drawing.Point(432, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(183, 163);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(260, 24);
            this.cmbKhoa.TabIndex = 9;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(285, 114);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(45, 20);
            this.radioNu.TabIndex = 8;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(183, 114);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(57, 20);
            this.radioNam.TabIndex = 7;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(183, 31);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(260, 22);
            this.txtMa.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Tên Sinh Viên";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Location = new System.Drawing.Point(24, 114);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(60, 16);
            this.lblGioitinh.TabIndex = 2;
            this.lblGioitinh.Text = "Giới Tính";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(24, 163);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(38, 16);
            this.lblKhoa.TabIndex = 1;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(24, 31);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(85, 16);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã Sinh Viên";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(432, 248);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 47);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(605, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 47);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1030, 248);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 47);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(373, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(852, 291);
            this.dataGridView1.TabIndex = 13;
            // 
            // colMa
            // 
            this.colMa.HeaderText = "Mã Số SV";
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
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 615);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
    }
}