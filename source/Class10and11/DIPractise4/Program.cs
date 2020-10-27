using System;

namespace DIPractise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerBL1 = new PlayerBL(new PlayerDAL());
            var myAllPlayers = playerBL1.GetPlayers();

            foreach (var item in myAllPlayers)
                Console.WriteLine($"{item.Id} and {item.Description}");
        }
    }
}
