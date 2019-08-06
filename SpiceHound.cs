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
                return true;
            }
            return false;
        }
    }

    public override void Consume(IConsumable item)
    {
        // provide override for Consume
        this.calorieIntake += item.Calories;
        ConsumptionHistory.Add(item);
        Console.WriteLine("Food: " + item.Name + " Spicy: " + item.IsSpicy + " | Sweet: " + item.IsSweet);
    }
}