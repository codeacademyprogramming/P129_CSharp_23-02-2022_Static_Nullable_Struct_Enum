using P129HomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P129HomeWork.Models
{
    class User : IAccount
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        private string _password;
        public string Password {
            get => _password;
            set
            {
                while (!PasswordChecker(value))
                {
                    Console.WriteLine("Duzgunn Sifre Daxil Et");
                    value = Console.ReadLine();
                }
                _password = value;
            }
        }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public bool PasswordChecker(string password)
        {
            if (password.Length >= 8)
            {
                bool upperCase = false;
                bool lowerCase = false;
                bool digitCase = false;

                foreach (char item in password)
                {
                    if (char.IsLower(item))
                    {
                        lowerCase = true;
                    }
                    else if (char.IsUpper(item))
                    {
                        upperCase = true;
                    }
                    else if (char.IsDigit(item))
                    {
                        digitCase = true;
                    }

                    if (upperCase && lowerCase && digitCase)
                    {
                        return true;
                    }
                }

                if (!upperCase || !lowerCase || !digitCase)
                {
                    return false;
                }
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Full Name: {Fullname}\nEmail: {Email}");
        }
    }
}
