using System;

namespace DI_Practise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var workerbl1 = new WorkerBL(new WorkerDAL());

            var myAllWorkers = workerbl1.GetWorkers();

            foreach(var item in myAllWorkers)
                Console.WriteLine($"{item.Id} and {item.Name}");
        }
    }
}
