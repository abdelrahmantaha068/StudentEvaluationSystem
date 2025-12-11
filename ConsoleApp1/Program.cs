using ConsoleApp1.Module;
using ConsoleApp1.Repoets_Modules;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentMangement studentMangement = new StudentMangement();
            Report report = new Report();


            while (true)
            {
                Console.WriteLine("\n============ Student Evaluation System ==============");
                Console.WriteLine("1) Add Student");
                Console.WriteLine("2) List Student");
                Console.WriteLine("3) Delete Student");
                Console.WriteLine("4) Get Student By Grade");
                Console.WriteLine("5) Get Student By ID");
                Console.WriteLine("6) Ger Top Student By Grade");
                Console.WriteLine("0 Exit");
                Console.WriteLine("Choose: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Student Name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine($"Enter {name} Age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Enter Student Scores (comma separated): ");
                        decimal score1 = decimal.Parse(Console.ReadLine());
                        decimal score2 = decimal.Parse(Console.ReadLine());
                        decimal score3 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Student Subjects (c#_basics/OOP/LINQ): ");
                        string subjects = Console.ReadLine();
                        Student newStudent = new Student(name, age, score1, score2, score3, subjects);
                        studentMangement.AddStudent(newStudent);
                        Console.WriteLine("Student added successfully!");
                        break;
                    case "2":
                        var students = studentMangement.GetAllStudents();
                        foreach (var student in students)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    case "3":
                        Console.Write("Enter Student ID to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        studentMangement.DeleteStudent(deleteId);
                        Console.WriteLine("Student deleted successfully!");
                        break;
                    case "4":
                        Console.Write("Enter Grade to filter (A/B/C/D/F): ");
                        char grade = Console.ReadLine()[0];
                        var studentsByGrade = studentMangement.GetStudentByGrades(grade);
                        foreach (var student in studentsByGrade)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    case "5":
                        Console.Write("Enter Student ID to search: ");
                        int searchId = int.Parse(Console.ReadLine());
                        var studentById = studentMangement.GetStudentById(searchId);
                        if (studentById != null)
                        {
                            Console.WriteLine(studentById);
                        }
                        else
                        {
                            Console.WriteLine("Student not found!");
                        }
                        break;
                    case "6":
                        var topStudents = studentMangement.GetAllStudents();
                        foreach (var student in topStudents)
                        {
                            Console.WriteLine("Top 3:");
                        }
                        report.GetTopStudents(topStudents);
                        break;
                    case "0":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                }


            }
        }
    }
}
