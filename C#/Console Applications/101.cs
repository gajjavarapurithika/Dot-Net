using System;
class Icecream
{
    public int price;
    public int quantity;
    public double wt;
    public string color;
    public void melt()
    {
        System.Console.WriteLine("It mels at room temperature");
    }
    public int billamt()
    {
        return price * quantity;
    }
    public static void Main()
    {
        Icecream Vanilla = new Icecream();
        Vanilla.price = 20;
        Vanilla.quantity = 500;
        Vanilla.wt = 45.5;
        Vanilla.color = "White";
        System.Console.WriteLine("Price of vanilla=" + Vanilla.price);
        System.Console.WriteLine("Quantity of vanilla=" + Vanilla.quantity);
        System.Console.WriteLine("Weight of vanilla=" + Vanilla.wt);
        System.Console.WriteLine("Color of vanilla=" + Vanilla.color);
        Vanilla.melt();
        System.Console.WriteLine("Bill amount of vanilla=" + Vanilla.billamt());

    }

}