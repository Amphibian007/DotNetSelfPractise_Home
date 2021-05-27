using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    public static class TestExtension
    {
        public static void OldEnough(this Employee e1,int age)
        {
            if(age>20)
                Console.WriteLine("Perfecly aged");
            else
                Console.WriteLine("He is underaged");
        }
        public static bool IsEven(this Int32 num)
        {
            return num % 2 == 0 ? true : false;
        }
        public static string ToProper(this string sentence)
        {
            string newSentence = "";
            if (sentence.Length > 0)
            {
                string[] values=sentence.ToLower().Split(' ');
                foreach(var word in values)
                {
                    char[] letters = word.ToCharArray();
                    letters[0] = char.ToUpper(letters[0]);
                    string newWord = new string(letters);
                    newSentence += newWord + " ";
                }
                return newSentence;
            }
            return sentence;
        }
        public static int  Factorial(this Int32 value)
        {
            if (value == 1)
                return 1;
            if (value == 2)
                return 2;
            else
            return value * Factorial(value - 1);
        }
    }
}
