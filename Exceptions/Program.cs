using System;
using System.IO;

namespace Exceptions
{
    class Program
    {
        #region 1. Exceptions
        // An exception is an unexpected error that happens while a C# program is running. The C# runtime will transform an exception into
        // an instance of a class, and we can use that instance to try to debug why the error happened.

        // All instances of an exception in C# must inherit from the class System.Exception. When an exception is encountered while a program
        // is running, we say it has been thrown.

        // C# includes a huge variety of built-in exception classes. For example, if we attempt to divide by zero, an instance
        // of System.DivideByZeroException will be thrown.
        public static void ThrowsExcpetionExample()
        {
            int zero = 0;
            int two = 2;

            int result = two / zero; //Throws System.DivideByZeroException
        }
        #endregion

        # region 2. Understanding Exceptions
        // When an exception is thrown, the C# compiler will include information in that exception instance which is helpful when attempting 
        // to find out where the exception was thrown from. This includes:

        // => Stack Trace - The classes and methods that were called in order to execute the line of code that threw the exception.
        //    We use this to trace back and find out what kinds of arguments or method calls might have led to this exception being thrown.
        // => Error Message - A short message explaining what the exception was.
        // => Inner Exceptions - Exceptions can be wrapped in other exceptions. When this happens, the innermost exception (i.e.the exception that does not have any further inner exceptions) is often the most useful for debugging.

        // Handling Thrown Exceptions
        // If we have a block or line of code that we know might throw an exception at runtime, we can wrap it using the try keyword.
        // Any exception which is caught in the try block can then be processed in a corresponding catch block.

        // Execution of the code in the try block stops when an exception is encountered. In the above code, the method CallOtherMethod()
        // will never be invoked, because the line before it will always throw an exception.

        // The catch keyword allows us to handle thrown exceptions. "Handling" an exception can mean many things. For example, we might want 
        // to log that the exception occurred in an error-logging system, redirect the code execution to a different method or block, or some combination of the two.

        public static void LogsExcpetionExample()
        {
            try
            {
                var two = 2;
                var zero = 0;

                var result = two / zero; //Will throw DivideByZeroException

                CallOtherMethod(); //Never invoked
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured: {ex}");
            }
        }
        #endregion

        #region 3. Swallowing Exceptions
        // Choosing to do nothing with a caught exception is called "swallowing" the exception and is generally considered bad practice:

        // However, something being bad practice does not mean that we should never do it.It means we should try not to do it, or only do it 
        // in specific situations where we know and understand the risks or complications that might result.

        // In the case of swallowing exceptions, the primary risk is that errors might occur, and because they were swallowed, we will have 
        // no idea that they even happened.

        public static void SwallowsExcpetionExample()
        {
            try
            {
                var two = 2;
                var zero = 0;

                var result = two / zero; //Will throw DivideByZeroException

                CallOtherMethod(); //Never invoked
            }
            catch (Exception ex)
            {
                //Swallowing exceptions is a bad practice!
            }
        }
        #endregion

        #region 4. Multiple Catch Blocks
        // We can also catch specific kinds of exceptions and execute different code blocks for each.The most-specific exception needs 
        // to be listed first, and the least-specific goes last.
        public static void MultipleCatchBlocksExample()
        {
            try
            {
                //Code that might throw an exception
                //throw new DivideByZeroException();
                //throw new ArgumentException();
                //throw new Exception();
                //throw new NullReferenceException();
            }
            catch (DivideByZeroException ex)
            {
                //Handle the divide by zero situation
            }
            catch (ArgumentException ex)
            {
                //Handle the argument exception situation
            }
            catch (Exception ex)
            {
                //Handle all other exceptions
            }
        }
        #endregion

        #region 5. Finally Blocks
        // Before the execution of a try catch block ends, the C# compiler will check for the existence of a finally block. 
        // Code in a finally block will execute whether or not an exception is thrown.
        public static void FinallyBlockExample()
        {
            try
            {
                //Code that might throw an exception.
            }
            catch (Exception ex)
            {
                //Code that is only executed if an exception is thrown.
            }
            finally
            {
                //Code that is executed whether or not an exception is thrown.
            }
        }

