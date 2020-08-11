using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Pierwszy");


            user.GetName("Adam");
            user.GetSurname("Kowalski");
            user.SetPhoneNumber("123123123");
            user.SetEmail("|ghjghj");
        }
    }
}
