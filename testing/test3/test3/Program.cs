using System;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Silnia(6));
            Console.ReadKey(true);
        }
        static ulong Silnia(ulong n)
        {
            if (n < 2) return 1;
            return n * Silnia(5);
        }
    }
}
