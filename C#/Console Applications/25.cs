using System;
double f, k;
Console.WriteLine("Enter the Temperature in Fahrenheit: ");
f = Convert.ToDouble(Console.ReadLine());
k = (f - 32) * 5 / 9 + 273.15;
Console.WriteLine("The Temperature in Kelvin is: " + k);