using System;
class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {
    }
    public void printMessage()
    {
        Console.WriteLine("Not Eligible to vote");
    }
    public static void checkAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Invalid Age");
        }
        else
        {
            Console.WriteLine("Eligible to vote");
        }
    }
}
class Test
{
    public int age;
    public static void Main(String[] args)
    {
        Test t = new Test();
        t.age = 45;
        try
        {
            InvalidAgeException.checkAge(t.age);
        }
        catch (InvalidAgeException e)
        {
            Console.WriteLine(e.Message);
            e.printMessage();
        }
    }
}