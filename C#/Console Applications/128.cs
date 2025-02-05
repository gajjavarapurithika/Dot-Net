using System;

// Declare a delegate type
delegate void greets();

class Test
{
    // Instance method
    public void greetone()
    {
        System.Console.WriteLine("I am a function");
    }

    public static void Main()
    {
        // Create an instance of the Test class
        Test testInstance = new Test();

        // Create a delegate instance and point it to the greetone method
        greets g = new greets(testInstance.greetone);

        // Call the delegate
        g();
    }
}
