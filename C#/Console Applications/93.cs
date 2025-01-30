using System;
class Bird
{
    public void fly()
    {
        System.Console.WriteLine("They fly to fulfill natural activites");
    }
    public void buildNest()
    {
        System.Console.WriteLine("They build nest to live");
    }
    public static void Main()
    {
        Bird Parrot=new Bird();
        Parrot.fly();
        Parrot.buildNest();
    }
}