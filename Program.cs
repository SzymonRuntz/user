using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;

namespace _1
{
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            #region Collections
            var bike = new Bike();

            var pawel = new User("Paweł");
            var piotr = new User("Piotr");

            bike.Name = "My bike";
            bike.Size = 12;
            bike.WheelSize = 26;

            var fancyBike = new Bike()
            {
                Name = "Fancy bike",
                Size = 12,
                WheelSize = 26
            };

            // Collection types:
            // Array - fixed size
            var array = new Bike[]
            {
                new Bike(), // index = 0
                new Bike(), // index = 1
            };

            // Not alllowed - Index out of range exception
            //array[2] = new Bike();

            var firstArrayElement = array[0];

            // List - dynamic size
            var list = new List<Bike>
            {
                new Bike(),
                new Bike()
            };

            // this is valid 
            list.Add(new Bike());

            var secondListElement = list[1];

            // Dictionary - (key -> value)

            var dictionary = new Dictionary<string, string>()
            {
                { "trzeci", "Robert"},
                { "piąty", "Piotr"}
            };

            dictionary.Add("pierwszy", "Michał");

            // you cannot add duplicate key to dictionary
            //dictionary.Add("trzeci", "Bartosz");

            var dictonaryElementForKeyEqualTrzeci = dictionary["trzeci"];

            // Zadanko dla Szymona:
            // 
            // 1. Dodanie property do user o typie List<?> - np. rowerów
            // 2. Stwórz w klasie Program zmienna o typie Dictionary<User, Bike> 
            #endregion

            #region Static

            // You have to create object to invoke this method
            // from object you can invoke only non static methods
            var exampleObject1 = new ExampleOfStatic();
            exampleObject1.GetStaticField();

            Console.WriteLine($"First time: {ExampleOfStatic.ExampleOfStaticField}"); // 0

            // you don't have to create object to invoke static method
            // from class you can invoke only static methods
            ExampleOfStatic.IncreaseStaticField(); // static field = 1


            var exampleObject2 = new ExampleOfStatic();

            // set 1 for non static field for object 1
            exampleObject1.ExampleOfNonStaticField = 1;

            // set 2 for non static field for object 2
            exampleObject2.ExampleOfNonStaticField = 2;

            ExampleOfStatic.IncreaseStaticField(); // static field = 2
            ExampleOfStatic.IncreaseStaticField(); // static field = 3
            ExampleOfStatic.IncreaseStaticField(); // static field = 4

            Console.WriteLine($"Static field in object 1: {exampleObject1.GetStaticField()}"); // 0
            Console.WriteLine($"Static field in object 2: {exampleObject2.GetStaticField()}"); // 0

            Console.WriteLine($"Non static field in object 1: {exampleObject1.ExampleOfNonStaticField}"); // 1
            Console.WriteLine($"Non static field in object 2: {exampleObject2.ExampleOfNonStaticField}"); // 2

            exampleObject1.SetStaticField(25);
            exampleObject2.SetStaticField(14);

            Console.WriteLine($"Static field in object 1: {exampleObject1.GetStaticField()}"); // 4
            Console.WriteLine($"Static field in object 2: {exampleObject2.GetStaticField()}"); // 4


            var user1 = new User("Paweł");
            var user2 = new User("Bogdan");
            var user3 = new User("jarosław");
            var user4 = new User("Zdzisław");

            user1.LogIn();
            user2.LogIn();
            user3.LogIn();
            user4.LogIn();
            user1.LogIn();
            user4.LogIn();
            user1.LogIn();
            user2.LogIn();
            user1.LogIn();
            user3.LogIn();

            Console.WriteLine("Sum of all suer log ins: " + User.SumOfAllLogInsAllUsers);

            var rectangle = new Rectangle(5);
            var result = rectangle.CalculateSquare();
            Console.WriteLine($"Result of non static(object) method: {result}");

            result = Rectangle.CalculateSquare(4);
            Console.WriteLine($"Result of static method invocation: {result}");
            #endregion

            #region AnonymousTypes

            var kross = new Bike();
            var result2 = new
            {
                Size_a = 15,
                Calculate = 125
            };

            var bikeList = new List<Bike>
            {
                new Bike
                {
                    Name = "Kross",
                    Size = 15,
                    WheelSize = 26
                },
                new Bike
                {
                    Name = "Merida",
                    Size = 15,
                    WheelSize = 26
                },
                new Bike
                {
                    Name = "Kross",
                    Size = 18,
                    WheelSize = 26
                },
            };

            var listOfBikesSizes = bikeList.Select(x => new { x.Size });
            #endregion
        }
    }
}
