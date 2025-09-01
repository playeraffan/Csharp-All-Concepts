using System;
using System.Collections.Generic;


class program  //in stack element add from top also remove from top
{
    static void Main()
    { 
      Stack<string> stack = new Stack<string>();

        //push
        stack.Push("Undo 1");
        stack.Push("Undo 2");
        stack.Push("Undo 3");
        foreach (var item in stack) Console.WriteLine(item);

        Console.ReadLine();

        //pop
        stack.Pop();
        foreach (var item in stack) Console.WriteLine(item);

        //check top element
        Console.WriteLine($"\n Top element in stack: {stack.Peek()}");

    }
}