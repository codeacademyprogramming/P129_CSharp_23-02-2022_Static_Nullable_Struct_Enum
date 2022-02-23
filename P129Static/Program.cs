using P129Static.Models;
using System;
using P129Static.Extentions;

namespace P129Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Step1");
            ////Human human = new Human();
            //Console.WriteLine("Step1");
            //Console.WriteLine("Step2");
            ////Human human1 = new Human();
            //Console.WriteLine("Step2");
            //Console.WriteLine("Step3");
            ////Human human2 = new Human();
            //Console.WriteLine("Step3");
            //Console.WriteLine("Step4");
            ////Human human3 = new Human();
            //Console.WriteLine("Step4");


            //Human.Name = "hamid";
            //Human.Name = "Hamid";

            //Human.Age = 30;

            //Human.Age = 31;

            //Console.WriteLine($"{Human.Name} {Human.Age}");

            //Human.StaticMethod();


            //string str = "Test";

            //str.CheckStr('a');

            //int a = 75;

            //Console.WriteLine(a.CheckInt());
            //Console.WriteLine(a.CheckInt(5));

            //Nullable Value Type
            byte? a = null;//0-255+null
            byte b = 0;

            Console.WriteLine("Deyer Daxil Et");
            string str = Console.ReadLine();

            int? test;

            if (string.IsNullOrWhiteSpace(str))
            {
                 test = null;
            }
            else
            {
                test = int.Parse(str);
            }

            if (test == null)
            {
                Console.WriteLine("Test Deyeri Null-dir");
            }
            else
            {
                Console.WriteLine("Nul Deyil");
            }

            
        }


    }
}