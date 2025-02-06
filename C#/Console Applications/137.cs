using System;
using System.Collections;

class Test
{
    static void Main()
    {
        Queue ht = new Queue();
        ht.Enqueue("pen");
        ht.Enqueue("pencil");
        ht.Enqueue("Book");

        // Iterate over the queue and print each item (as strings)
        foreach (var K in ht)
        {
            Console.Write(K + " ");
        }

        // Dequeue an item
        string ch = (string)ht.Dequeue();
        Console.WriteLine();
        Console.WriteLine("The removed value: {0}", ch);  // Corrected formatting
    }
}
