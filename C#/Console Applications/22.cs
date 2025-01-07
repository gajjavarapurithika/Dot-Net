using System;
int h;
double r,a;
Console.WriteLine("Enter the radius of the cone: ");
r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the height of the cone: ");
h = Convert.ToInt32(Console.ReadLine());
a= (1.0 / 3) * Math.PI * r * r * h;
Console.WriteLine("The volume of the cone is: " + a);