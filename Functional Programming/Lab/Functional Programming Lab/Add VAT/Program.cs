using System;
using System.Linq;

namespace Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, string> vat = d => (d * 1.2M).ToString("F2");
            Console.WriteLine(String.Join(Environment.NewLine, Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .Select(vat)
                ));
        }
    }
}
