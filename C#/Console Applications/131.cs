using System;
class Greeks
{
    private string[]values=new string[3];
    public string this[int index]
    {
        get
        {
            return values[index];
        }
        set
        {
            values[index] = value;
        }
    }
    static void Main()
    {
        Greeks o = new Greeks();
        o[0] = "c";
        o[1] = "d";
        o[2] = "e";
        System.Console.WriteLine("First value"+o[0]);
        System.Console.WriteLine("Second value"+o[1]);
        System.Console.WriteLine("Third value" + o[2]);
    }
}