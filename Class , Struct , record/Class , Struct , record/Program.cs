using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Storing_Methods_Class__Struct__Record_
{
    //Struct  (value type , stored in stack memory )
    struct Car
    {
        public string Brand;
        public int ModelYear;

        public Car(string brand, int modelyear)
        {
            Brand = brand;
            ModelYear = modelyear;
        }
        public void ShoeCar()
        {
            Console.WriteLine($"Car: {Brand} , ModelYear: {ModelYear}");
        }
    }


    //Class (Stored in heap memory , reference type)
    class Person
    {
        public string Name;
        public int Age;


        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void ShowPerson()
        {
            Console.WriteLine($"Person: {Name} , Age: {Age}");
        }
    }

    //Record  (stored in heap memory , reference type , Immutable data
    record Book(string Title, string Auther);

    internal class Program
    {
        static void Main(string[] args)
        {
            //struct (modificarion allowed , after value copy new copy of object will be created fo

            Car myCar1 = new Car("Toyota", 2023);
            myCar1.ShoeCar();
            Car myCar2 = myCar1;
            myCar2.ModelYear = 2025; //here a newcopy of object will create with new model year year prevoious will remain unaffected
            Console.WriteLine($"mycar1 modelyear: {myCar1.ModelYear} , mycar2 modelyear: {myCar2.ModelYear}");
            Console.ReadLine();
            //here in Struct Mycar1 and Mycar2 will have diffrent modelyear



            //Class (modification Allowed , after referece copy same object will be affect no other copy will be made)

            Person person1 = new Person("Ali", 25);
            person1.ShowPerson();
            Person person2 = person1; //reference copy
            person2.Age = 30;
            Console.WriteLine($"Person 1 Age: {person1.Age} , Person 2 Age: {person2.Age}");
            Console.ReadLine();
            //here in class both person1 and person2 have same age.


            //Record (Modification Nor Allowed , stored in heap)

            Book newbook = new Book("Bal e jibrael", "Allama iqbal");
            Console.WriteLine($"Book: {newbook.Title} . Auther: {newbook.Auther}");

            //newbook.Title = "bang e dara"; not possible

            Book newbook2 = newbook with { Title = "bang e dara" }; // correct way of modify record
            Console.WriteLine($"Updated Book: {newbook2.Title}");
            Console.ReadLine();


        }
    }
}
