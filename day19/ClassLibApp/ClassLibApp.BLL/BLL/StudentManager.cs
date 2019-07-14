using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibApp.Models.Models;
using ClassLibApp.Repository.Repository;


namespace ClassLibApp.BLL.BLL
{
    public class StudentManager
    {
        Student student = new Student();
        StudentRepository _studentRepository = new StudentRepository();
        public string AddStudent(Student student)
        {
            return _studentRepository.AddStudent(student);
        }

        public string EditStudent(Student student)
        {
            return _studentRepository.EditStudent(student);
        }

        public string DeleteStudent(Student student)
        {
            return _studentRepository.DeleteStudent(student);
        }

        public string SearchStudent(Student student)
        {
            return _studentRepository.SearchStudent(student);
        }

    }
}
