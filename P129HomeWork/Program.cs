using P129HomeWork.Models;
using System;

namespace P129HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("hamidvm@code.edu.az", "567567");
            user.Fullname = "Hamid Mammadov";
            user.Password = "465a4sd6";
        }
    }
}
