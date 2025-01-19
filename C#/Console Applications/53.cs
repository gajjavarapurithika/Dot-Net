using System;
int n,f = 1, i = 1;
System.Console.WriteLine("enter a number:");
n = Convert.ToInt32(Console.ReadLine());
while(i<=n)
{
    f = f * i;
    i = i + 1;
}
System.Console.WriteLine("Factorial of " + n + " is " + f);