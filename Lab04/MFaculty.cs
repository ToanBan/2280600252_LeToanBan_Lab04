using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class MFaculty : Form
    {
        private Model1 context;

        public MFaculty()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MFaculty_Load(object sender, EventArgs e)
        {
            txtTotalGS.ReadOnly = true;
            context = new Model1();
            LoadDataGridView();
        }

        private void ResetData()
        {
            txtMa.Clear();
            txtName.Clear();
            txtTotal.Clear();
        }

        private void LoadDataGridView()
        {
            try
            {
                List<Faculty> facs = context.Faculties.ToList();
                if (comboBox1.SelectedIndex == 0) 
                {
                    facs = facs.OrderBy(f => f.TotalProfessor).ToList();
                }
                else if (comboBox1.SelectedIndex == 1) 
                {
                    facs = facs.OrderByDescending(f => f.TotalProfessor).ToList();
                }
                dataGridView2.Rows.Clear();
                foreach (var fac in facs)
                {
                    int index = dataGridView2.Rows.Add();
                    dataGridView2.Rows[index].Cells["colMa"].Value = fac.FacultyID;
                    dataGridView2.Rows[index].Cells["colName"].Value = fac.FacultyName;
                    dataGridView2.Rows[index].Cells["colTotal"].Value = fac.TotalProfessor;
                }
                UpdateCountGiaosu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtTotal.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string KhoaIDStr = txtMa.Text;
                string KhoaName = txtName.Text;
                string TotalStr = txtTotal.Text;
                if (KhoaName.Length < 3 || KhoaName.Length > 100 || !Regex.IsMatch(KhoaName, @"^[\p{L}\s]+$"))
                {
                    MessageBox.Show("Tên Khoa phải từ 3 đến 100 ký tự và chỉ chứa chữ cái.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(KhoaIDStr, out int KhoaID))
                {
                    MessageBox.Show("Mã Khoa phải là một số nguyên hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(TotalStr, out int total))
                {
                    MessageBox.Show("Số Lượng Giáo Sư phải là một số nguyên hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (total < 1 || total > 15)
                {
                    MessageBox.Show("Số Lượng Giáo Sư từ 1 đến 15.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (context.Faculties.Any(f => f.FacultyID == KhoaID))
                {
                    MessageBox.Show("Mã Khoa đã tồn tại. Vui lòng sử dụng mã khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Faculty fc = new Faculty()
                {
                    FacultyID = KhoaID,
                    FacultyName = KhoaName,
                    TotalProfessor = total,
                };

                context.Faculties.Add(fc);
                context.SaveChanges();
                LoadDataGridView();

                MessageBox.Show("Thêm Khoa Thành Công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi Thêm Khoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCountGiaosu()
        {
            try
            {
                var sum = context.Faculties.Sum(s => s.TotalProfessor);
                txtTotalGS.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính tổng số lượng giáo sư: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int facultyID = (int)dataGridView2.SelectedRows[0].Cells["colMa"].Value;
                Faculty facultyEdit = context.Faculties.FirstOrDefault(s => s.FacultyID == facultyID);
                if (facultyEdit != null)
                {
                    try
                    {
                        if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtTotal.Text))
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string newKhoaIDStr = txtMa.Text;
                        string newKhoaName = txtName.Text;
                        string newTotalStr = txtTotal.Text;
                        if (newKhoaName.Length < 3 || newKhoaName.Length > 100 || !Regex.IsMatch(newKhoaName, @"^[\p{L}\s]+$"))
                        {
                            MessageBox.Show("Tên Khoa phải từ 3 đến 100 ký tự và chỉ chứa chữ cái.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (!int.TryParse(newKhoaIDStr, out int newKhoaID))
                        {
                            MessageBox.Show("Mã Khoa phải là một số nguyên hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (!int.TryParse(newTotalStr, out int newTotal))
                        {
                            MessageBox.Show("Số Lượng Giáo Sư phải là một số nguyên hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (newTotal < 1 || newTotal > 15)
                        {
                            MessageBox.Show("Số Lượng Giáo Sư từ 1 đến 15.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (newKhoaID != facultyEdit.FacultyID && context.Faculties.Any(f => f.FacultyID == newKhoaID))
                        {
                            MessageBox.Show("Mã Khoa mới đã tồn tại. Vui lòng sử dụng mã khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        facultyEdit.FacultyID = newKhoaID;
                        facultyEdit.FacultyName = newKhoaName;
                        facultyEdit.TotalProfessor = newTotal;
                        LoadDataGridView();
                        MessageBox.Show("Cập Nhật Khoa Thành Công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi Khi Cập Nhật Khoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Khoa để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int facultyID = (int)dataGridView2.SelectedRows[0].Cells["colMa"].Value;
                Faculty facultyDelete = context.Faculties.FirstOrDefault(s => s.FacultyID == facultyID);
                if (facultyDelete != null)
                {
                    var result = MessageBox.Show("Bạn có muốn xoá không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            context.Faculties.Remove(facultyDelete);
                            context.SaveChanges();
                            LoadDataGridView();

                            MessageBox.Show("Xoá Khoa Thành Công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi Khi Xoá Khoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Khoa để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
