using System;
using System.Collections.Generic;

namespace Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberOfUsernames = int.Parse(Console.ReadLine());

            //Dictionary<string, int> names = new Dictionary<string, int>();
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < numberOfUsernames; i++)
            {
                var curName = Console.ReadLine();
                if (!names.Contains(curName))
                {
                    names.Add(curName);
                }
                //if (!names.ContainsKey(curName))
                //{
                //    names.Add(curName, 1);
                //}
            }
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name.Key);
            //}
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
