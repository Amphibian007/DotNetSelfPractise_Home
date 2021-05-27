using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodPractise
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var nm = new AllNewMethods();
            Console.WriteLine(nm.AreEqual<string>("Dipto","Dipto"));
        }
        public static void Sort(this int[] arr)
        {
            var temp = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[i].CompareTo(arr[j])==0)
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
        public static T[] SelectionSort<T>(T[] myArr) where T:IComparable<T>
        {
            
            for(int i = 0; i < myArr.Length; i++)
            {
                for(int j = i + 1; j < myArr.Length; j++)
                {
                    if (myArr[i].CompareTo(myArr[j])>0)
                    {
                        T temp = myArr[j];
                        myArr[j] = myArr[i];
                        myArr[i] = temp;
                    }
                }
            }
            return myArr;
        }

    }
}
