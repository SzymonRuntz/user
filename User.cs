using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml;

namespace _1
{
    public class User
    {
        public static long SumOfAllLogInsAllUsers { get; set; } = 0;

        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public User(string name)
        {
            this.Name = name;
        }

        public void LogIn()
        {
            // logic for lig in user
            SumOfAllLogInsAllUsers++;
        }

        public void GetName(string name)
        {
            if (name == string.Empty)
            {
                throw new Exception("Użytkownik musi mieć nazwę");
            }

            Console.WriteLine($"Imię użytkownika to: {name}");
        }

        public void GetSurname(string surname)
        {
            if (surname == string.Empty)
            {
                throw new Exception("Użytkownik musi mieć nazwisko");
            }
            Console.WriteLine($"Nazwisko użytkownika to: {surname}");
        }

        public void SetPhoneNumber(string numberString)
        {
            try
            {
                long number = Convert.ToInt64(numberString);
                if (number <= 999999999 && number >= 100000000)
                {
                    numberString = long.Parse($"{numberString}").ToString();
                    Console.WriteLine($"Numer telefonu użytkownika: {numberString}");
                }
                else
                {
                    Console.WriteLine("Podaj poprawny numer telefonu");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Numer telefonu musi się składać z cyfr.");
            }
        }

        public void SetEmail(string email)
        {
            
            if (email == string.Empty)
            {
                throw new Exception("Podaj email");
            }
            if (!email.Contains("@"))
            {
                throw new Exception("Email musi zawierać '@'");
            }
            
            Console.WriteLine($"Email użytkownika to: {email}");
        }
    }


}


