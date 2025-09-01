using System;
using System.Collections.Generic;

class program   //kinked list provide more flexibility than other collection types
{
    static void Main()
    { 
      
        LinkedList<int> list = new LinkedList<int>();

        //Add element on last
        list.AddLast(10);
        list.AddLast(20);
        list.AddLast(30);
        foreach (int i in list) Console.WriteLine(i);
        Console.ReadLine();
        //add element on first
        list.AddFirst(10);
        foreach (int i in list) Console.WriteLine(i);
        Console.ReadLine();
        //insert in the middle
        LinkedListNode<int> node = list.Find(20);
        list.AddBefore(node, 15);
        foreach (int i in list) Console.WriteLine(i);
        Console.ReadLine();
        //remove
        list.Remove(10);
        foreach (int i in list) Console.WriteLine(i);
        Console.ReadLine();


    }
}