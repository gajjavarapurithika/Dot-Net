using System;
class Test
{
    public static void Main()
    {
        StreamWriter sm = new StreamWriter("fruo.txt");
        sm.WriteLine("Apple");
        sm.WriteLine("Banana");
        sm.WriteLine("Cherry");
        sm.Close();
    }
}