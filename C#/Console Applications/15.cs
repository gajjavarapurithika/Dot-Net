﻿using System;
int a, b;
System.Console.WriteLine("Enter a value:");
a = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Enter b value:");
b = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(" Values before swapping: a = " + a + " b = " + b);
a = a ^ b;
b = a ^ b;
a = a ^ b;
System.Console.WriteLine(" Values after swapping: a = " + a + " b = " + b);
