using Activity2;
using System;

namespace Activity2
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public void FullName(string Student)
        {
            Console.WriteLine($"{Student}: FullName!!!");
        }
    }
}

class Progress
{
    static void Main(string[] args)
    {
        List<Student> list = new List<Student>();

        while (true)
        {
            Console.WriteLine("Enter info: [A/B]");

            if (Console.ReadLine() == "B")
            {
                break;
            }

            Student stud = new Student();

            Console.WriteLine("Enter FirstName:  ");
            stud.FirstName = Console.ReadLine();

            Console.WriteLine("Enter LastName:  ");
            stud.LastName = Console.ReadLine();

            Console.WriteLine("Enter MiddleName: ");
            stud.MiddleName = Console.ReadLine();

            list.Add(stud);
        }

        list.ForEach(x =>
        {
            Console.WriteLine(x.FirstName);
            Console.WriteLine(x.LastName);
            Console.WriteLine(x.MiddleName);
            Console.WriteLine("=====================");
        });

    }
}