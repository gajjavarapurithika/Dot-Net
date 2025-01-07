using System;
double f, c;
Console.WriteLine("Enter the temperature in Fahrenheit: ");
f = Convert.ToDouble(Console.ReadLine());
c = (f - 32) * 5 / 9;
Console.WriteLine("The temperature in Celsius is: " + c);