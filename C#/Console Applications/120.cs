class Test
{
    public static void Main()
    {
        int a = 10;
        int b = 0;
        try
        { 
            System.Console.WriteLine("Begin");
            System.Console.WriteLine("Ready to division");
            int c = a / b;
            System.Console.WriteLine("Result=" + c);
            System.Console.WriteLine("End");
        }
        catch (Exception e)
        {
            System.Console.WriteLine("You cannot divide a number with zero");
        }
        finally
        {
            System.Console.WriteLine("Execution of the program completed");
        }
    }
}