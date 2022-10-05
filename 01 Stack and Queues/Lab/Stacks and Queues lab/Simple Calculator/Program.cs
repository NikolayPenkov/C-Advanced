using System;
using System.Collections;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Stack stack = new Stack(input);
            var sum = 0;
            var currNum = 0;
            var curNum2 = 0;
            var sign = "";
            for (int i = 0; i <= stack.Count; i++)
            {
                string currSign = stack.Peek().ToString();
                if (currSign == "-")
                {
                    stack.Pop();
                    sign = stack.Peek().ToString();
                    currNum = int.Parse(sign);
                    stack.Pop();
                    sum -= currNum;
                }
                else   if (currSign == "+")
                {
                    stack.Pop();
                    sign = stack.Peek().ToString();
                    currNum = int.Parse(sign);
                    stack.Pop();
                    sum += currNum;
                }
                else
                {
                    sum += int.Parse(currSign);
                    stack.Pop();
                }
                if (sum < 0)
                {
                    sum = Math.Abs(sum);
                }
                if (stack.Count == 0)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
