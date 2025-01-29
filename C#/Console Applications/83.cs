using System;
int[,] a = new int[3, 3];
a[0, 0] = 0;
a[0, 1] = 1;
a[0, 2] = 2;
a[1, 0] = 3;
a[1, 1] = 4;
a[1, 2] = 5;
a[2, 0] = 6;
a[2, 1] = 7;
a[2, 2] = 8;
int i, j;
System.Console.WriteLine("Array");
System.Console.WriteLine("------------------");
for(i=0;i<3;i++)
{
    for (j=0;j<3;j++)
    {
        System.Console.Write("\t" + a[i, j]);
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("Transpose");
System.Console.WriteLine("---------------------");
for (i = 0; i < 3; i++)
{
    for (j = 0; j < 3; j++)
    {
        System.Console.Write("\t" + a[j, i]);
    }
    System.Console.WriteLine();
}

