using System;
int a, b;
System.Console.WriteLine("Enter a value:");
a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter b value:");
b = Convert.ToInt32(Console.ReadLine());
int t=(a>b) ? a : b;
System.Console.WriteLine(t+"is big");