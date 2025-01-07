using System;
double r,v;
int h;
System.Console.Write("Enter the radius of the cylinder: ");
r = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Enter the height of the cylinder: ");
h = Convert.ToInt32(Console.ReadLine());
v = Math.PI * r * r * h;
System.Console.Write("The volume of the cylinder is: " + v);

