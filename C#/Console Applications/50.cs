using System;
int i = 1;
while(i<=16)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        System.Console.WriteLine("Fizzbuzz");
    }
    else if (i % 3 == 0)
    {
        System.Console.WriteLine("Fizz");
    }
    else
    {
        System.Console.WriteLine(i);
    }
    i = i + 1;
}