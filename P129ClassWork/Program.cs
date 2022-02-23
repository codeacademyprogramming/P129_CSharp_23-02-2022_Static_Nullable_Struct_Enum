using P129ClassWork.Enums;
using P129ClassWork.Models;
using System;

namespace P129ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.FullName = "Test1";

            Employee employee2 = new Employee();
            employee2.FullName = "Test2";

            Employee employee3 = new Employee();
            employee3.FullName = "Test3";

            Employee employee4 = new Employee();
            employee4.FullName = "Test4";

            Console.WriteLine("Isci Novunu Sec");
            foreach (var item in Enum.GetValues(typeof(EmployeeType)))
            {
                Console.WriteLine($"{(int)item} {item}");
            }
            string str = Console.ReadLine();

            int num;

            while (!int.TryParse(str, out num) || num < 1|| num > 3)
            {
                Console.WriteLine("Duzgun Secim Et");
                str = Console.ReadLine();
            }

            EmployeeType employeeType = (EmployeeType)num;
            employee1.EmployeeType = employeeType;

            employee1.ShowInfo();
            employee2.ShowInfo();
            employee3.ShowInfo();
            employee4.ShowInfo();
        }
    }
}
