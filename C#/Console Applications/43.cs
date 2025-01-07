using System;
int age;
Console.WriteLine("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());
if (age >= 65)
{
    Console.WriteLine("You are a senior citizen");
    Console.WriteLine("You are eligible to vote");
}
else if (age > 65 && age >= 18)
{
    Console.WriteLine("You are major citizen");
    Console.WriteLine("You are eligible to vote");
}
else
{
    Console.WriteLine("You are a minor citizen");
    Console.WriteLine("You are not eligible to vote");
}