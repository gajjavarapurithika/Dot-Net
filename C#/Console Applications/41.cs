using System;
int a, b, c;
Console.WriteLine("Enter the a value:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the b value:");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the c value:");
c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    Console.WriteLine("a is the largest number");
}
else if (b > a && b > c)
{
    Console.WriteLine("b is the largest number");
}
else
{
    Console.WriteLine("c is the largest number");
}