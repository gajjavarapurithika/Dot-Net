using System;
class Bird
{
    public int age;
    public int wings;
    public double wt;
    public string color;
    public void Fly()
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
        System.Console.WriteLine("Parrot age is: " + Parrot.age);
        System.Console.WriteLine("Parrot wings are: " + Parrot.wings);
        System.Console.WriteLine("Parrot weight is: " + Parrot.wt);
        System.Console.WriteLine("Parrot color is: " + Parrot.color);
        Parrot.Fly();
        Parrot.buildNest();
        System.Console.WriteLine("======================================");
        Bird Pigeon = new Bird();
        Pigeon.age = 3;
        Pigeon.wings = 2;
        Pigeon.wt = 2.5;
        Pigeon.color = "White";
        System.Console.WriteLine("Pigeon age is: " + Pigeon.age);
        System.Console.WriteLine("Pigeon wings are: " + Pigeon.wings);
        System.Console.WriteLine("Pigeon weight is: " + Pigeon.wt);
        System.Console.WriteLine("Pigeon color is: " + Pigeon.color);
        Pigeon.Fly();
        Pigeon.buildNest();
    }
}