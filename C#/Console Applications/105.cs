class Myclaci
{
    public int a;
    public int b;
    public Myclaci(int x, int y)
    {
        a = x;
        b = y;
    }
    public void display()
    {
        Console.WriteLine("a=" + a +"\t"+ "b=" + b);
    }
    public int add()
    {
        return a + b;
    }
    public static void Main()
    {
        Myclaci obj = new Myclaci(10, 20);
        obj.display();
        Console.WriteLine("sum=" + obj.add());
    }
}