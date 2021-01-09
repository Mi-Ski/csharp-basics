using System;

namespace test5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(f(4));
        }
        static int f(int x)

        {

            if (x > 1) return f(x - 1) + 2 * f(x
            - 2);

            else return x;

        }
    }
}
