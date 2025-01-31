class A
{
    public void fofca()
    {
        System.Console.WriteLine("I am function of class a");
    }
}
class B:A
{
    public void fofcb()
    {
        System.Console.WriteLine("I am function of class b");
    }
    public static void Main()
    {
        B b = new B();
        b.fofca();
        b.fofcb();
    }
}