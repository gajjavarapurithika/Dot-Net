class A
{
    public void fofca()
    {
        System.Console.WriteLine("I am function of class a");
    }
}
class B : A
{
    public void fofcb()
    {
        System.Console.WriteLine("I am function of class b");
    }
}
class C : B
{
    public void fofcc()
    {
        System.Console.WriteLine("I am function of class c");
    }
    public static void Main()
    {
        B b = new B();
        b.fofca();
        b.fofcb();
        System.Console.WriteLine("===================================");
        C c = new C();
        c.fofca();
        c.fofcb();
        c.fofcc();
    }

}