using System;
delegate void greets();
class test
{
    public static void greetone()
    {
        System.Console.WriteLine("I am a function");
    }
    public static void greettwo()
    {
        System.Console.WriteLine("I am also a function");
    }
    public static void Main()
    {
        greets g1 = new greets(greetone);
        greets g2= new greets(greettwo);
        greets g3 = g1 + g2;
        g3();
    }
}
