using System;

namespace P129Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Area area = new Area();
            area.A = 7;
            area.B = 5;

            Console.WriteLine(area.Calculate());

            Area area1;
            area1.A = 7;
            //area1.B = 5;
            //area1.Calculate();
            Console.WriteLine(area1.A);

            Area area2 = new Area(5,8);
            Console.WriteLine(area2.Calculate());
        }
    }

    struct Area
    {
        public int A;
        public int B{ get; set; }

        public Area(int a, int b)
        {
            A = a;
            B = b;
        }

        public int Calculate()
        {
            return A * B;
        }
    }

    struct Area2 : Ites
    {

    }

    interface Ites
    {

    }
}
