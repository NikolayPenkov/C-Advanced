using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var chemicalEntries = int.Parse(Console.ReadLine());
            //var uniqueElements = new HashSet<string>();
            //for (int i = 0; i < chemicalEntries; i++)
            //{
            //    var chemicalElements = Console.ReadLine().Split(" ").ToList();
            //    foreach (var element in chemicalElements)
            //    {
            //        uniqueElements.Add(element);
            //    }
            //}
            //List<string> alphabeticalElements = new List<string>(uniqueElements);
            //alphabeticalElements.Sort();
            //Console.WriteLine(String.Join(" ", alphabeticalElements));
            //this exercise can be done with sorted set
            var Entries = int.Parse(Console.ReadLine());
            var sortedSetElements = new SortedSet<string>();
            for (int i = 0; i < Entries; i++)
            {
                var chemicalElements = Console.ReadLine().Split(" ").ToList();
                foreach (var element in chemicalElements)
                {
                    sortedSetElements.Add(element);
                }
            }
           
            
            Console.WriteLine(String.Join(" ", sortedSetElements));
        }
    }
}
