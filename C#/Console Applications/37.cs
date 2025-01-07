using System;
int a, b;
Console.WriteLine("Enter a number");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b number");
b = Convert.ToInt32(Console.ReadLine());
if(a> b)
{
    Console.WriteLine("a is greater than b");
}
else if (a < b)
{
    Console.WriteLine("a is less than b");
}
else
{
    Console.WriteLine("a is equal to b");
}