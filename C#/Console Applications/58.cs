using System;
int n, s = 0, r, i = 1;
System.Console.Write("Enter a number:");
n = Convert.ToInt32(Console.ReadLine());
int t  = n;
while(i<=n)
{
    r = n%10;
    s = s * 10 + r;
    n = n / 10;
}
if(t==s)
{
    System.Console.WriteLine("palindrome");
}
else
{
    System.Console.WriteLine("Not a palindrome");
}