using System;
using System.Collections;
class Test
{
    static void Main()
    {
        Stack ht = new Stack();
        ht.Push("pen");
        ht.Push("pencil");
        ht.Push("Book");
        foreach (string K in ht)
        {
            Console.WriteLine(K);
        }
        Console.WriteLine("=====================");
        ht.Pop();
        foreach(string K in ht)
        {
            Console.WriteLine(K);
        }
    }

}