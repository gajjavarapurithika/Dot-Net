﻿using System;
int c, d, h;
double a;
Console.WriteLine("Enter the value of base 1");
c= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the value of base 2");
d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the value of height of trapezoid");
h = Convert.ToInt32(Console.ReadLine());
a = ((c + d) / 2) * h;
Console.WriteLine("The area of trapezoid is " + a);