using System;
using System.Collections.Generic;
using System.Text;

namespace P129Static.Extentions
{
    static class Extention
    {
        public static void CheckStr(this string st, char letter)
        {
            Console.WriteLine("Isledi");
        }

        public static bool CheckInt(this int a)
        {
            return a % 2 == 0;
        }

        public static bool CheckInt(this int a, int b)
        {
            return a % b == 0;
        }
    }
}
