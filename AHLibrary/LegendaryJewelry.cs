using System;
using static System.Console;

namespace AHLibrary
{
    public class ShadowghastRing
    {
        public int Rank;
        public RingMats Mats;
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
            Mats = new RingMats(amountNeeded);
            WriteLine(format: "Created an instance of ring {0}", arg0: rank);
        }
        public void MatsNeeded()
        {
            WriteLine("{0,-8} {1,16}", "Material", "Amount");
            WriteLine("{0,-8} {1,7}", nameof(Mats.ShadowghastIngot), Mats.ShadowghastIngot);
            WriteLine("{0,-8} {1,7}", nameof(Mats.EssenceOfRebirth), Mats.EssenceOfRebirth);
            WriteLine("{0,-8} {1,7}", nameof(Mats.EssenceOfTorment), Mats.EssenceOfTorment);
            WriteLine("{0,-8} {1,10}", nameof(Mats.OrborealShard), Mats.OrborealShard);
        }

        public void CostToCraft()
        {
            decimal mat1;
            decimal mat2;
            decimal mat3;
            decimal mat4;

            bool input1;
            bool input2;
            bool input3;
            bool input4;

            Write($"What's the cost of the Shadowghast Ingots? price a piece: ");
            input1 = decimal.TryParse(ReadLine(), out mat1);
            decimal mat1cost = mat1 * Mats.ShadowghastIngot;
            WriteLine($"It will cost {mat1cost} gold.");

            
            Write($"What's the cost of the Essence of Rebirth? price a piece: ");
            input2 = decimal.TryParse(ReadLine(), out mat2);
            decimal mat2cost = mat2 * Mats.EssenceOfRebirth;
            WriteLine($"It will cost {mat2cost} gold.");
            
            
            Write($"What's the cost of the Essence of Torment? price a piece: ");
            input3 = decimal.TryParse(ReadLine(), out mat3);
            decimal mat3cost = mat3 * Mats.EssenceOfTorment;
            WriteLine($"It will cost {mat3cost} gold.");

            
            Write($"What's the cost of the Orboreal Shard? price a piece: ");
            input4 = decimal.TryParse(ReadLine(), out mat4);
            decimal mat4cost = mat4 * Mats.OrborealShard;
            WriteLine($"It will cost {mat4cost} gold.");

            decimal totalCost = mat1cost + mat2cost + mat3cost + mat4cost;
            WriteLine($"It's total cost will be a total cost of {totalCost} gold.");
        }
    }

    public class RingMats
    {
        public int ShadowghastIngot;
        public int EssenceOfTorment;
        public int EssenceOfRebirth;
        public int OrborealShard;

        public RingMats(int amount)
        {
            ShadowghastIngot = amount * 2;
            EssenceOfTorment = amount;
            EssenceOfRebirth = amount;
            OrborealShard = amount;
        }
    }
}
