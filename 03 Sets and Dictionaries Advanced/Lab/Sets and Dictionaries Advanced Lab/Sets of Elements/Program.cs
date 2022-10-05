using System;
using System.Collections.Generic;

namespace Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var lenghtOfSets = Console.ReadLine().Split(" ");
           var lenghtfirstSet = int.Parse(lenghtOfSets[0]);
           var lenghtsecondSet = int.Parse(lenghtOfSets[1]);
            List<int> listOne = new List<int>();
            var listTwo = new List<int>();
            var sameIntegersList = new HashSet<int>();
            for (int i = 0; i < lenghtfirstSet; i++)
            {
                var currNum = int.Parse(Console.ReadLine());
                listOne.Add(currNum);
            }
            for (int i = 0; i < lenghtsecondSet; i++)
            {
                var currNum = int.Parse(Console.ReadLine());
                listTwo.Add(currNum);
            }
            for (int i = 0; i < listOne.Count; i++)
            {
                int curNumOfHashSetOne = listOne[i];
                //You can use for that .IntersectWith()
                if (listTwo.Contains(curNumOfHashSetOne))
                {
                    sameIntegersList.Add(curNumOfHashSetOne);
                }
            }
            Console.WriteLine(string.Join(" ", sameIntegersList));
        }
    }
}
