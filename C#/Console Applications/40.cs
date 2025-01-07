using System;
using System.Xml.Linq;
int a, b, c, d, e;
System.Console.WriteLine("Enter a number");
a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter b number");
b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter c number");
c = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter d number");
d = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter e number");
e = Convert.ToInt32(Console.ReadLine());
int x = a;
if(b > x)
{
    x = b;
}
if (c > x)
{
    x = c;
}
if (d > x)
{
    x = d;
}
if (e > x)
{
    x = e;
}
System.Console.WriteLine("The largest number is " + x);