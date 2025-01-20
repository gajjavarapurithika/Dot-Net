using System;
int i;
System.Console.Write("Enter a value:");
i=Convert.ToInt32(Console.ReadLine());
if(i%2==0)
{
    goto even;
}
else
{
    goto odd;
}
even:
    System.Console.WriteLine("number is even");
return;
odd:
    System.Console.WriteLine(" number is odd");