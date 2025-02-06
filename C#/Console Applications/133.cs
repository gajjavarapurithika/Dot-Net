using System;
using System.Collections;
class Test
{
    public static void Main()
    {
        ArrayList At=new ArrayList();
        System.Console.WriteLine(At);
        System.Console.WriteLine("capacity:{0}", At.Capacity);
        System.Console.WriteLine("COunt{0}",At.Count);
        At.Add("pen");
        At.Add("Book");
        At.Add("Pencil");
        System.Console.WriteLine("Capacity:{0}",At.Capacity);
        System.Console.WriteLine("Count:{0}", At.Count);
        foreach(string x in At)
        {
            System.Console.WriteLine(x+"\t");
        }
    }
}