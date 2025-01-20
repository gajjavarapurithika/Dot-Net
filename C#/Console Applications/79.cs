using System;
int[] a = new int[100];
int n,i;
System.Console.Write("Enter size of an array");
n=Convert.ToInt32(Console.ReadLine());
for(i=0;i<n;i++)
{
    a[i]=Convert.ToInt32(Console.ReadLine());
}
System.Console.Clear();
System.Console.WriteLine("Elements are:");
System.Console.WriteLine("================");
for(i=0;i<n;i++)
{
    System.Console.Write("\t"+a[i]);
}