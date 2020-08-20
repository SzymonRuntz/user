using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    public class ExampleOfStatic
    {
        public static int ExampleOfStaticField = 0;

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
