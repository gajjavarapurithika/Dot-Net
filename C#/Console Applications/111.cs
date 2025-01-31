class A
{
    public void fofca()
    {
        System.Console.WriteLine("I am function of class A");
    }
}
class B : A
{
    public void fofcb()
    {
        System.Console.WriteLine("I am function of class B");
    }
}
class C : A 
{
    public void fofcc()
    {
        System.Console.WriteLine("I am function of class C");
    }
}
class D : A
{
    public void fofcd()
    {
        System.Console.WriteLine("I am function of class D");
    }
    public static void Main()
    {
        B objb = new B();
        objb.fofca();
        objb.fofcb();
        System.Console.WriteLine("===================================");
        C objc = new C();
        objc.fofca();
        objc.fofcc();
        System.Console.WriteLine("===================================");
        D objd = new D();
        objd.fofca();
        objd.fofcd();
    }
}