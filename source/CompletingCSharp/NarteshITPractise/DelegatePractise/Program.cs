using System;

namespace DelegatePractise
{
    public delegate void RectDelegate(int x, int y);
    class Program
    {
        public void GetArea(int x,int y)
        {
            Console.WriteLine($"The area is {x*y}");
        }
        public void GetPerimeter(int x,int y)
        {
            Console.WriteLine($"The perimeter is {2*(x+y)}");
        }
        static void Main(string[] args)
        {
            var genricDelegate = new GenericDelegate();
            Func<int,float,double,double> d1 = genricDelegate.AddNumbers1;
            var sum1= d1.Invoke(5, 10.5f, 60.4);
            Console.WriteLine(sum1);

            Action<int,float,double> d2 = genricDelegate.AddNumbers2;
            d2.Invoke(3, 5.6f, 20);

            Predicate<int> d3 = genricDelegate.IsEven;
            Console.WriteLine(d3.Invoke(5));
        }
    }
}
