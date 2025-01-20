using System;
int i;
System.Console.WriteLine("===========================");
System.Console.WriteLine("\t \t Menu");
System.Console.WriteLine("===========================");
System.Console.WriteLine("1 Pen");
System.Console.WriteLine("2 Book");
System.Console.WriteLine("3 Eraser");
System.Console.WriteLine("4 Scale");
System.Console.WriteLine("==========================");
System.Console.WriteLine("Select any one item(1|2|3|4)");
i=Convert.ToInt32(System.Console.ReadLine());
switch (i)
{
    case 1:
        System.Console.WriteLine("Pen selected");
        break;
    case 2:
        System.Console.WriteLine("Book selected");
        break;
    case 3:
        System.Console.WriteLine("Eraser selected");
        break;
    case 4:
        System.Console.WriteLine("Scale selected");
        break;
    default:
        System.Console.WriteLine("Invalid selection");
        break;
}