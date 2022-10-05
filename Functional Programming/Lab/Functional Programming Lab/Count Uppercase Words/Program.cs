using System;

namespace Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> CapitalWord = i => char.IsUpper(i[0]);
            Console.WriteLine(string.Join(Environment.NewLine, 
                Array.FindAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                , CapitalWord)));
         
        }
    }
}
