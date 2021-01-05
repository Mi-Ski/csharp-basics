using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 25;
            double[] tab = new double[N];

            for (int i = 0; i < N; i++) tab[i] = i * i;
            foreach (el in tab)

            Console.Write("{0}, ",el);
        }
    }
}
