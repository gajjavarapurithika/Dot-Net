using System;
class Rect
{
    public static int l = 20;
    public static int b = 30;
    public static int area()
    {
        return l * b;
    }
    public static void Main(String[] args)
    {
        Console.WriteLine("Area of rectangle is: " + Rect.area());
    }
}