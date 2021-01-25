using System;
using static System.Console;
using AHLibrary;

namespace JewelCrafting
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("This is the ring crafting price helper, what will you craft today?");
            Write("Ring Rank: ");
            bool input1 = int.TryParse(ReadLine(), out int rank);
            ShadowghastRing RingToCraft = new ShadowghastRing(rank);
            
            WriteLine("You will need the next amount: ");
            RingToCraft.MatsNeeded();

            Write("Press Enter to continue: ");
            ReadLine();
            RingToCraft.CostToCraft();
            WriteLine("The program will exit, press enter to shutdown. ");
            ReadLine();
        }
    }
}
