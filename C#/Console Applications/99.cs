using System;
class Mycalci
{
    int a, b;
    public int mysum()
    {
        return a + b;
    }
    public static void Main()
    {
        Mycalci obj = new Mycalci();
        obj.a = 10;
        obj.b = 20;
        Console.WriteLine("Sum is: " + obj.mysum());
    }
}