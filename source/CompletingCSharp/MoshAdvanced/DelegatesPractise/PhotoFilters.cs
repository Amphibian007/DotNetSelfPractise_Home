using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesPractise
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Applying brightness..");
        }
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Appling contrast...");
        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resizing photo...");
        }
    }
}
