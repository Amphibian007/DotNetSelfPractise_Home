using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };
            var groupResult = arr1.GroupBy(g => g.EndsWith("frt"));
            foreach(var group in groupResult)
            {
                Console.WriteLine(group.Count());
            }
            
        }
        public static IEnumerable<string> CapitalWord(string sentence)
        {
            var words = sentence.Split(" ");
            var filteredWords = words.Where(w => w == w.ToUpper());
            return filteredWords;
        }
        
      
    }
}
