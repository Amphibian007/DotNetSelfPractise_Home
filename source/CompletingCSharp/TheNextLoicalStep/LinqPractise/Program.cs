using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] mix = { 1, "Dipto", new List<int> { 1, 2, 3, 4, 5 }, 2, 3, 4, 18, 'b', 'c', 'a',new List<int> { 10, 20, 30, 40, 50 } };
            List<List<int>> allListInt = mix.OfType<List<int>>().ToList();
            List<int> numbers = new List<int> { 4, 5, 6, 7, 8, 9 };
            numbers.ForEach(n => Console.WriteLine(n));
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public Gender Gender { get; set; }
        public Person(string name,int height,int weight, Gender gender)
        {
            Name = name;
            Height = height;
            Weight = weight;
            Gender = gender;
        }

    }
    public enum Gender
    {
        Male,
        Female
    }
}
