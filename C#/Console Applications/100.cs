using System;
class Mycalci
{
    int a;
    int b;
    public int mysum(int x, int y)
    {
        a = x;
        b = y;
        return a + b;
    }
    public static void Main()
    {
        Mycalci obj = new Mycalci();
        Console.WriteLine("Sum=" + obj.mysum(100, 150));
    }
}