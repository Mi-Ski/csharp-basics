using System;

namespace zaliczenie_michal_skiba
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("*** Wybierz podprogram ***");
                Console.WriteLine("(1) Kwadraty");
                Console.WriteLine("(2) Sześciany");
                Console.WriteLine("(3) Pierwiastki");
                Console.WriteLine("(0) Wyjście");
                Console.WriteLine();

                sbyte opcja = Convert.ToSByte(Console.ReadLine());

                if (opcja == 1)
                {
                    kwadraty();
                }
                else if (opcja == 2)
                {
                    szesciany();
                }
                else if (opcja == 3)
                {
                    pierwiastki();
                }
                else if (opcja == 0)
                {
                    break;
                }
                else continue;
            }
        }

        static void kwadraty()
        {
            Console.WriteLine("Obliczanie kwadratu. Podaj liczbę M: ");
            var liczba = Convert.ToUInt32(Console.ReadLine());

            for (var i = 0; i <= liczba; i++)
            {
                Console.Write(Math.Pow(i,2) + " ");
            }
        }

        static void szesciany()
        {
            Console.WriteLine("Obliczanie szescianu. Podaj liczbę M: ");
            var liczba = Convert.ToUInt32(Console.ReadLine());

            for (var i = 0; i <= liczba; i++)
            {
                Console.Write(Math.Pow(i, 3) + " ");
            }
        }

        static void pierwiastki()
        {
            Console.WriteLine("Obliczanie pierwiastka. Podaj liczbę M: ");
            var liczba = Convert.ToUInt32(Console.ReadLine());

            for (var i = 0; i <= liczba; i++)
            {
                Console.Write(Math.Sqrt(i) + " ");
            }
        }
    }
}
