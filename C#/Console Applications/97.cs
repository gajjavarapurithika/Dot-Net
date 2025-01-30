using System;
class Mycalci
{
    int a;
    int b;
    public void mysum()
    {
        System.Console.WriteLine("Sum=" + (a + b));
    }
    public static void Main()
    {
        Mycalci obj = new Mycalci();
        obj.a = 10;
        obj.b = 20;
        obj.mysum();
    }

}