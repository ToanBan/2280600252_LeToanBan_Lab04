namespace Lab04
{
    partial class MFaculty
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalGS = new System.Windows.Forms.Label();
            this.txtTotalGS = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(522, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Khoa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblMa);
            this.groupBox1.Location = new System.Drawing.Point(39, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khoa";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(127, 164);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(216, 22);
            this.txtTotal.TabIndex = 4;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(127, 46);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(216, 22);
            this.txtMa.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(21, 164);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(81, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Tổng Số GS";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 109);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên Khoa";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(21, 52);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(60, 16);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã Khoa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(39, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 90);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tăng Dần",
            "Giảm Dần"});
            this.comboBox1.Location = new System.Drawing.Point(115, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Săp Xếp";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 433);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 65);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(307, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 65);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(166, 433);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 65);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colName,
            this.colTotal});
            this.dataGridView2.Location = new System.Drawing.Point(513, 96);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(681, 330);
            this.dataGridView2.TabIndex = 6;
            // 
            // colMa
            // 
            this.colMa.HeaderText = "Mã Khoa";
            this.colMa.MinimumWidth = 6;
            this.colMa.Name = "colMa";
            this.colMa.Width = 125;
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên Khoa";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 125;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Tổng Số GS";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 125;
            // 
            // lblTotalGS
            // 
            this.lblTotalGS.AutoSize = true;
            this.lblTotalGS.Location = new System.Drawing.Point(529, 456);
            this.lblTotalGS.Name = "lblTotalGS";
            this.lblTotalGS.Size = new System.Drawing.Size(81, 16);
            this.lblTotalGS.TabIndex = 7;
            this.lblTotalGS.Text = "Tổng Số GS";
            // 
            // txtTotalGS
            // 
            this.txtTotalGS.Location = new System.Drawing.Point(649, 449);
            this.txtTotalGS.Name = "txtTotalGS";
            this.txtTotalGS.Size = new System.Drawing.Size(189, 22);
            this.txtTotalGS.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1058, 448);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 65);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 547);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTotalGS);
            this.Controls.Add(this.lblTotalGS);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MFaculty";
            this.Text = "MFaculty";
            this.Load += new System.EventHandler(this.MFaculty_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Label lblTotalGS;
        private System.Windows.Forms.TextBox txtTotalGS;
        private System.Windows.Forms.Button btnClose;
    }
}