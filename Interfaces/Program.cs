using System;

namespace Interfaces
{
    class Program
    {
        // Interfaces are special objects in C# that defines a set of related functionalities which may include methods, 
        // properties, and other members. Think of interfaces as a contract, one where classes that implement an interface 
        // agree to provide implementations for all objects defined by that interface.

        // Interfaces cannot contain any implementations, and their names are generally prefixed with "I" to distinguish them 
        // from other C# objects. We create interfaces using the interface keyword:
        public interface IAreaCalculator
        {
            double GetArea();
        }

        // Classes and structs can then implement an interface and define the behavior of the interface's methods:
        public class Circle : IAreaCalculator
        {
            public double Radius { get; set; }

            public double GetArea()
            {
                return Math.PI * (Radius * Radius);
            }
        }

        public class Rectangle : IAreaCalculator
        {
            public double Height { get; set; }
            public double Width { get; set; }

            public double GetArea()
            {
                return Height * Width;
            }
        }

        public class Triangle : IAreaCalculator
        {
            public double Height { get; set; }
            public double Width { get; set; }

            public double GetArea()
            {
                return Height * Width * 0.5;
            }
        }

        // Note that the implementing class must provide a definition for all methods defined on the interface. 
        // If it does not, we get a compilation error:
        public class Oval : IAreaCalculator
        {
            public double Radius1 { get; set; }
            public double Radius2 { get; set; }
        }

        static void Main(string[] args)
        {
            // Interfaces cannot be instantiated directly(we get a compilation error):
            var myAreaCalculator = new IAreaCalculator();

            // However, because of polymorphism, we can use interfaces as the type of a variable, and the resulting object 
            // will only have the members of the interface be usable:
            IAreaCalculator myCalc = new Circle()
            {
                Radius = 2
            };
            double area = myCalc.GetArea(); //12.566
        }

        // Interface Inheritance
        // Interfaces can inherit from one or more other interfaces:
        public interface IMovement
        {
            public void Move();
        }

        public interface IMakeSound
        {
            public void MakeSound();
        }

        public interface IAnimal : IMovement, IMakeSound
        {
            string SpeciesName { get; set; }
        }

        // Any class or struct which implements an interface must implement all methods and properties from any of that interface's 
        // inherited interfaces:
        public class Dog : IAnimal
        {
            public string SpeciesName { get; set; }

            public void MakeSound() //Defined in IMakeSound
            {
                Console.WriteLine("Bark!");
            }

            public void Move() //Defined in IMovement
            {
                Console.WriteLine("Running happily!");
            }
        }

        // Implementing Multiple Interfaces
        // Likewise, a single class can implement multiple interfaces, and must define behavior for all methods and properties 
        // from those interfaces:
        public interface IAnimal2
        {
            string SpeciesName { get; set; }
        }

        public class Cat : IMovement, IMakeSound, IAnimal2
        {
            public string SpeciesName { get; set; }

            public void MakeSound()
            {
                Console.WriteLine("Meow!");
            }

            public void Move()
            {
                Console.WriteLine("Walking gracefully");
            }

            // In short, interfaces allow us to define a set of properties and method definitions which any implementing classes 
            // must provide their own implementations for.

            // Abstract classes serve a slightly different purpose than interfaces. An abstract class is a "partially implemented" class 
            // which other classes can inherit from, but if they do, they must provide their own implementations for any method in the 
            // abstract class that is not already implemented.

            // Interfaces and Abstract class main differences:
            // 1. A single class may implement as many interfaces as they like.
            // 2. A single class may only inherit from one other class.
            // 3. In abstract class you can have some implementation when in interfaces you can not.
            // 4. Interfaces doesn't have constructors
        }
    }
}
