using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public class ExampleOfStatic
    {
        // Static
        // 1. Dotyczy klasy, a nie obiektu
        //    ExampleOfStatic.ExampleOfStaticField
        // 2. Jest współdzielony rpzez wszystkie obiekty
        public static int ExampleOfStaticField = 0;

        // Non static
        // 1. Dotyczy danego obiektu
        //  var static = new ExampleOfStatic();
        //  static.ExampleOfNonStaticField;
        public int ExampleOfNonStaticField = 0;

        public int GetStaticField()
        {
            return ExampleOfStaticField;
        }

        public void SetStaticField(int value)
        {
            ExampleOfStaticField = value;
        }

        public static void IncreaseStaticField()
        {
            // in static method you can't get or use static fields
            // ExampleOfObjectSpecificField
            ExampleOfStaticField++;
        }
    }
}
