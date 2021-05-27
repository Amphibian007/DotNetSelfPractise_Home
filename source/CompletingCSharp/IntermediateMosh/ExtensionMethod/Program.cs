using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var e1 = new Employee
            {
                Id = 1,
                Age = 25,
                Name = "Dipto"
            };
            var e2 = new Employee
            {
                Id=2,
                Age=18,
                Name="Pias"
            };
            e1.OldEnough(e1.Age);
            e2.OldEnough(e2.Age);
            int num = 5;
            Console.WriteLine(num.IsEven());
            string sentence = "This is a awesome for me";
            Console.WriteLine(sentence.ToProper());
            Console.WriteLine(num.Factorial()) ;
        }
    }
}
