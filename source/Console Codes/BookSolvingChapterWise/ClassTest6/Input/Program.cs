using System;
using System.Collections.Generic;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myInputList = new List<string>()
            {
             "Blackcurrant","Apple","Blackberries","Apricots","Banana","Breadfurit"
                    ,"Avocado","Blueberries","Banana2"
            };
           
            myInputList.Sort();
            foreach(var item in myInputList)
            {
                Console.WriteLine(item);
            }
            decimal length = myInputList.Count;
            Console.WriteLine("Length is "+length);
            decimal column = int.Parse(Console.ReadLine());
            decimal wordsPerLine = Math.Ceiling(length / column);
            Console.WriteLine(wordsPerLine);
            string[,] latestOutput = {
                { myInputList[0],myInputList[1],myInputList[2] },
                {myInputList[3], myInputList[4],myInputList[5] },
                {myInputList[6],myInputList[7],myInputList[8]}
                 };
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(latestOutput[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
