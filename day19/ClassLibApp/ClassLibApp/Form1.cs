using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibApp.BLL.BLL;
using ClassLibApp.Models.Models;

namespace ClassLibApp
{
    public partial class StudentUi : System.Windows.Forms.Form
    {
        private Student student;
        StudentManager _studentManager = new StudentManager();
        public StudentUi()
        {
            InitializeComponent();
            student = new Student();
            student.ID = 100;
            student.Name = "Ali";

            MessageBox.Show(_studentManager.AddStudent(student));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            student.ID = Convert.ToInt32(idTextBox.Text);
            student.Name = nameTextBox.Text;
            student.RollNo = rollTextBox.Text;
            student.Contact = contactTextBox.Text;
            student.Email = emailTextBox.Text;

            MessageBox.Show(_studentManager.AddStudent(student));

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
