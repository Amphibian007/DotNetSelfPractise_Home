using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace TestFileReading3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"F:\Games.txt";
            List<Games> myGames = new List<Games>();
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach(var line in lines)
            {
                string[] value = line.Split(',');
                var game1 = new Games();
                game1.Name = value[0];
                game1.Type = value[1];
                game1.Popularity = value[2];
                myGames.Add(game1);
            }
            foreach(var game in myGames)
            {
                Console.WriteLine($"{game.Name},{game.Type} and {game.Popularity}");
            }
        }
    }
}
