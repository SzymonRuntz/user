using System;

namespace Polymorphism
{
    class Program
    {
        // The word polymorphism means having many forms. 
        // In object-oriented programming paradigm, polymorphism is often expressed as 'one interface, multiple functions'.
        // Polymorphism can be static or dynamic. 
        // In static polymorphism, the response to a function is determined at the compile time. 
        // In dynamic polymorphism, it is decided at run-time.

        // Static Polymorphism
        // The mechanism of linking a function with an object during compile time is called early binding.
        // It is also called static binding. C# provides two techniques to implement static polymorphism. They are:
        //      -> Function overloading
        //      -> Operator overloading

        // Method Overloading
        // You can have multiple definitions for the same method name in the same scope.
        // The definition of the function must differ from each other by the types and/or the number of arguments 
        // in the argument list.You cannot overload function declarations that differ only by return type!
        // The following example shows using function add() to add different data types:
        public class Calc
        {
            public static int add(int a, int b)
            {
                return a + b;
            }

            // different from the first method by number of parameters
            public static int add(int a, int b, int c)
            {
                return a + b + c;
            }

            // different from the first method by types of parameters
            public static float add(float a, float b)
            {
                return a + b;
            }
        }

        // Dynamic Polymorphism - Method Overriding
        // If derived class defines same method as defined in its base class, it is known as method overriding in C#.
        // It is used to achieve runtime(dynamic) polymorphism. 
        // It enables you to provide specific implementation of the method which is already provided by its base class.

        // To perform method overriding in C#, you need to use 'virtual' keyword with base class method and 'override' keyword with derived class method.
        class Animal  // Base class (parent) 
        {
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig : Animal  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Animal  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }

        class Cat : Animal  // Derived class (child) 
        {
            public void animalSound()
            {
                Console.WriteLine("The cat says: meow meow");
            }
        }


        static void Main(string[] args)
        {
            // Static Polymorphism
            //Console.WriteLine(Calc.add(12, 23));
            //Console.WriteLine(Calc.add(12, 23, 25));
            //Console.WriteLine(Calc.add(12.4f, 21.3f));


            // Dynamic Polymorphism
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object
            Animal myCat = new Cat();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            myCat.animalSound();
        }
    }
}
