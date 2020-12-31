using System;
using System.Linq;

namespace InsideBook1
{
    class Program
    {
       
        public static void ModifyArray(int[] passedArray)
        {
            passedArray[0] = 7;
            PrintArray(passedArray);
            
        }
        public static void PrintArray(int[] passedArray)
        {
            Console.Write("[");
            if (passedArray.Length > 0)
            {
                Console.Write(passedArray[0]);
                for(int i = 1; i < passedArray.Length; i++)
                {
                    Console.Write(passedArray[i]);
                }
            }
            Console.WriteLine("]");
                
        }
        static void Main(string[] args)
        {
            int[] myArr = { 1, 2, 3 };
            Console.Write("Before passing the array");
            PrintArray(myArr);
            Console.WriteLine("After passing the array: ");
            ModifyArray(myArr);
            

        }
    }
}
