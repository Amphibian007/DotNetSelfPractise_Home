using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesPractise
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }
        public void Save()
        {
            Console.WriteLine("Photo saved");
        }
    }
}
