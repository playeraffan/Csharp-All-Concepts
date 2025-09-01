using System;
using System.Collections.Generic;

class program   //hashset ignores duplicate valurs and only stores unique value
 {    static void Main()
    { 
     HashSet<int> list = new HashSet<int>();
       // add values
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(10);  // duplicat value will ignore

        foreach (var num in list) Console.WriteLine(num);
        Console.ReadLine();

        //remove values

        list.Remove(20);
        foreach (var num in list) Console.WriteLine(num);

        //check if an element is exist
        Console.WriteLine($"\n Constains: 30? {list.Contains(30)}");
        Console.ReadLine();


    }
}

