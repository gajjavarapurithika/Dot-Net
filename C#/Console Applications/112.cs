using System;
interface A
{
    void greetone();
}
interface B
{
    void greettwo();
}
class C : A, B
{
    public void greetone()
    {
        Console.WriteLine("Hello from greetone");
    }
    public void greettwo()
    {
        Console.WriteLine("Hello from greettwo");
    }
    public static void Main()
    {
        C c = new C();
        c.greetone();
        c.greettwo();
    }
}