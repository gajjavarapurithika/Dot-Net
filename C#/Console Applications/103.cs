using System;
class Mycalci
{
    public int a;
    public int b;
    public void getVals()
    {
        System.Console.Write("Enter a:");
        a = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter b:");
        b = Convert.ToInt32(Console.ReadLine());
    }
    public void putVals()
    {
        System.Console.WriteLine("a = " + a);
        System.Console.WriteLine("b = " + b);
    }
    public int mysum()
    {
        return a + b;
    }
    public int mysub()
    {
        return a - b;
    }
    public int mymul()
    {
        return a * b;
    }
    public int mydiv()
    {
        return a / b;
    }
    public int mymod()
    {
        return a % b;
    }
    public static void Main()
    {
        Mycalci obj = new Mycalci();
        int x;
        obj.getVals();
        System.Console.WriteLine("--------------------");
        obj.putVals();
        System.Console.WriteLine("--------------------");
        System.Console.WriteLine("Simple calculator");
        System.Console.WriteLine("--------------------");
        System.Console.WriteLine("1.Add");
        System.Console.WriteLine("2.Sub");
        System.Console.WriteLine("3.Mul");
        System.Console.WriteLine("4.Div");
        System.Console.WriteLine("5.Mod");
        System.Console.WriteLine("--------------------");
        System.Console.WriteLine("Enter your choice:");
        x = Convert.ToInt32(Console.ReadLine());
        switch (x)
        {
            case 1:
                System.Console.WriteLine("Sum = " + obj.mysum());
                break;
            case 2:
                System.Console.WriteLine("Sub = " + obj.mysub());
                break;
            case 3:
                System.Console.WriteLine("Mul = " + obj.mymul());
                break;
            case 4:
                System.Console.WriteLine("Div = " + obj.mydiv());
                break;
            case 5:
                System.Console.WriteLine("Mod = " + obj.mymod());
                break;
            default:
                System.Console.WriteLine("Invalid choice");
                break;
        }
    }
}