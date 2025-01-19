using System;
int n, s = 0, r,i=1;
System.Console.WriteLine("Enter a number:");
n = Convert.ToInt32(Console.ReadLine());
while(i<=n)
{
    r = n % 10;
    s = s * 10 + r;
    n = n / 10;
}
System.Console.WriteLine("Reverse:" + s);