using System;
int a;
System.Console.WriteLine("Enter a value:");
a = Convert.ToInt32(Console.ReadLine());
if(a%2==0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}