using System;
int x;
System.Console.Write("Enter a number: ");
x=Convert.ToInt32(Console.ReadLine());
if (x >= 0)
{
    if(x == 0)
    {
        Console.WriteLine("Zero");
    }
    else
    {
        Console.WriteLine("Positive");
    }
}
else
{
    Console.WriteLine("Negative");
}