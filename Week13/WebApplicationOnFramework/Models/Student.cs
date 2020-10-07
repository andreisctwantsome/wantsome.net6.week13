using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationOnFramework.Models
{
    // 
    public class Student
    {
        public int StudentId { get; set; }

        [Required] 
        [EmailAddress] 
        public string StudentName { get; set; }

        [Range(10, 20)]
        public int Age { get; set; }
    }

    public class StudentManager
    {
        static List<Student> studentList = new List<Student>{
                new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                new Student() { StudentId = 6, StudentName = "Chris" , Age = 17 } ,
                new Student() { StudentId = 7, StudentName = "Rob" , Age = 19 }
            };

        public List<Student> GetAll()
        {
            return studentList;
        }

        public Student GetById(int id)
        {
            return studentList.FirstOrDefault(x => x.StudentId == id);
        }

        public void Add(Student student)
        {
            student.StudentId = GetMaxId();

            studentList.Add(student);
        }

        private int GetMaxId()
        {
            return studentList.Count + 1;
        }
    }
}