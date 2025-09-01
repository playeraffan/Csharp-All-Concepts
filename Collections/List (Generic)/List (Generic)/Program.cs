using System;
using System.Collections.Generic;

class program
{
    static void main()
    { 
     //creat lsit integer
     List<int> number = new List<int>();

        //add element
        number.Add(40);
        foreach (var num in number) Console.WriteLine(num);

        //insert element
        number.Insert(2,50);
        foreach (var num in number) Console.WriteLine(num);

        //remove element
        number.Remove(40);
        foreach (var num in number) Console.WriteLine(num);

        //remove by inedxno element
        number.RemoveAt(1);
        foreach (var num in number) Console.WriteLine(num);

    }
}
