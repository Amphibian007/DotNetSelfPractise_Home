using System;

namespace IndexerPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            var e1 = new Employee(1, "Dipto", "Gazipur");
            Console.WriteLine(e1[0]);
            Console.WriteLine(e1[1]);
            Console.WriteLine(e1[2]);
            e1[0] = 2;
            e1[1] = "Pias";
            e1[2] = "Dhaka";
            Console.WriteLine(e1[0]);
            Console.WriteLine(e1[1]);
            Console.WriteLine(e1[2]);

        }
    }
}
