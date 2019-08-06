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
                Console.WriteLine("This SweetTooth is full!");
                return true;
            }
            return false;
        }
    }

    public override void Consume(IConsumable item)
    {
        this.calorieIntake += item.Calories;
        
        if (item.IsSweet)
        {
            this.calorieIntake += 10;
        }
        ConsumptionHistory.Add(item);
        System.Console.WriteLine(item.GetInfo());
    }
}