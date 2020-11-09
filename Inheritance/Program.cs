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
        }
    }
}
