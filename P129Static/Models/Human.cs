using System;
using System.Collections.Generic;
using System.Text;

namespace P129Static.Models
{
    static class Human
    {
        public static string Name;
        //public string SurName;

        public static int Age { get; set; }

        static Human()
        {
            Console.WriteLine("Static Constructor");
        }

        //public Human()
        //{
        //    Console.WriteLine("Non - Static Constructor");
        //}

        public static void StaticMethod()
        {
            Console.WriteLine($"Static Method: {Name}");
        }
    }
}
