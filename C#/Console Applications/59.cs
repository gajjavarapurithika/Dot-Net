using System;
int n, f=1, i = 1;
System.Console.WriteLine("Enter a number:");
n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("=====================");
while(i<=n)
{
    f = f * i;
    System.Console.WriteLine(i + "\t" + f);
    i = i + 1;
}