using System;
using static System.Console;
using AHLibrary;

namespace JewelCrafting
{
    class Program
    {
        public static void CraftingItem(string crafting)
        {
            WriteLine("This is the ring crafting price helper, what will you craft today?");
            Write("Ring Rank: ");
            bool input1 = int.TryParse(ReadLine(), out int rank);
            ShadowghastRing RingToCraft = new ShadowghastRing(rank);
            
            WriteLine("You will need the next amount: ");
            RingToCraft.MatsNeeded();
            var Crafting = crafting switch
            {
                string r => new ShadowghastRing(ItemRank()),
                _ => null
            };
            Crafting.MatsNeeded();
            Crafting.CostToCraft();
        }

        public static int ItemRank()
        {
            Write("Please, enter the desired rank of the item: ");
            bool inputRank = int.TryParse(ReadLine(), out int RANK);
            return RANK;
        }

        public static void Start()
        {
            WriteLine("This is the legendary crafting helper, what will you craft today?\n" +
                   "Ring: R\t Necklace: N");
            Write("Enter the letter for desired item to craft: ");
            string input = ReadLine().ToLower();
            CraftingItem(input);
            WriteLine("The program will exit, press enter to shutdown.");
            ReadLine();
        }

        static void Main(string[] args)
        {
            Start();
        }
    }
}
