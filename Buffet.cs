using System;
using System.Collections.Generic;
class Buffet
        {
            public List<IConsumable> Menu;
            public Buffet()
            {
                Menu = new List<IConsumable>()
                {
                    new Food("Chicken", 500, false, false),
                    new Food("Beef", 1000, true, false),
                    new Food("Pork", 1500, false, true),
                    new Food("Fish", 250, true, true),
                    new Food("Lamb", 800, false, false),
                    new Food("Goat", 600, true, false),
                    new Food("Horse", 1200, true, false),
                    new Drink("Chai Tea", 500, true, true),
                    new Drink("Beer", 200, false, false),
                    new Drink("Wine", 400, true, false),
                    new Drink("Coffee", 25, true, true),
                };
            }
            public IConsumable Serve()
            {
                Random rand = new Random();
                return Menu[rand.Next(0,Menu.Count)];
            }
        }