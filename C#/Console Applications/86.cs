using System;
int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[,] b = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[,] c = new int[3, 3];
int i, j, k;
System.Console.WriteLine();
System.Console.WriteLine("Matrix A");
System.Console.WriteLine("========");
for (i = 0; i < 3; i++)
{
    for (j = 0; j < 3; j++)
    {
        System.Console.Write("\t"+a[i, j]);
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("Matrix B");
System.Console.WriteLine("========");
for (i = 0; i < 3; i++)
{
    for (j = 0; j < 3; j++)
    {
        System.Console.Write("\t" + b[i, j]);
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();
for (i = 0; i < 3; i++)
{
    for (j = 0; j < 3; j++)
    {
        for (k = 0; k < 3; k++)
        {
            c[i, j] += a[i, k] * b[k, j];
        }
    }
}
System.Console.WriteLine("A*B Matrix");
System.Console.WriteLine("==========");
for (i = 0; i < 3; i++)
{
    for (j = 0; j < 3; j++)
    {
        System.Console.Write("\t" + c[i, j]);
    }
    System.Console.WriteLine();
}