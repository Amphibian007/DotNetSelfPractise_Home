using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsPractise
{
    class Program
    {
        static int score = 0;
        static void Main(string[] args)
        {
            Shooter shooter = new Shooter();
            shooter.ShootsFired += KilledEnemy;
            shooter.ShootsFired += AddScore;
            shooter.OnShoot();
        }
        public static void KilledEnemy(object sender,ShootsFiredEventArgs e)
        {
            var tempSender = sender as Shooter;
            Console.WriteLine($"I killed the enemy and my name is {tempSender.Name}");
            Console.WriteLine($"Time of the kill is {e.TimeOfKill}");
            Console.WriteLine($"Now the score is {score}");
        }
        public static void AddScore(object sender,EventArgs e)
        {
            score++;
        }
    }
  
}
