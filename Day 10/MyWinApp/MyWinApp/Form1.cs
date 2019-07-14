using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWinApp.Models;


namespace MyWinApp
{
    public partial class StudentUi : Form
    {
        string connectionString = @"Server=DESKTOP-MPA65J0\SQLEXPRESS; Database=StudentDB; Integrated Security=True";
        SqlConnection sqlConnection;

        private string commandString;
        private SqlCommand sqlCommand;
        private Student student;

        public StudentUi()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
            student = new Student();
        }

        private void LoadDistrict()
        {
            try
            {

                commandString = @"SELECT * FROM Districts";
                sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);



                districtComboBox.DataSource = dataTable;

                sqlConnection.Close();
                districtComboBox.Text = "Select district";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            student.RollNo = rollNotextBox.Text;
            student.Name = nameTextBox.Text;
            student.Age = Convert.ToInt32(ageTextBox.Text);
            student.Address = addressTextBox.Text;
            student.DistrictID= Convert.ToInt32(districtComboBox.SelectedValue);
            InsertStudent(student);

        }

        private void InsertStudent(Student student)
        {
            try
            {
                commandString = @"INSERT INTO Students (RollNo, Name, Age, Address, DistrictID) VALUES ('" + student.RollNo + "','" + student.Name + "'," + student.Age + ",'" + student.Address + "'," + student.DistrictID + ")";
                sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                int isExecuted;
                isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    MessageBox.Show("Saved Success");
                }
                else
                {
                    MessageBox.Show("Saved Failed");
                }

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void StudentUi_Load(object sender, EventArgs e)
        {

            LoadDistrict();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowStudents(student);
        }

        private void ShowStudents(Student student)
        {
            commandString = @"SELECT * FROM StudentsView";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
                displayDataGridView.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
