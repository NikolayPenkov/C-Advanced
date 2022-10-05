using System;
using System.Collections.Generic;

namespace Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var entries = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < entries; i++)
            {
                string[] ColorAndTypeClothes = Console.ReadLine().Split(" -> ");
                string color =ColorAndTypeClothes[0];
                string[] typeClothes = ColorAndTypeClothes[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                Dictionary<string, int> clothes = wardrobe[color];
                    foreach (var cloth in typeClothes)
                    {
                        if (!clothes.ContainsKey(cloth))
                        {
                             clothes.Add(cloth, 1);
                        }
                        else
                        {
                            clothes[cloth]++;
                        }
                    }
            }
            string [] FindInWardrobe = Console.ReadLine().Split();
            string findColor = FindInWardrobe[0];
            string findCloth = FindInWardrobe[1];

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                Dictionary<string, int> clothes = wardrobe[item.Key];
                foreach (var cloth in clothes)
                {
                    if (cloth.Key == findCloth && item.Key == findColor)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
