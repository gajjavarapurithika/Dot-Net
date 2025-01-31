using System;
class Rect
{
    public int l;
    public int b;
    public int area()
    {
        return l * b;
    }
    public static void Main()
    {
        Rect r = new Rect();
        r.l = 10;
        r.b = 10;
        Console.WriteLine("Area of rectangle is " + r.area());
    }
}