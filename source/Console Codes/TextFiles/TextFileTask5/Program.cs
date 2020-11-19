using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace TextFileTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"F:\Company.txt";
            List<Company> myCompanies = new List<Company>();
            List<string> Lines = File.ReadAllLines(filePath).ToList();
            foreach(var line in Lines)
            {
                string[] value = line.Split(',');
                var company1 = new Company();
                company1.Name = value[0];
                company1.Revenue = value[1];
                company1.situation = value[2];
                myCompanies.Add(company1);
               
            }
            foreach(var company in myCompanies)
            {
                Console.WriteLine($"{company.Name},{company.Revenue} and finally {company.situation}");
            }
            myCompanies.Add(new Company { Name = "Amazon", Revenue = "Best", situation = "America" });
            List<string> output = new List<string>();
            foreach(var company in myCompanies)
            {
                output.Add($"{company.Name}+{company.Revenue} and {company.situation}");
            }
            File.WriteAllLines(filePath, output);
        }
    }
}
