using System;

namespace factorial
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj liczbę n silni: ");
            uint n = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Silnia: {0}", factorialCalculator(n));
            Console.ReadKey(true);
        }
        static ulong factorialCalculator(uint x)
        {
            ulong product = 1;
            for (uint i = 1; i <= x; i++)
            {
                product *= i;
            }
            return product;
        }
    }
}
