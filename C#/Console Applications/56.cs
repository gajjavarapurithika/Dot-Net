using System;
int s = 0, t, i = 1, r, n;
System.Console.WriteLine("Enter a number:");
n = Convert.ToInt32(Console.ReadLine());
t = n;
while(i<=n)
{
    r = n % 10;
    s = s + r * r * r;
    n = n / 10;
}
if(t==s)
{
    System.Console.WriteLine("Armstrong");
}
else
{
    System.Console.WriteLine("Not a armstrong");
}