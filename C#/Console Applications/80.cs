using System;
int[]a= new int[100];
int n, i,c= 0, s = 0;
double av;
System.Console.Write("Enter size of an array:");
n=Convert.ToInt32(Console.ReadLine());
for(i=0;i<n;i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
    c = c + 1;
    s = s + a[i];
}
System.Console.Clear();
System.Console.WriteLine("Elements are:");
System.Console.WriteLine("----------------");
for(i=0;i<n;i++)
{
    System.Console.Write("\t"+a[i]);
}
System.Console.WriteLine();
System.Console.WriteLine("Count=" + c);
System.Console.WriteLine("Sum=" + s);
av = s / c;
System.Console.WriteLine("Average=" + av);