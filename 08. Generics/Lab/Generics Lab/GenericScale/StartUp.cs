using System;

namespace GenericScale
{
    public class StartUp
    {
        public void Main(string[] args)
        {
            EqualityScale<int> scale = new EqualityScale<int>(5, 5);
            scale.AreEqual();
            Console.WriteLine(scale.AreEqual());
        }
    }
}
