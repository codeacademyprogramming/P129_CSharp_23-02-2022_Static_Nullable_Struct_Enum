using System;

namespace P129Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type type = typeof(WeekDay);

            //Console.WriteLine(type.Name);
            //Console.WriteLine(type.FullName);

            //foreach (var item in Enum.GetValues(typeof(WeekDay)))
            //{
            //    Console.WriteLine($"{(int)item} {item}");
            //}

            //string[] arr = Enum.GetNames(typeof(WeekDay));

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine($"{(int)WeekDay.Monday} {WeekDay.Monday}");

            Console.WriteLine("Randevu Gunu Sec. Reqemi Daxil Et");
            foreach (var item in Enum.GetValues(typeof(WeekDay)))
            {
                Console.WriteLine($"{(int)item} {item}");
            }

            string str = Console.ReadLine();
            int weekNum;
            while (!int.TryParse(str,out weekNum) || weekNum < 1 || weekNum > 7)
            {
                Console.WriteLine("Duzgun Reqem Daxil Et");
                str = Console.ReadLine();
            }

            Console.WriteLine($"{weekNum} - ci gun Secdiniz - {(WeekDay)weekNum}");

            //switch (weekNum)
            //{
            //    case 1:
            //        Console.WriteLine($"1-ci Gunu Secdiniz - {(WeekDay)weekNum}");
            //        break;
            //    case 2:
            //        Console.WriteLine($"2-ci Gunu Secdiniz - {(WeekDay)weekNum}");
            //        break;
            //    case 3:
            //        Console.WriteLine($"3-ci Gunu Secdiniz - {(WeekDay)weekNum}");
            //        break;
            //    case 4:
            //        Console.WriteLine($"4-ci Gunu Secdiniz - {(WeekDay)weekNum}");
            //        break;
            //    default:
            //        Console.WriteLine("Duzgun Secin");
            //        break;
            //}
        }
    }

    enum WeekDay
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thusrday,
        Friday,
        Saturday,
        Sunday
    }
}
