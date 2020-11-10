using System;

namespace Inheritance
{
    // In C#, it is possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:
    // Derived Class(child) - the class that inherits from another class
    // Base Class(parent) - the class being inherited from
    // To inherit from a class, use the : symbol.
    public class Bike  // base class (parent) 
    {
        public Bike(string brand)
        {
            this.brand = brand;
            Console.WriteLine("Hello from Bike constructor!");
        }

        // TODO: Exercise 2
        // change access modificator to protected and check if it will be still accessed from derived class
        // do the same thing with private modificator
        public string brand = "Giant";  // Bike field

        public void Ride()             // Vehicle method 
        {
            Console.WriteLine("Wow, I'm riding!");
        }
    }

    public class Mtb : Bike  // derived class (child) which inherits from Bike class (parent)
    {
        public Mtb(string brand, string modelName): base(brand)
        {
            this.modelName = modelName;
            Console.WriteLine("Hello from Mtb constructor!");
        }

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

    // Each class can inherit only one base class
    public class Base1
    {

    }

    public class Base2
    {

    }

    // Uncomment to see the error
    //public class Derived : Base1, Base2
    //{

    //}

    // But you can inherit one after another
    public class Base3
    {
        public string PropertyFromBase3 { get; set; } = "This is property from base 3 class";
    }

    public class Base4: Base3
    {
        public string PropertyFromBase4 { get; set; } = "This is property from base 4 class";
    }

    // Derived2 class inherits Base4 class and indirectly Base3 class because Base4 class inherits Base3
    public class Derived2 : Base4
    {
        public void DisplayBaseClassProps()
        {
            Console.WriteLine($"Property from Base 3 class: {base.PropertyFromBase3}, and property from Base 4 class {base.PropertyFromBase4}");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Create a myMtb object
            Mtb myMtb = new Mtb("Merida", "ONE-TWENTY");

            // Call the Ride() method (From the Bike class) on the myMtb object
            myMtb.Ride();

            // Display the value of the brand field (from the Bike class) and the value of the modelName from the Mtb class
            Console.WriteLine(myMtb.brand + " " + myMtb.modelName);

            // TODO: Exercise 1
            // Create new object of Wheel and call method from a base class.

            var derived = new Derived2();
            derived.DisplayBaseClassProps();
        }
    }
}
