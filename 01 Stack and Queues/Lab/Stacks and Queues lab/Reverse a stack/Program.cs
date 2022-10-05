using System;
using System.Collections.Generic;

namespace Reverse_a_stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<char> reverseStack = new Stack<char>(input);
            while (reverseStack.Count>0)
            {
                Console.Write(String.Join(" ", reverseStack.Peek()));
                reverseStack.Pop();
            }
        }
    }
}
