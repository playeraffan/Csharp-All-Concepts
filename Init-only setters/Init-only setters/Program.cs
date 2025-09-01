using System;

namespace init__only_setters
{
    class initonly
    {
        public string Name { get; init; }  //simialr to set but value can be set only one time while creating object then it remain immutable
        public int Id { get; init; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            initonly initonly = new initonly {Name = "Affan" , Id = 2 }; // value will be assign in initial block of object 

            //initonly.Name = "usman";  ..Not possile
            //initonly.Id = 4;   ..Not posible

            Console.WriteLine($"Name : {initonly.Name} Id : {initonly.Id}");
            Console.ReadLine();



        }
    }
}

    


