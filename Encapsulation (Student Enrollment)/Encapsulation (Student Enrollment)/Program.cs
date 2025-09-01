using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation__Student_Enrollment_ 
{ 
 class student {
    private int Id;
    private string Name;
    private int Age;
    private string Course;

    public void insert_data(int id , string name , int age , string course) 
    { 
      Id=id; Name=name; Age=age; Course=course;
    }
        public int get_id()
        {
            return Id;
        }
        public string get_name()
        {
            return Name;
        }
        public int get_age()
        {
            return Age;
        }
        public string get_course()
        {
            return Course;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student Student = new student();
            Student.insert_data(1, "Affan", 20, "ACCP");
            Student.insert_data(2, "Zia", 21, "HDSE");
            Console.WriteLine($"ID : {Student.get_id()} "  + $"Name : {Student.get_name()} " + $"Age : {Student.get_age()} "
                + $"Course : {Student.get_course()} ");
            Console.ReadLine();
        }
    }
}
