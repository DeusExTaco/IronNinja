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

            int sweetCount = 0;
            int spicyCount = 0;

            while (mySweetTooth.IsFull == false){
                mySweetTooth.Consume(myBuffet.Serve());
                sweetCount ++;
            }
            while (mySpiceHound.IsFull == false)
            {
                mySpiceHound.Consume(myBuffet.Serve());
                spicyCount ++;
            }

            if (sweetCount > spicyCount)
            {
                System.Console.WriteLine("mySweetTooth has consumed the most items. Items consumed: " + sweetCount);
            }
            else 
            {
                System.Console.WriteLine("mySpiceHound has consumed the most items. Items consumed: " + spicyCount);
            }
        }

    }
}