        // A common situation in which we use a finally clause is to clean up our code. We might do that in situations where we are reading 
        // external files, so as not to cause a StackOverflowException or OutOfMemoryException.

        // In order to read a file from a local device, you must open a stream to the file.The stream remains open as long as we do not 
        // explicitly close it.We could use a finally block to close the stream whether or not an exception was thrown:

        // We would do similar things in situations where we are reading from a database or datastore.
        public static void ReadFromFile()
        {
            FileStream file = null;
            try
            {
                var fileInfo = new FileInfo("C:\\path\\to\\file.txt");

                file = fileInfo.OpenWrite();
                file.WriteByte(0xF);
            }
            catch (Exception e)
            {
                //Handle the exception
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (file != null)
                {
                    file.Close(); //Close the file stream
                }
            }
        }
        #endregion

        #region 6. Throwing Exceptions
        // We can also force the C# compiler to throw an exception using the throw keyword.

        // We commonly use this in situations where the program is now in an error state, and we need to stop execution before something 
        // worse happens. You might use this in if/else blocks or other decision statements.
        public static void ThrowingExceptionExample(bool someCondition)
        {
            if (someCondition)
            {
                //Normal condition
            }
            else //Error Condition
            {
                throw new Exception("Exception message goes here!");
            }
        }

        // One common scenario is to throw a NotImplementedException for methods that do not have their implementation written yet:

        // Note that the below method will not cause a compilation error, despite the fact that the method has a return type and is missing 
        // the return keyword.
        public static string NotImplementedMethod()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region 7. Custom Exceptions
        // We can also create our own custom exception classes, such as this one:

        // Custom exception classes must inherit from either System.Exception or another class which inherits from System.Exception.Then, 
        // because of polymorphism, an instance of our custom exception class can be treated as though it is of type System.Exception.

        public class CustomException : Exception
        {
            public CustomException(string message) { /*...*/ }
        }

        // We can then throw instances of our custom exception using the throw keyword:
        public static void CustomExceptionExample()
        {
            throw new CustomException("This is a message from custom excpetion!");
        }
        #endregion

        #region 8. Re-Throwing Exceptions
        // There may be situations in which our catch block has caught an exception, but needs to throw it so that some code block 
        // or try catch block elsewhere in the code can handle it.

        // There are two ways of doing this. The first is to simply use the throw keyword at the end of the catch block.
        public static void ReThrowWithStackTraceExample()
        {
            try
            {
                //Code that might throw an exception
                ThrowsExcpetionExample();
            }
            catch (Exception ex)
            {
                //Handle the exception
                throw;
            }
        }

        //Doing this preserves the original stack trace so that it can be viewed when the exception is caught and handled later.

        // You can also "re-throw" the exception variable:

        // However, if we do this, the stack trace is reset to start at this line of code; the stack trace that was originally
        // in the exception is lost. Therefore, we normally prefer the throw method over the throw ex method.
        public static void ReThrowAndResetStackTraceExample()
        {
            try
            {
                //Code that might throw an exception
                ThrowsExcpetionExample();
            }
            catch (Exception ex)
            {
                //Handle the exception
                throw ex; //This is different!
            }
        }
        #endregion

        static void Main(string[] args)
        {
            // 1. Excpetions
            ThrowsExcpetionExample();

            // 2. Understanding Exceptions
            //LogsExcpetionExample();

            // 3. Swallowing Exceptions
            //SwallowsExcpetionExample();

            // 4. Multiple Catch Blocks
            //MultipleCatchBlocksExample();

            // 5. Finally Blocks
            //ReadFromFile();

            // 6. Throwing Exceptions
            //ThrowingExceptionExample(someCondition: false);
            //NotImplementedMethod();

            // 7. Custom Exceptions
            //CustomExceptionExample();

            // 8. Re-Throwing Exceptions
            //ReThrowWithStackTraceExample();
            //ReThrowAndResetStackTraceExample();
        }

        private static void CallOtherMethod()
        {
            Console.WriteLine("Other method called");
        }
    }
}
