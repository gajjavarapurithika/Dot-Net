using System;
int i = 99;
while(i>=2)
{
    System.Console.WriteLine(i+"bottles of beer on the wall,"+(i-1)+"bottles of beer");
    System.Console.WriteLine("Take one down and pass it around," + (i - 1) + "bottles of the beer on the wall \n");
    i = i - 1;
}
System.Console.WriteLine("1 bottle beer on the wall,1 botle of beer");
System.Console.WriteLine("Take one down and pass it around,no more bottles of beer on the wall\n");
System.Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer");
System.Console.WriteLine("Go to the store and buy some more,99 bottles of beer on the wall");