using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> nums = new Stack<int>(numberInput); 
            string command = Console.ReadLine().ToLower();
           
            while (command != "end")
            {
                string[] commands = command.Split(" ");
                if (commands[0] == "add")
                {
                    nums.Push(int.Parse(commands[1]));
                    nums.Push(int.Parse(commands[2]));
                }
                if (commands[0] == "remove")
                {
                    var toBeRemoved = int.Parse(commands[1]);
                    if (toBeRemoved <= nums.Count)
                    {
                        for (int i = toBeRemoved; i > 0; i--)
                        {
                            nums.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            var sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
