﻿using System;
int i = 1, c = 0, s = 0;
while(i<=10)
{
    System.Console.WriteLine(i);
    c = c + i;
    s = s + i;
    i = i + 1;
}
System.Console.WriteLine("Total numbers are="+c);
System.Console.WriteLine("Sum of numbers=" + s);
System.Console.WriteLine("Average=" + (s/ c));