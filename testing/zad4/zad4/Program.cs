using System;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Podaj pierwszy parametr tablicy: ");
                byte w = Convert.ToByte(Console.ReadLine());
                w++;

                Console.Write("Podaj drugi parametr tablicy: ");
                byte k = Convert.ToByte(Console.ReadLine());
                k++;

                var tablica = new int[w, k];
                for (byte i = 0; i < w; ++i)
                {
                    for (byte j = 0; j < k; ++j)
                    {
                        tablica[i, j] = Convert.ToInt32(Math.Pow(i, j));
                    }
                }

                for (byte i = 1; i < w; i++)
                {
                    for (byte j = 1; j < k; j++)
                    {
                        Console.Write(tablica[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey(true);
            }

            catch(OverflowException err)
            {
                Console.WriteLine(err);
            }
        }
    }
}
