using System;
int n, i=1;
System.Console.WriteLine("Enter a number:");
n=Convert.ToInt32(Console.ReadLine());
while(i<=n)
{
    System.Console.WriteLine("\t" + i);
    i = i + 1;
}