using System;
class Bird
{
    public void fly()
    {
        System.Console.WriteLine("They fly to fulfill natural activites");
    }
    public static void Main()
    {
        Bird b = new Bird();
        b.fly();
        System.Console.WriteLine("----------------------");
        Bird Pigeon = new Bird();
        Pigeon.fly();
    }
}