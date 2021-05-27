using System;
using System.IO;

namespace CastingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(new MemoryStream());
            Shape shape = new Text();
            Text text = (Text)shape;
           
        }
    }
}
