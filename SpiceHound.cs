using System;
using System.Collections.Generic;

public class SpiceHound : Ninja
{
    // provide override for IsFull (Full at 1200 Calories)
    public override bool IsFull
    {
        get
        {
            if (calorieIntake > 1200)  
            {
                Console.WriteLine("This SpiceHound is full!");
                return true;
            }
            return false;
        }
    }

    public override void Consume(IConsumable item)
    {
        this.calorieIntake += item.Calories;

        if (item.IsSpicy)
        {
            this.calorieIntake -= 5;
        }
        ConsumptionHistory.Add(item);
        System.Console.WriteLine(item.GetInfo());
    }
}