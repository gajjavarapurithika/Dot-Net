using System;
class Test
{
    public static void Main()
    {
        StreamReader sr = new StreamReader("D:\\internship\\.Net\\C#\\Console Applications\\ConsoleApp122\\ConsoleApp122\\bin\\Debug\\net8.0\\fruo.txt");
        Console.WriteLine(sr.ReadToEnd());
        sr.Close();
    }
}