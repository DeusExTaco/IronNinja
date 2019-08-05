using System;
using System.Collections.Generic;

public class SweetTooth : Ninja
{
    // provide override for IsFull (Full at 1500 Calories)
    public override bool IsFull
    {
        get
        {
            return false;
        }
    }

    public override void Consume(IConsumable item)
    {
        // provide override for Consume
        int i = 0;
        foreach (object z in ConsumptionHistory)
        {
            Console.WriteLine(ConsumptionHistory[i].Calories);
            i++;
        }

    }
}