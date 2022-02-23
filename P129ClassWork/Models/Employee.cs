using System;
using System.Collections.Generic;
using System.Text;
using P129ClassWork.Enums;

namespace P129ClassWork.Models
{
    class Employee
    {
        private static int _count = 100;

        public string FullName { get; set; }
        public int Age { get; set; }
        private readonly int _no;
        public EmployeeType EmployeeType { get; set; }

        public Employee(/*EmployeeType employeeType*/)
        {
            _count++;
            _no = _count;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{FullName} {_no} {EmployeeType}");
        }
    }
}
