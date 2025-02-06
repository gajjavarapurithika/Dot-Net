using System;
using System.Collections;
class Test
{
    static void Main()
    {
        Hashtable ht = new Hashtable();
        ht.Add(1, "pen");
        ht.Add(2, "pencil");
        ht.Add(3, "Book");
        ICollection Key= ht.Keys;
        foreach(int K in Key)
        {
            Console.Write(K + ":" + ht[K]);
        }
    }

}