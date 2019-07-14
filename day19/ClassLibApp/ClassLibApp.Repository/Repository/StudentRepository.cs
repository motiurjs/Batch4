using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibApp.Models.Models;


namespace ClassLibApp.Repository.Repository
{
    public class StudentRepository
    {
        public string AddStudent(Student student)
        {
            return "Id: " + student.ID + " Name: " + student.Name+"Roll No: "+student.RollNo+"Contact: "+student.Contact+"Email: "+student.Email;

        }

        public string EditStudent(Student student)
        {
            return "Id: " + student.ID + " Name: " + student.Name + "Roll No: " + student.RollNo + "Contact: " + student.Contact + "Email: " + student.Email;

        }

        public string DeleteStudent(Student student)
        {
            return "Id: " + student.ID + " Name: " + student.Name + "Roll No: " + student.RollNo + "Contact: " + student.Contact + "Email: " + student.Email;

        }
        public string SearchStudent(Student student)
        {
            return "Id: " + student.ID + " Name: " + student.Name + "Roll No: " + student.RollNo + "Contact: " + student.Contact + "Email: " + student.Email;

        }

    }
}
