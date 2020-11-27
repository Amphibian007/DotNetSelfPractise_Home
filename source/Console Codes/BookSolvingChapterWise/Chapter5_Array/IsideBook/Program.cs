using System;

namespace IsideBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int length = arr1.Length;
            //int[] arr2 = new int[5];
            //for(int i = 0; i < length; i++)
            //{
            //    arr2[length - 1 - i] = arr1[i];
            //}
            //foreach(var item in arr2)
            //    Console.WriteLine(item);
            //int[] inputArray = new int[5];
            //for(int i = 0; i < inputArray.Length; i++)
            //{
            //    inputArray[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine(checkSymmetric(inputArray));
            int[,] myMatrix = new int[3, 2];
            for(int row = 0; row < 3; row++)
            {
                for(int col = 0; col < 2; col++)
                {
                    myMatrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            ShowMatrix(myMatrix);
        }
        //static bool checkSymmetric(int[] myArr)
        //{
        //    int count = 0;
        //    int length = myArr.Length;
        //    for (int start = 0, end = length - 1; start <= end; start++, end--)
        //    {
        //        if (myArr[start] == myArr[end])
        //            count++;
        //    }
        //   return count < (length / 2) ? false : true;
        //}
        static void ShowMatrix(int[,] myMatrix)
        {
            for(int row = 0; row < 3; row++)
            {
                for(int col = 0; col < 2; col++)
                {
                    Console.Write($"{myMatrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
