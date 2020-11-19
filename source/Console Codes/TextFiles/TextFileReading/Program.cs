using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace TextFileReading
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"F:\Demo.txt";
            List<Person> myPersons = new List<Person>();
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (var line in lines)
            {

                string[] entries = line.Split(',');
                var newPerson = new Person();
                newPerson.Id = entries[0];
                newPerson.FirstName = entries[1];
                newPerson.LastName = entries[2];
                myPersons.Add(newPerson);

                Console.WriteLine("Read from text file");
                foreach (var person in myPersons)
                {
                    Console.WriteLine($"{person.Id} % {person.FirstName} {person.LastName}");
                }

                Console.WriteLine("Write in the text file");

                myPersons.Add(new Person { Id = "4", FirstName = "Prokash", LastName = "Das" });
                List<string> output = new List<string>();
                foreach (var item in myPersons)
                {
                    output.Add($"{item.Id},{item.FirstName},{item.LastName}");
                }
              

                File.WriteAllLines(filePath, output);
                Console.WriteLine("All files are written");
            }
        }
    }
}

