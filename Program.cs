using System;
using System.Collections.Generic;

namespace IronNinja
{
    class Program
    {  
        class Buffet
        {
            public List<Food> Menu;
            public Buffet()
            {
                Menu = new List<Food>()
                {
                    new Food("Chicken", 500, false, false),
                    new Food("Beef", 1000, true, false),
                    new Food("Pork", 1500, false, true),
                    new Food("Fish", 250, true, true),
                    new Food("Lamb", 800, false, false),
                    new Food("Goat", 600, true, false),
                    new Food("Horse", 1200, true, false),
                };
            }

            public Food Serve()
            {
                Random rand = new Random();
                return Menu[rand.Next(0,Menu.Count)];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SweetTooth test = new SweetTooth();
            


        }

    }
}
