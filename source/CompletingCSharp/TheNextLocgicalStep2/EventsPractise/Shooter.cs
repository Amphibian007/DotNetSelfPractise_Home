using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsPractise
{
    public class Shooter
    {
        private Random rng = new Random();
      //  public delegate void ShootingHandler(object sender, ShootsFiredEventArgs e);
        public event EventHandler<ShootsFiredEventArgs> ShootsFired;
        public string Name { get; set; } = "Dipto";
        public void OnShoot()
        {
            while (true)
            {
                if (rng.Next(0, 100) % 2 == 0)
                {
                    
                        ShootsFired?.Invoke(this, new ShootsFiredEventArgs(DateTime.Now));
                    

                }
                else
                {
                    Console.WriteLine("I missed it");
                }
                Thread.Sleep(500);
            }
        }
    }
}
