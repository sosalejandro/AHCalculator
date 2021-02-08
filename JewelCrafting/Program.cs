using System;
using static System.Console;
using AHLibrary;

namespace JewelCrafting
{
    class Program
    {
        public static void CraftingItem(string crafting)
        {
            try
            {
                var Crafting = crafting switch
                {
                    string r when r.Contains('r') => new ShadowghastRing(ItemRank()),
                    _ => null
                };   
                Crafting.MatsNeeded();
                Crafting.CostToCraft();             
            }
            catch(NullReferenceException ex)
            {
                WriteLine(ex);
                Write("Enter a valid input\nRing: R\t Necklace: N");
                Start();
            }
        }

        public static int ItemRank()
        {
            int RANK = 0;
            while (RANK <= 0 || RANK >= 5)
            {
                Write("Please, enter a valid rank from 1 to 4: ");
                bool inputRank = int.TryParse(ReadLine(), out RANK);
            };
            return RANK;
        }

        public static void Start()
        {       
            string input = ReadLine().ToLower();
            CraftingItem(input);            
        }

        static void Main(string[] args)
        {
            WriteLine("This is the legendary crafting helper, what will you craft today?\nRing: R\t Necklace: N");
            Write("Enter the letter for desired item to craft: ");

            Start();
            WriteLine("The program will exit, press enter to shutdown.");
            ReadLine();
        }
    }
}
