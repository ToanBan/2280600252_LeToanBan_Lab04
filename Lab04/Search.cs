using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Search : Form
    {

        private Model1 context;
        public Search()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát không", "thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            cmbKhoa.SelectedValue = "chọn";
            context = new Model1();
            List<Student> students = context.Students.ToList();
            List<Faculty> faculties = context.Faculties.ToList();
            cmbKhoa.DataSource = faculties;
            cmbKhoa.DisplayMember = "FacultyName";
            cmbKhoa.ValueMember = "FacultyID";
            cmbKhoa.Text = "Chọn Khoa";
            dataGridView1.Rows.Clear();
            foreach (var student in students)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells["colMa"].Value = student.StudentID;
                dataGridView1.Rows[index].Cells["colName"].Value = student.FullName;
                dataGridView1.Rows[index].Cells["colGioitinh"].Value = student.Gender;
                dataGridView1.Rows[index].Cells["colKhoa"].Value = student.Faculty.FacultyName;
                dataGridView1.Rows[index].Cells["colDiem"].Value = student.AverageScore;
            }
        }

        private void LoadDataGridView()
        {
            List<Student> students = context.Students.ToList();
            dataGridView1.Rows.Clear();
            foreach (var student in students)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells["colMa"].Value = student.StudentID;
                dataGridView1.Rows[index].Cells["colName"].Value = student.FullName;
                dataGridView1.Rows[index].Cells["colGioitinh"].Value = student.Gender;
                dataGridView1.Rows[index].Cells["colDiem"].Value = student.AverageScore;
                dataGridView1.Rows[index].Cells["colKhoa"].Value = student.Faculty.FacultyName;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new Model1())
            {
                string studentIDText = txtMa.Text.Trim();
                string fullname = txtName.Text.Trim();
                string gioitinh = radioNam.Checked ? "Nam" : "Nữ";
                int facultyID = (int)cmbKhoa.SelectedValue;
                var query = context.Students.AsQueryable();
                if (!string.IsNullOrEmpty(studentIDText) && int.TryParse(studentIDText, out int studentID))
                {
                    query = query.Where(s => s.StudentID == studentID);
                }
                else if (!string.IsNullOrEmpty(fullname))
                {
                    query = query.Where(s => s.FullName.Contains(fullname));
                }
                else if (gioitinh != null)
                {
                    query = query.Where(s => s.Gender == gioitinh);
                }
                else if (facultyID >= 0)
                {
                    query = query.Where(s => s.FacultyID == facultyID);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập ít nhất một trường để tìm kiếm.");
                    return;
                }
                var results = query.ToList();
                dataGridView1.Rows.Clear();
                foreach (var student in results)
                {
                    dataGridView1.Rows.Add(student.StudentID, student.FullName, student.Gender, student.AverageScore, student.Faculty.FacultyName);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int studentID = (int)dataGridView1.SelectedRows[0].Cells["colMa"].Value;
                Student studentDelete = context.Students.FirstOrDefault(s => s.StudentID == studentID);
                if (studentDelete != null)
                {
                    var result = MessageBox.Show("Bạm có muốn xoá không", "Thông Báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        context.Students.Remove(studentDelete);
                        context.SaveChanges();
                        LoadDataGridView();
                        MessageBox.Show("Xoá Sinh Viên Thành Công");
                    }
                }
            }
        }
    }
}
