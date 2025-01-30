using System;
class Bird
{
    public int age;
    public int wings;
    public double wt;
    public string color;
    public void fly()
    {
        Console.WriteLine("They fly to fulfill natural activites");
    }
    public void buildNest()
    {
        Console.WriteLine("They build nest to live");
    }
    public static void Main()
    {
        Bird Parrot = new Bird();
        Parrot.age = 2;
        Parrot.wings = 2;
        Parrot.wt = 1.5;
        Parrot.color = "Green";
        Console.WriteLine("Parrot age is " + Parrot.age);
        Console.WriteLine("Parrot wings are " + Parrot.wings);
        Console.WriteLine("Parrot weight is " + Parrot.wt);
        Console.WriteLine("Parrot color is " + Parrot.color);
        Parrot.fly();
        Parrot.buildNest();
    }
}