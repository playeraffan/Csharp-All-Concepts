using System;
using System.Collections.Generic;

class Program    //in queue collection iddem added at last and remove from first
{
    static void Main()
    { 
        //creating queue
      Queue<string> queue = new Queue<string>();

        //Enqueue (adding elements)
        queue.Enqueue("task 1");
        queue.Enqueue("task 2");
        queue.Enqueue("task 3");

        foreach (var item in queue) Console.WriteLine(item);
        Console.ReadLine();

        //Dequeue (removing elements)
        queue.Dequeue();
        foreach (var item in queue) Console.WriteLine(item);
        Console.ReadLine();

        //check front elemnt
        Console.WriteLine($"\nFront element in Queue: {queue.Peek()}");
        Console.ReadLine();
    }
}