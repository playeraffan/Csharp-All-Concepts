using System;
using System.Collections;

class progaram
{
    static void Main() 
    { 
     //create hastable
     Hashtable ht = new Hashtable();

        //add values
        ht.Add(1 , "One");
        ht.Add(2, "Two");
        ht.Add(3, "Three");

        foreach (DictionaryEntry entry in ht) Console.WriteLine($"{entry.Key}: {entry.Value}");

        //remove
        ht.Remove(1);
        foreach (DictionaryEntry entry in ht) Console.WriteLine($"{entry.Key}: {entry.Value}");
        Console.ReadLine();
    }
}