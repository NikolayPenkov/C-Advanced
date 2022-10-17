using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tile_Master
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] whiteTiles = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] greyTiles = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> grey = new Queue<int>(greyTiles);
            Stack<int> white = new Stack<int>(whiteTiles);
          

            int sink = 0;
            int oven = 0;
            int countertop = 0;
            int wall = 0;
            int floor = 0;

            while (grey.Count > 0 & white.Count > 0)
            {
                int greyTile = grey.Peek();
                int whiteTile = white.Peek();

                if (greyTile == whiteTile)
                {
                    int sum = greyTile + whiteTile;

                    switch (sum)
                    {
                        case 40:
                            sink++;
                            grey.Dequeue();
                            white.Pop();
                            break;
                        case 50:
                            oven++;
                            grey.Dequeue();
                            white.Pop();
                            break;
                        case 60:
                            countertop++;
                            grey.Dequeue();
                            white.Pop();
                            break;
                        case 70:
                            wall++;
                            grey.Dequeue();
                            white.Pop();
                            break;
                        default:
                            floor++;
                            grey.Dequeue();
                            white.Pop();
                            break;
                    }
                }
                else
                {
                  int newWhiteTile =  whiteTile / 2;
                    white.Pop();
                    white.Push(newWhiteTile);
                    grey.Dequeue();
                    grey.Enqueue(greyTile);
                }
            }
            Dictionary<string, int> allTiles = new Dictionary<string, int>()
            {
                {"Sink", sink },
                {"Oven", oven },
                {"Countertop", countertop },
                {"Wall", wall },
                {"Floor", floor },
            };
          //  StringBuilder sb = new StringBuilder();
            if (white.Count > 0)
            {
                //sb.AppendLine($"White tiles left: {String.Join(" ,",white)}");
                Console.WriteLine($"White tiles left: {String.Join(", ", white)}");
            }
            else
            {
                // sb.AppendLine("White tiles left: none");
                Console.WriteLine("White tiles left: none");
            }
            if (grey.Count > 0)
            {
                //  sb.AppendLine($"Grey tiles left: {String.Join(" ,", grey)}");
                Console.WriteLine($"Grey tiles left: {String.Join(", ", grey)}");
            }
            else
            {
                //sb.AppendLine("Grey tiles left: none");
                Console.WriteLine("Grey tiles left: none");
            }
            allTiles = allTiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(l => l.Key, l=> l.Value);
            foreach (var item in allTiles)
            {
                if (item.Value> 0)
                {
                    //sb.AppendLine($"{allTiles.Keys} : {allTiles.Values}");
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            //Console.WriteLine(sb);
        }
    }
}
