using Microsoft.Win32.SafeHandles;
using System;

class Myclass
{
    private int x;
    public void Setx(int i)
    {
        x = i;
    }
    public int Getx()
    {
        return x;
    }
}
class Myclient
{
    public static void Main()
    {
        Myclass mc= new Myclass();
        mc.Setx(10);
        int xval = mc.Getx();
        Console.WriteLine(xval);
    }
}