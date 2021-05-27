using System;

namespace ExtensionMethodProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var ti1 = new TestItem();
            ti1.TestMethod3(5);
            int i = 5;
            Console.WriteLine(i.Factorial());
            Console.WriteLine(i.IsEven());
            string s = "Dipto Is aWeomsOme For aLL Time";
            Console.WriteLine(s.ToProperCase());
        }
    }
}
