using System;

namespace Inheritance
{
    // In C#, it is possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:
    // Derived Class(child) - the class that inherits from another class
    // Base Class(parent) - the class being inherited from
    // To inherit from a class, use the : symbol.
    public class Bike  // base class (parent) 
    {
        public string brand = "Giant";  // Bike field

        public void Ride()             // Vehicle method 
        {
            Console.WriteLine("Wow, I'm riding!");
        }
    }

    public class Mtb : Bike  // derived class (child) which inherits from Bike class (parent)
    {
        public string modelName = "Anthem";  // MTB field
    }

    // TODO: Exercise 1
    // Create the base class for Parts with 2 properties: Price and Name,
    // constructor to set those properties
    // and one method AddToBasket which will simply print to the console
    // "{Name} with cost: {Price} was added to the basket!"

    // TODO: Exercise 1
    // Create a derived class Wheels which will inherits from Parts and
    // add 2 new properties: Weight and Size

    // The sealed Keyword
    // If you don't want other classes to inherit from a class, use the sealed keyword:
    sealed class SealedBike
    {
        // declaring protected members in sealed class is the same as declaring it as private.
        protected string brand;
    }

    // If you try to access a sealed class, C# will generate an error:
    // Cannot inherit from sealed class 'SealedBike'
    // Uncomment below to see error.
    //public class FailedMtb : SealedBike
    //{

    //}

    public class Program
    {
        static void Main(string[] args)
        {
            // Create a myMtb object
            Mtb myMtb = new Mtb();

            // Call the Ride() method (From the Bike class) on the myMtb object
            myMtb.Ride();

            // Display the value of the brand field (from the Bike class) and the value of the modelName from the Mtb class
            Console.WriteLine(myMtb.brand + " " + myMtb.modelName);

            // TODO: Exercise 1
            // Create new object of Wheel and call method from a base class.
        }
    }
}
