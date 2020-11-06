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
            Console.WriteLine("Value types");
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
            Console.WriteLine($"number= {number}");


            // updates 'secondNumber' value
            secondNumber = secondNumber + 5;   //13 = 13+5
            

            // here we pass 'number' as value

            int firstUpdate = Update(number);  // first update number to 18
            Console.WriteLine($"After first update= {firstUpdate}");
            
            int secondUpdate = Update(firstUpdate); // second update number (18) to 23
            Console.WriteLine($"After second update= {secondUpdate}");

            //value type = easy
            //myślę, że to rozumiem bo jest logiczne wszystko. (tak jak całe programowanie podobno :P) 


            //Reference types contain a reference to a location on the memory heap
            //which has the actual instance. String is a reference type, 
            //as are classes and collections.
            Console.WriteLine("Reference types");
            string referenceType = "My Reference Type";
            Array[] myArray = new Array[5];
            MyClass myClass2 = new MyClass();
            //czyli działa to jeszcze na tablice itd. bede musiał to ogarnąć z tablicami (nigdy za nimi nie przepadałem..)



            // reference type inherits directly from System.Object
            var myClass = new MyClass();
            myClass.MyProp = "Initial value";
            //nie łapie do końca {get}; {set};
            //często się z tym spotykałem bo "to musi był" ale dlaczego ? Oto jest pytanie
            Console.WriteLine($"myClass.MyProp = {myClass.MyProp}  <- to jest oczywiste");
            // reference types holds only a reference to real object in variable
            // so here we copy the reference to 'myClass' object.
            // Now these two variables: 'mySecondClass' and 'myClass points to the
            // same object on a heap
            var mySecondClass = myClass; 
            // przypisuje "Initial value" do mySecondClass = "Initial value" ?
            // chyba nie, bo nie przypisuje Propertki tylko tak jakby sam obiekt, który jest tym samym co myClass.

            // Now we update value of 'MyProp' of object which 'mySecondClass' point to.
            // It is the same object which 'myClass' points to.
            mySecondClass.MyProp = "second user name";
            Console.WriteLine($"myClass.MyProp = {myClass.MyProp} and mySecendClass.MyProp = {mySecondClass.MyProp}");
            // So indirectly line above set MyProp of myClass with new value
            // 'myClassProp' = "second user name"
            var myClassProp = myClass.MyProp;
            // więc jeżeli mySecondClass = myClass to przypisana propertka do jednej zmienia wartość tej samej propertki ale w tamtej klasie.
            // tak jakby jedna propertka jest przypisana do wielu klass które się nią "dzielą" i dla każdej jest taka sama.
            // więc zmiana tej propertki w jednej klasie wpływa na zmianę tej propertki we wszystkich innych klasach które ją używają.

            // same is happening here, we pass myClass as a parameter,
            // but it is a reference type so we pass a reference only, not whole object.
            // every value changed on this argument will have affect on original object.

            var updatedUser = Update(myClass);  // nie możemy update zrobić na całej klasie tylko na propertce
            Console.WriteLine($"after updated myClass= {updatedUser.MyProp}"); // tutaj troszeczkę się gubię w tym momencie.
            //Czyli możemy zmienić wartość myClass??
            //przecież to jest to samo co zrobiliśmy wyżej tylko z wykorzystaniem metody Update <- tak ??
            //robimy update myClass i automatycznie mySecondClass, łapie, bo referencyjna wartość.
            //A nie podajemy properyki bo jest na nią wskazanie bezprośrednio w metodzie.
            Console.WriteLine($"myClass = {myClass.MyProp}");
            Console.WriteLine($"mySecondClass = {mySecondClass.MyProp}");


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
