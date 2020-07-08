using System;
using System.Collections.Generic;

namespace GenericScale
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var elements = new EqualityScale<int>(4, 4);

            Console.WriteLine(elements.AreEqual());
        }
    }
}
