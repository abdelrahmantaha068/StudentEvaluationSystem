using ConsoleApp1.Module;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ConsoleApp1.Repoets_Modules
{
    public class Report
    {
        
       public void GetTopStudents (List<Student> students)
        {
            var topStudents = students.OrderByDescending(s => (s.Score1 + s.Score2 + s.Score3) / 3).Take(3);
            foreach(var student in topStudents)
            {
                Console.WriteLine(student);
            }
        }




    }
}