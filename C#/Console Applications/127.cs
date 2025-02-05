using System;

class Myclass
{
    private int x;

    // Property 'X' with a custom getter and setter
    public int X
    {
        get
        {
            return x;
        }
        set
        {
            x = value;
        }
    }
}

class Myclient
{
    public static void Main()
    {
        Myclass mc = new Myclass();

        // Assigning value to property 'X'
        mc.X = 10;

        // Retrieving value from property 'X'
        int xval = mc.X;

        // Output the value of 'X'
        Console.WriteLine(xval);
    }
}
