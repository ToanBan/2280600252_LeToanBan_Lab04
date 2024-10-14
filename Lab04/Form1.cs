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
    public partial class Form1 : Form
    {
        private Model1 dbcontext;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDataGridView()
        {
            List<Student> students = dbcontext.Students.ToList();
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

        private void ResetData()
        {
            txtMa.Clear();
            txtName.Clear();
            txtDiem.Clear();
            cmbKhoa.SelectedIndex = 0;
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtDiem.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                string studentIDStr = txtMa.Text;
                if (studentIDStr.Length != 10 || !studentIDStr.All(char.IsDigit))
                {
                    MessageBox.Show("Mã số sinh viên không hợp lệ.");
                    return;
                }
                string fullname = txtName.Text;
                if (fullname.Length < 3 || fullname.Length > 100 || !Regex.IsMatch(fullname, @"^[\p{L}\s]+$"))
                {
                    MessageBox.Show("Tên sinh viên phải từ 3 đến 100 ký tự và chỉ chứa chữ cái.");
                    return;
                }
                if (!decimal.TryParse(txtDiem.Text, out decimal diem) || diem < 0 || diem > 10)
                {
                    MessageBox.Show("Điểm trung bình sinh viên không hợp lệ.");
                    return;
                }
                int studentID = int.Parse(studentIDStr);
                string gioitinh = radioNam.Checked ? "Nam" : "Nữ";
                int facultyID = (int)cmbKhoa.SelectedValue;
                Student s = new Student()
                {
                    StudentID = studentID,
                    FullName = fullname,
                    Gender = gioitinh,
                    AverageScore = diem,
                    FacultyID = facultyID
                };
                dbcontext.Students.Add(s);
                dbcontext.SaveChanges();
                UpdateCountStudentMaleAndFemale();
                LoadDataGridView();
                ResetData();
                MessageBox.Show("Thêm Sinh Viên Thành Công");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi Thêm Sinh Viên: " + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát không", "thông báo", MessageBoxButtons.YesNo);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát không", "thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { 
               Application.Exit();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MFaculty mFaculty = new MFaculty();
            mFaculty.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtcountNam.ReadOnly = true;
            txtcountNu.ReadOnly = true;
            radioNu.Checked = true;
            dbcontext = new Model1();
            List<Student> students = dbcontext.Students.ToList();
            List<Faculty> faculties = dbcontext.Faculties.ToList();
            cmbKhoa.DataSource = faculties;
            cmbKhoa.DisplayMember = "FacultyName";
            cmbKhoa.ValueMember = "FacultyID";
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
            txtcountNam.Text = dbcontext.Students.Count(s => s.Gender == "Nam").ToString();
            txtcountNu.Text = dbcontext.Students.Count(s => s.Gender == "Nữ").ToString();
        }

        private void UpdateCountStudentMaleAndFemale()
        {
            int countStudentMale = dbcontext.Students.Count(s => s.Gender == "Nam");
            int countStudentFemale = dbcontext.Students.Count(s => s.Gender == "Nữ");
            txtcountNam.Text = countStudentMale.ToString();
            txtcountNu.Text = countStudentFemale.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int studentID = (int)dataGridView1.SelectedRows[0].Cells["colMa"].Value;
                Student studentEdit = dbcontext.Students.FirstOrDefault(s => s.StudentID == studentID);
                if (studentEdit != null)
                {
                    studentEdit.StudentID = int.Parse(txtMa.Text);
                    studentEdit.FullName = txtName.Text;
                    studentEdit.Gender = radioNam.Checked ? "Nam" : "Nữ";
                    studentEdit.AverageScore = decimal.Parse(txtDiem.Text);
                    studentEdit.FacultyID = cmbKhoa.SelectedIndex;
                    LoadDataGridView();
                    UpdateCountStudentMaleAndFemale();
                    ResetData();
                    MessageBox.Show("Cập Nhật Sinh Viên Thành Công");

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int studentID = (int)dataGridView1.SelectedRows[0].Cells["colMa"].Value;
                Student studentDelete = dbcontext.Students.FirstOrDefault(s => s.StudentID == studentID);
                if (studentDelete != null)
                {
                    var result = MessageBox.Show("Bạm có muốn xoá không", "Thông Báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        dbcontext.Students.Remove(studentDelete);
                        dbcontext.SaveChanges();
                        UpdateCountStudentMaleAndFemale();
                        LoadDataGridView();
                        MessageBox.Show("Xoá Sinh Viên Thành Công");
                    }
                }
            }
        }
    }
}
