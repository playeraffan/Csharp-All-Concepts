using System;
namespace indexers 
{
    class Number
    {
        private int[] number;

        public Number(int size)
        { 
         this.number = new int[size];
        }

        public int this[int index]
        {
            get
            {
                   return number[index];
            }
            set
            {
                if (index >= 0 && index < number.Length)
                {
                    if (value >= 0)
                    {
                       number[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("negetive values are not allowed!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid index no");
                }
            }
        }
    
    }
    class Primary
    {
        static void Main() 
        {
            Number store = new Number(3);

            store[0] = 10;
            store[1] = 20;
            store[2] = 30;
            //store[3] = 40;
            //store[1] = -20;
            Console.WriteLine(store[0]);
            Console.WriteLine(store[1]);
            Console.WriteLine(store[2]);
            Console.ReadLine();

        }
    }
}