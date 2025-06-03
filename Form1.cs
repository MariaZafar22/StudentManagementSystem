using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            // Initialize the DataGridView columns
            dgvStudents.Columns.Add("StudentID", "StudentID");
            dgvStudents.Columns.Add("FirstName", "First Name");
            dgvStudents.Columns.Add("LastName", "Last Name");
            dgvStudents.Columns.Add("LastName", "Last Name");
            dgvStudents.Columns.Add("LastName", "Last Name");
            dgvStudents.Columns.Add("Gender", "Gender");
            dgvStudents.Columns.Add("DOB", "DOB");
            dgvStudents.Columns.Add("Email", "Email");
            dgvStudents.Columns.Add("Phone", "Phone");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public class Student
        {
            public string StudentID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Gender { get; set; }
            public DateTime DOB { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Gender = IblGender.ToString(),
                DOB = dtPDOB.Value ,
                Email = IblEmail.Text,
                Phone = IblPhone.Text,
                StudentID = Guid.NewGuid().ToString()
            };

            students.Add(student);
            UpdateDataGridView();
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                int index = dgvStudents.SelectedRows[0].Index;
                students[index].FirstName = txtFirstName.Text;
                students[index].LastName = txtLastName.Text;
                students[index].Gender = IblGender.ToString();
                students[index].DOB = dtPDOB.Value;
                students[index].Email = IblEmail.Text;
                students[index].Phone = IblPhone.Text;

                UpdateDataGridView();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                int index = dgvStudents.SelectedRows[0].Index;
                students.RemoveAt(index);
                UpdateDataGridView();
            }
        }
        private void UpdateDataGridView()
        {
            dgvStudents.Rows.Clear();
            foreach (var student in students)
            {
                dgvStudents.Rows.Add(student.StudentID, student.FirstName, student.LastName, student.Gender, student.DOB.ToString("dd/MM/yyyy"), student.Email, student.Phone);
            }
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void IblLastName_Click(object sender, EventArgs e)
        {

        }

        private void dtPDOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
