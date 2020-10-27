using System;
using System.Collections.Generic;
using System.Text;

namespace DI_Practise_3
{
    public class WorkerBL
    {
        public IShowWorkers IshowWorker1;

        public WorkerBL(IShowWorkers IshowWorker1)
        {
            this.IshowWorker1 = IshowWorker1;
        }

        public List<Worker> GetWorkers()
        {
            List<Worker> myWorkers = new List<Worker>();
            return IshowWorker1.ShowWorkers();
        }
        
        

    }
}
