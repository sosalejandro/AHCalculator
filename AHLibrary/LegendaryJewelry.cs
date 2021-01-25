using System;
using static System.Console;
using System.Collections.Generic;

namespace AHLibrary
{
    public class ShadowghastRing
    {
        public int Rank;
        public Dictionary<string, int> materials;
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
            
            materials = new Dictionary<string, int>();
            materials.Add("Shadowghast Ingot", amountNeeded * 2);
            materials.Add("Essence of Rebirth", amountNeeded);
            materials.Add("Essence of Torment", amountNeeded);
            materials.Add("Orboreal Shard", amountNeeded);
            WriteLine(format: "Created an instance of ring {0}", arg0: rank);
        }
        public void MatsNeeded()
        {
            WriteLine("{0,-8} {1,25}", "Material", "Amount");
            foreach (KeyValuePair<string, int> item in materials)
            {
                WriteLine("{0,-20}\t {1,9}", item.Key, item.Value);
            }
        }

        public void CostToCraft()
        {
            Dictionary<string, decimal> Cost = new Dictionary<string, decimal>();
            decimal totalCost = 0m;
            foreach (KeyValuePair<string, int> item in materials)
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