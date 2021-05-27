using System;

namespace DelegatesPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var photoFilters = new PhotoFilters();
            Action<Photo> filterHandler = photoFilters.ApplyBrightness;
            filterHandler += photoFilters.ApplyContrast;
            filterHandler += RemoveBlueEye;
            processor.Process("photo.jpg", filterHandler);           
        }
        public static void RemoveBlueEye(Photo photo)
        {
            Console.WriteLine("Removing blue eye");
        }
    }
}
