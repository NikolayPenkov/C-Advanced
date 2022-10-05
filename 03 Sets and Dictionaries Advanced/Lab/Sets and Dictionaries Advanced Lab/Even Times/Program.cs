using System;
using System.Collections.Generic;

namespace Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            var list = new List<int>();
            var repeatedNumbers = new HashSet<int>();
            for (int i = 0; i < entries; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (list.Contains(number))
                {
                    repeatedNumbers.Add(number);
                }
                list.Add(number);
               
            }
            if (repeatedNumbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            Console.WriteLine(String.Join(" ", repeatedNumbers));
        }
    }
}
