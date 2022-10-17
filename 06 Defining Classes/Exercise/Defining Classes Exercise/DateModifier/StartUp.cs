using System;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endtDate = Console.ReadLine();

            int difference = DateModifier.DateDifference(startDate, endtDate);

            Console.WriteLine(difference);
        }
    }
}
