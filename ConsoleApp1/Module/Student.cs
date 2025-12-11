using ConsoleApp1.Module;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace ConsoleApp1.Module
{
    public class Student
    {
        private static int _counter = 1;
        private string _name;
        public  int Id;
        private int _age;
        private decimal _score1;
        private decimal _score2;
        private decimal _score3;
        private char _grade;
        private string _subject;

        public string Name
        {
            get => _name;

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("name can not be empty");
                _name = value;
            }
        }
        public int Age
        {
            get => _age;
            set
            {
                if (value < 12)
                {
                    throw new Exception("age can not be less than 12");
                }
                _age = value;
            }

        }

        public decimal Score1
        {
            get => _score1;
            set
            {
                if (value < 0 && value > 100)
                    throw new Exception("Score must be between 0 and 100");
                _score1 = value;
            }
        }
        public decimal Score2
        {
            get => _score2;
            set
            {
                if (value < 0 && value > 100)
                    throw new Exception("Score must be between 0 and 100");
                _score2 = value;
            }

        }
        public decimal Score3
        {
            get => _score3;
            set
            {
                if (value < 0 && value > 100)
                    throw new Exception("Score must be between 0 and 100");
                _score3 = value;
            }
        }

        public decimal TotalScore
        {
            get => Score1 + Score2 + Score3;
        }
        public decimal Average
        {
            get => TotalScore / 3;
        }

        public char Grade
        {
            get

            {
                if (Average >= 90) return 'A';
                if (Average >= 80) return 'B';
                if (Average >= 70) return 'C';
                if (Average >= 60) return 'D';
                return 'F';
            }
        }




        public string Subjects
        {
            get => _subject;
            set
            {
                if (value.ToLower() == "c#_basics" || value.ToLower() == "OOP" || value.ToLower() == "LINQ")
                    _subject = value;
            }        
        }
    
        public Student(string name, int age, decimal score1, decimal score2, decimal score3, string subjects)
        {
            Name = name;
            Id =_counter++;
            Age = age;
            Score1 = score1;
            Score2 = score2;
            Score3 = score3;
            Subjects = subjects;
        }

        public override string ToString()
        {
            return $"Student Name: {Name}, ID: {Id}, Age: {Age}, Score: {TotalScore}, Grade: {Grade}, Subject: {Subjects}";  
        }
    }
}

