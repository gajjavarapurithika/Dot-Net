using System;
class Myclaci
{
    public int a;
    public int b;
    public Myclaci()
    {
        a = 6;
        b = 2;
    }
    public void dispvals()
    {
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
    public int add()
    {
        return a + b;
    }
    public static void Main()
    {
        Myclaci obj = new Myclaci();
        obj.dispvals();
        Console.WriteLine("Sum = " + obj.add());
    }
}