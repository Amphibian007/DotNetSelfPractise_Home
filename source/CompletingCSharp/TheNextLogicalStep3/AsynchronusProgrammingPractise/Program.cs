using System;
using System.Threading.Tasks;

namespace AsynchronusProgrammingPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 100000;
            var charToCon = 'a';
            Task<string> t = AddCharsAsync(charToCon, count);                   
            Console.WriteLine("Processing");
            Console.WriteLine(t.Result.Length);       
        }
        public static string AddChars(char charToCon,int count)
        {
            var finString = string.Empty;
            for(int i = 0; i < count; i++)
            {
                finString += charToCon;
            }
            return finString;
        }
        public async static Task<string>  AddCharsAsync(char charToAdd,int count)
        {
            return await Task<string>.Factory.StartNew(() =>
              {
                  return AddChars(charToAdd, count);
              });
           
        }
    }
    
}
