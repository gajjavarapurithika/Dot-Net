using System;
int b, h, a;
System.Console.Write("Enter Breadth of triangle:");
b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter Height of triangle:");
h = Convert.ToInt32(Console.ReadLine());
a = (b * h) / 2;
System.Console.WriteLine("Area of triangle is:" + a);