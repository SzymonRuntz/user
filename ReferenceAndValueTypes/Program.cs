namespace ReferenceAndValueTypes
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //Since no object can exist without a type, C# includes a "base" type
            System.Object myObject2 = new System.Object();
            object myObject3 = new object();

            //VALUE TYPES AND REFERENCE TYPES

            //C# supports both *value types* and *reference types*
            //Value types have their value passed along with their instance.
            //Each of these are value types:
            int seven = 7;
            char b = 'b';
            double onePointThree = 1.3;

            // value types inherits from System.ValueType which itself inherits
            // from System.Object

            // create new value type
            int number = 13;

            // copy value from 'number' to 'secondNumber'
            int secondNumber = number;

            // updates 'secondNumber' value
            secondNumber = secondNumber + 5;

            // here we pass 'number' as value
            int updatedNumber = Update(number);

            //Reference types contain a reference to a location on the memory heap
            //which has the actual instance. String is a reference type, 
            //as are classes and collections.
            string referenceType = "My Reference Type";
            Array[] myArray = new Array[5];
            MyClass myClass2 = new MyClass();

            // reference type inherits directly from System.Object
            var myClass = new MyClass();
            myClass.MyProp = "Initial value";

            // reference types holds only a reference to real object in variable
            // so here we copy the reference to 'myClass' object.
            // Now these two variables: 'mySecondClass' and 'myClass points to the
            // same object on a heap
            var mySecondClass = myClass;

            // Now we update value of 'MyProp' of object which 'mySecondClass' point to.
            // It is the same object which 'myClass' points to.
            mySecondClass.MyProp = "second user name";

            // So indirectly line above set MyProp of myClass with new value
            // 'myClassProp' = "second user name"
            var myClassProp = myClass.MyProp;

            // same is happening here, we pass myClass as a parameter,
            // but it is a reference type so we pass a reference only, not whole object.
            // every value changed on this argument will have affect on original object.
            var updatedUser = Update(myClass);

            //NULL

            //When using reference types, it is possible for there to not be a value
            //at the location referenced. When this happens, the value is said to be null.
            //When a reference type is instantiated, if not given a value, the value is null.

            string myNull; //Value is null
            MyClass myClass4; //Value is null

            //However, we cannot use var and assign the value to null.
            //Uncomment the below line to get a compilation error.
            //var myValue = null;
        }

        public static int Update(int someNumber)
        {
            return someNumber + 5;
        }

        public static MyClass Update(MyClass myClass)
        {
            myClass.MyProp = "different value";
            return myClass;
        }
    }
}
