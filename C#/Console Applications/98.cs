using System;
class Mycalci
{
    int a;
    int b;
    public void mysum(int x, int y)
    {
        a = x;
        b = y;
        Console.WriteLine("Sum is : " + (a + b));
    }
    public static void Main()
    {
        Mycalci obj = new Mycalci();
        obj.mysum(10, 20);
    }
}