using System;
using System.Collections.Generic;

class progarm
{
    static void main()
    { 
      //create dictioanry
      Dictionary<int , string> student = new Dictionary<int , string>();

        //Add Key and value

        student.Add(1, "Affan");
        student.Add(2, "Uzair");
        student.Add(3, "Noor");
        foreach (var stu in student) Console.WriteLine($"{stu.Key} : {stu.Value}");

        //remove element by key
        student.Remove(1);
        foreach (var stu in student) Console.WriteLine($"{stu.Key} : {stu.Value}");

    }
}