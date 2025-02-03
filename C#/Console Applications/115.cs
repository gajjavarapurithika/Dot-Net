class Myclaci
{
    public int a;
    public int b;
    public int c;
    public int mysum()
    {
        return a + b + c;
    }
    public int mysum(int x, int y)
    {
        a = x;
        b = y;
        return x + y;
    }
    public int mysum(int x, int y, int z)
    {
        a = x;
        b = y;
        c = z;
        return x + y + z;
    }
    public static void Main()
    {
        Myclaci MC = new Myclaci();
        MC.a = 10;
        MC.b = 20;
        MC.c = 30;
        System.Console.WriteLine("sum=" + MC.mysum());
        System.Console.WriteLine("Sum=" + MC.mysum(110, 210));
        System.Console.WriteLine("Sum=" + MC.mysum(130, 230, 330));
    }
}