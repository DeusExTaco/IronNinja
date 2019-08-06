using System;
using System.Collections.Generic;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet myBuffet = new Buffet();
            SweetTooth mySweetTooth = new SweetTooth();
            SpiceHound mySpiceHound = new SpiceHound();

            mySweetTooth.Consume(myBuffet.Serve());
            System.Console.WriteLine(mySweetTooth.ConsumptionHistory.Count);
        }

    }
}
