using System;

abstract class Bank
{
    public abstract void itrate();  // Abstract method to be implemented by subclasses
}

class SBI : Bank
{
    public override void itrate()  // Overriding the abstract method
    {
        Console.WriteLine("SBI bank Interest rate is 5");
    }
}

class HDFC : Bank
{
    public override void itrate()  // Overriding the abstract method
    {
        Console.WriteLine("HDFC bank Interest rate is 6");
    }

    public static void Main()
    {
        Bank b;

        // Creating instance of SBI and calling the method
        b = new SBI();
        b.itrate();

        // Creating instance of HDFC and calling the method
        b = new HDFC();
        b.itrate();
    }
}
