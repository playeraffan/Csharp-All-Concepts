using System;
using System.Collections;

class Program
    {
    static void Main(string[] args) 
    { 
    //creating array list
    ArrayList list = new ArrayList();  //it os non generic only 
        //adding elements
        list.Add(10);
        list.Add(20);
        list.Add(30);

        foreach (var i in list) { Console.WriteLine(i);}

        //insert element
        list.Insert(1, 15);
        foreach (var i in list) { Console.WriteLine(i); }

        //remove
        list.Remove(10);
        foreach (var i in list) { Console.WriteLine(i); }

        //remove by index no
        list.RemoveAt(0);
        foreach (var i in list) { Console.WriteLine(i); }


    }
}
