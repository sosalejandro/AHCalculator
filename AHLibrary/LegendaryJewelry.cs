using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace AHLibrary
{
    public class ShadowghastRing
    {
        public int Rank { get; }
        public Dictionary<string, int> Materials { get; }
        // public decimal CostToCraft => Materials?.Sum(x => x.Value * CurrentPrice) ?? 0;
        // protected decimal CurrentPrice;
        public ShadowghastRing(int rank)
        {
            Rank = rank;
            int amountNeeded = rank switch
            {
                4 => 40,
                3 => 25,
                2 => 15,
                _ => 10
            };

            Materials = new Dictionary<string, int>
            {
                {"Shadowghast Ingot", amountNeeded * 2},
                {"Essence of Rebirth", amountNeeded},
                {"Essence of Torment", amountNeeded},
                {"Orboreal Shard", amountNeeded}
            };


        }
        public void MatsNeeded()
        {
            WriteLine("{0,-8} {1,25}", "Material", "Amount");            
            foreach (KeyValuePair<string, int> item in Materials)
            {
                WriteLine("{0,-20}\t {1,9}", item.Key, item.Value);
            }
        }

        public void CostToCraft()
        {
            Dictionary<string, decimal> Cost = new Dictionary<string, decimal>();
            decimal totalCost = 0m;
            foreach (KeyValuePair<string, int> item in Materials)
            {
                decimal currentPrice;
                Write("What's the current price for {0}?: ", item.Key);
                bool input = decimal.TryParse(ReadLine(), out currentPrice);
                Cost.Add(item.Key, currentPrice);
                WriteLine("It will cost {0}", item.Value * currentPrice);
                totalCost += item.Value * currentPrice;
            }
            WriteLine("Total cost will be {0}", totalCost);
        }
    }
}
