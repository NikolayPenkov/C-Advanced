using System;
using System.Collections;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfInputs = int.Parse(Console.ReadLine());
            Stack stack = new Stack();
            for (int i = 0; i < numbersOfInputs; i++)
            {
                int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                if (array[0] == 1)
                {
                    stack.Push(array[1]);
                }
                else if (array[0] == 2)
                {
                    stack.Pop();
                }
                else if (array[0] == 3)
                {
                    int max = 0;
                    foreach (int s in stack)
                    {
                        if (s > max)
                        {
                            max = s;
                        }
                    }
                    Console.WriteLine(max);
                }
                else if (array[0] == 4)
                {
                    int min = int.MaxValue;
                    foreach (int s in stack)
                    {
                        if (s < min)
                        {
                            min = s;
                        }
                    }
                    Console.WriteLine(min);
                }
            }
            //foreach (var s in stack)
            //{
               
            //    Console.Write($"{s}, ");
            //}
            for (int i = 1; i <= stack.Count; i++)
            {
                if (stack.Count == 1)
                {
                    Console.Write(String.Join(" ", stack.ToArray()));
                    break;
                }
                else
                {
                    Console.Write(string.Join(", ", stack.ToArray()));
                    stack.Pop();
                }
               
            }
        }
    }
}
