using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodProject
{
    public static class TestItem2
    {
        public static void TestMethod3(this TestItem testItem,int i)
        {
            Console.WriteLine($"This is an extension method with the value {i}");
        }
        public static long Factorial(this Int32 num)
        {
            if (num == 1)
                return 1;
            if (num == 2)
                return 2;
            else
                return num * Factorial(num - 1);
        }
        public static bool IsEven(this Int32 num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }
        public static string ToProperCase(this String sentence)
        {
            if (sentence.Trim().Length > 0)
            {
                var newSentence = "";
                string[] words = sentence.ToLower().Split(' ');
                foreach(var word in words)
                {
                   char[] letters= word.ToCharArray();
                   letters[0] = Char.ToUpper(letters[0]);
                    if (sentence == null)
                        newSentence = new string(letters);
                    else
                        newSentence += new string(letters)+" ";
                }
                return newSentence;
            }
            return sentence;
        }
    }
}
