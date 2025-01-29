int[,] a = new int[100, 100];
int r,c, i, j;
System.Console.Write("Enter the number of rows: ");
r = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Enter the number of columns: ");
c = Convert.ToInt32(System.Console.ReadLine());
for(i=0;i< r; i++)
{
    for (j = 0; j < c; j++)
    {
        a[i, j] = Convert.ToInt32(System.Console.ReadLine());
    }
}
for (i = 0; i < r; i++)
{
    for (j = 0; j < c; j++)
    {
        System.Console.Write(a[i, j] + " ");
    }
    System.Console.WriteLine();
}