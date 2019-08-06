using System;
using System.Collections.Generic;

public class SweetTooth : Ninja
{
    // provide override for IsFull (Full at 1500 Calories)
    public override bool IsFull
    {
        get
        {
            if (this.calorieIntake > 1500)  
            {
                Console.WriteLine("This Ninja is full!");
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