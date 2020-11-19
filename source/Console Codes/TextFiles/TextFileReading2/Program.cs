using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace TextFileReading2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileFath = @"F:\Test.txt";
            List<Student> students = new List<Student>();
            List<string> lines = File.ReadAllLines(fileFath).ToList();
            foreach(var line in lines)
            {
                string[] value = line.Split(',');
                var student1 = new Student();
                student1.FirstName = value[0];
                student1.LastName = value[1];
                student1.Email = value[2];
                students.Add(student1);
            }

            foreach(var student in students)
            {
                Console.WriteLine($"{student.FirstName},{student.LastName} and {student.Email}");
            }

            students.Add(new Student { FirstName = "Sujan", LastName = "Das", Email = "s@s.com" });
            List<string> show = new List<string>();
            foreach(var student in students)
            {
                show.Add($"{student.FirstName},{student.LastName} and {student.Email}");
            }
            File.WriteAllLines(fileFath, show);
        }
    }
}
