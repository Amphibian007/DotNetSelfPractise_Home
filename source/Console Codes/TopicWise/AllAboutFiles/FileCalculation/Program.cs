using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace FileCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"F:\Number.txt";
            string myText=File.ReadAllText(filePath);
            //string[] myList = myText.Split(' ');
            //foreach(var item in myList)
            //{
            //    Console.WriteLine(item);
            //}
            //int a = int.Parse(myList[0]);
            //int b = int.Parse(myList[1]);
            //int c = int.Parse(myList[2]);
            //int sum = a + b + c;
            //string sumFinal = $"{a}+{b}+{c}={sum}";
            //File.WriteAllText(filePath, sumFinal);
            string newText = myText.Replace("is", " ");
            File.WriteAllText(filePath, newText);

        }
    }
}
