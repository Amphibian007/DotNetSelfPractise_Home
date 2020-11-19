using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace TextFileReading4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"F:\Sports.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<Sports> mySports = new List<Sports>();
            foreach(var line in lines)
            {
                string[] value = line.Split(',');
                var sport1 = new Sports();
                sport1.Name = value[0];
                sport1.Player = value[1];
                sport1.Earning = value[2];

                mySports.Add(sport1);
            }

            Console.WriteLine("Read from text file");
            foreach(var sport in mySports)
            {
                Console.WriteLine($"{sport.Name},{sport.Player} and {sport.Earning}");
            }
            mySports.Add(new Sports { Name = "Hockey", Player = "adf", Earning = "Low" });
            List<string> output = new List<string>();
            foreach(var sport in mySports)
            {
                output.Add($"{sport.Name},{sport.Player},{sport.Earning}");
            }
            Console.WriteLine("Writing lines in the file");
            File.WriteAllLines(filePath, output);

        }
    }
}
