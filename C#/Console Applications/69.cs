using System;
int i;
System.Console.WriteLine("====================");
System.Console.WriteLine("\t \t Menu");
System.Console.WriteLine("======================");
System.Console.WriteLine("1 Pen");
System.Console.WriteLine("2 Book");
System.Console.WriteLine("3 Eraser");
System.Console.WriteLine("4 scale");
System.Console.WriteLine("=======================");
System.Console.WriteLine("Select an one item (1|2|3|4)");
i=Convert.ToInt32(Console.ReadLine());
if (i == 1)
{
    System.Console.WriteLine("Pen Selected");
}
else if(i == 2)
{
    System.Console.WriteLine("Book Selected");
}
else if(i == 3)
{
    System.Console.WriteLine("Eraser selected");
}
else if(i == 4)
{
    System.Console.WriteLine("Scale selected");
}
else
{
    System.Console.WriteLine("Invalid selection");
}