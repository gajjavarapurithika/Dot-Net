class Mycalci
{
    int a;
    int b;
    int c;
    public Mycalci()
    {
        a = 1;
        b = 2;
        c = 3;
    }
    public int musumone()
    {
        return a + b + c;
    }
    public Mycalci(int x, int y)
    {
        a = x;
        b = y;
    }
    public int musumtwo()
    {
        return a + b;
    }
    public Mycalci(int x, int y, int z)
    {
        a = x;
        b = y;
        c = z;
    }
    public int musumthree()
    {
        return a + b + c;
    }
    public static void Main()
    {
        Mycalci MC1 = new Mycalci();
        Mycalci MC2 = new Mycalci(10, 20);
        Mycalci MC3 = new Mycalci(10, 20, 30);
        System.Console.WriteLine("Sum" + MC1.musumone());
        System.Console.WriteLine("Sum" + MC2.musumtwo());
        System.Console.WriteLine("sum=" + MC3.musumthree());
    }
}