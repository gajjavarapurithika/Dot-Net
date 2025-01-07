using System;
double c, f;
Console.WriteLine("Enter the temperature in Celsius: ");
c = Convert.ToDouble(Console.ReadLine());
f = (c * (9 / 5)) + 32;
Console.WriteLine("The temperature in Fahrenheit is: " + f);