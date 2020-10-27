using System;
using System.Collections.Generic;
using System.Text;

namespace DI_Practise_3
{
    public class WorkerDAL : IShowWorkers
    {
        public List<Worker> ShowWorkers()
        {
            List<Worker> AllWorkers = new List<Worker>();
            AllWorkers.Add(new Worker { Id = 1, Name = "abc" });
            AllWorkers.Add(new Worker { Id = 2, Name = "xyz" });
            AllWorkers.Add(new Worker { Id = 3, Name = "efg" });

            return AllWorkers;
        }
    }
}
