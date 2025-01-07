using System;
int a, b;
System.Console.WriteLine("Enter a value:");
a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter b value:");
b= Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    System.Console.WriteLine("a is greater than b");
}
else if (b > a)
{
    System.Console.WriteLine("b is greater than a");
}
else if(a == b)
{
    System.Console.WriteLine("a and b are equal");
}
