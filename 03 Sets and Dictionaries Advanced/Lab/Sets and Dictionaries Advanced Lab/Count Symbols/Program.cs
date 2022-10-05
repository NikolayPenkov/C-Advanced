using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] entries = Console.ReadLine().ToCharArray();
            //this exercise can be done with Sorted Dicitionary
            Dictionary<char, int> repeated = new Dictionary<char, int>();

            for (int i = 0; i < entries.Length; i++)
            {
                char currChar = entries[i];
                if (!repeated.ContainsKey(currChar))
                {
                    repeated.Add(currChar, 1);
                }
                else
                {
                    repeated[currChar]++;
                }
            }
            repeated = repeated.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

           
            foreach (var item in repeated)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
