using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1.Module
{
    public class StudentMangement 
    {
        private List<Student> _students = new List<Student>();
       
        public void AddStudent(Student student)
        {
            _students.Add(student);
        }
        public List<Student> GetAllStudents() => _students;
        

        public Student? GetStudentById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public decimal GetAverageScore(Student student)
        {
            return (student.Score1 + student.Score2 + student.Score3) / 3;
        }

        public List<Student> GetStudentByGrades(char grade)
        {
            return _students.Where(s =>s.Grade == grade).ToList();
        }

        public void DeleteStudent(int id)
        {
            var student = GetStudentById(id);
            if (student != null)
            {
                _students.Remove(student);
            }
        }

    }
}