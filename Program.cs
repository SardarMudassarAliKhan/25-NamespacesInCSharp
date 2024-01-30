using System;

// Define a namespace called MyNamespace
namespace MyNamespace
{
    // Define a class within the namespace
    public class MyClass
    {
        public void PrintMessage()
        {
            Console.WriteLine("Hello from MyNamespace!");
        }
    }
}

// Main program starts here
class Program
{
    static void Main()
    {
        // Creating an instance of MyClass from MyNamespace
        MyNamespace.MyClass myObject = new MyNamespace.MyClass();

        // Calling the method defined in MyClass
        myObject.PrintMessage();
    }
}
