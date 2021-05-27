using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronusProgrammingPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task(ConcatenateChars);
            t.Start();        
        }
        public static void ConcatenateChars()
        {
            var finalString = string.Empty;
            for(int i=0;i<10000;i++)
            {
                finalString += 'a';
            }
            Console.WriteLine(finalString);
        }
    }
}
