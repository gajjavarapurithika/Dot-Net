using System;
class Icecream
{
    public int price;
    public int quantity;
    public double wt;
    public string color;
    public void melt()
    {
        System.Console.WriteLine("It melts at room temperature");
    }
    public int billiamt()
    {
        return price * quantity;
    }
    public static void Main()
    {
        Icecream Buttersoch = new Icecream();
        Buttersoch.price = 50;
        Buttersoch.quantity = 2;
        Buttersoch.wt = 0.5;
        Buttersoch.color = "Yellow";
        System.Console.WriteLine("Price of Buttersoch is " + Buttersoch.price);
        System.Console.WriteLine("Quantity of Buttersoch is " + Buttersoch.quantity);
        System.Console.WriteLine("Weight of Buttersoch is " + Buttersoch.wt);
        System.Console.WriteLine("Color of Buttersoch is " + Buttersoch.color);
        Buttersoch.melt();
        System.Console.WriteLine("Total bill amount of Buttersoch is " + Buttersoch.billiamt());
        System.Console.WriteLine("=============================================");
        Icecream Chocolate = new Icecream();
        Chocolate.price = 40;
        Chocolate.quantity = 3;
        Chocolate.wt = 0.6;
        Chocolate.color = "Brown";
        System.Console.WriteLine("Price of Chocolate is " + Chocolate.price);
        System.Console.WriteLine("Quantity of Chocolate is " + Chocolate.quantity);
        System.Console.WriteLine("Weight of Chocolate is " + Chocolate.wt);
        System.Console.WriteLine("Color of Chocolate is " + Chocolate.color);
        Chocolate.melt();
        System.Console.WriteLine("Total bill amount of Chocolate is " + Chocolate.billiamt());
    }
}