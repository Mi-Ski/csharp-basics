using System;

namespace zad5
{
   class Program
   {
      static void Main(string[] args)
      {
         while (true)
         {
            Console.WriteLine("*** Wybierz podprogram ***");
            Console.WriteLine("(1) Obliczanie miejsc zerowych funkcji kwadratowej");
            Console.WriteLine("(2) Obliczanie miejsc zerowych funkcji liniowej");
            Console.WriteLine("(3) Wyjście");

            sbyte opcja = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine();

            if (opcja == 1)
            {
               funkcjaKwadratowa();
            }
            else if (opcja == 2)
            {
               funkcjaLiniowa();
            }
            else if (opcja == 3)
            {
               break;
            }
            else continue;
         }
      }

      // Główne podprogramy
      static void funkcjaKwadratowa()
      {
         Console.WriteLine("*OBLICZANIE MIEJSC ZEROWYCH FUNKCJI KWADRATOWEJ*");
         Console.WriteLine("Wzór: ax^(potęga) + bx + c");
         Console.WriteLine();

         Console.Write("Podaj \"a\" funkcji kwadratowej: ");
         var a = Convert.ToSByte(Console.ReadLine());

         Console.Write("Podaj do jakiej potęgi jest podniesione \"ax\" funkcji kwadratowej (jeśli nie ma potęgi wpisz \"1\"): ");
         var potegaA = Convert.ToSByte(Console.ReadLine());

         Console.Write("Podaj \"b\" funkcji kwadratowej: ");
         var b = Convert.ToSByte(Console.ReadLine());

         Console.Write("Podaj \"c\" funkcji kwadratowej: ");
         var c = Convert.ToSByte(Console.ReadLine());


         if (potegaA == 1)
         {
            // dodawanie a do b, bo ax^1 = ax, czyli doda sie do bx
            b += a;
            obliczanieX0liniowej(b, c);
         }

         else if (potegaA == 0)
         {
            // dodawanie a do c, bo ax^0 = a, czyli doda sie do c
            c += a;
            obliczanieX0liniowej(b, c);
         }

         else
         {
            var wynikDelta = delta(a, b, c);
            Console.WriteLine("Delta to: " + wynikDelta);

            if (wynikDelta > 0)
            {
               Console.WriteLine("Funkcja kwadratowa ma 2 miejsca zerowe.");
               obliczanie2X0kwadratowej(a, b, wynikDelta);
            }
            else if (wynikDelta < 0)
            {
               Console.WriteLine("Funkcja kwadratowa nie ma miejsc zerowych.");
            }
            else
            {
               Console.WriteLine("Funkcja kwadratowa ma jedno miejsce zerowe.");
               obliczanieX0kwadratowej(a, b);
            }
         }
         Console.WriteLine();
      }

      static void funkcjaLiniowa()
      {
         Console.WriteLine("*OBLICZANIE MIEJSC ZEROWYCH FUNKCJI LINIOWEJ*");

         Console.Write("Podaj współczynnik \"a\" funkcji liniowej: ");
         var a = Convert.ToSByte(Console.ReadLine());

         Console.Write("Podaj współczynnik \"b\" funkcji liniowej: ");
         var b = Convert.ToSByte(Console.ReadLine());

         if (a > 0)
         {
            System.Console.WriteLine("Ta funkcja liniowa jest funkcją rosnącą.");
            obliczanieX0liniowej(a, b);
            System.Console.WriteLine();
         }
         else if (a < 0)
         {
            System.Console.WriteLine("Ta funkcja liniowa jest funkcją malejącą.");
            obliczanieX0liniowej(a, b);
            System.Console.WriteLine();
         }
         else if ((a==0) && (b != 0))
         {
           System.Console.WriteLine("Ta funkcja liniowa jest stała i różna od zera. Nie ma miejsc zerowych"); 
           System.Console.WriteLine();
         }
         else
         {
            System.Console.WriteLine("Ta funkcja liniowa jest stała, równa zero");
            System.Console.WriteLine();
         }
      }

      // Funcje dodatkowe
      static double delta(sbyte a, sbyte b, sbyte c)
      {
         var delta = Math.Pow(b, 2) - 4 * a * c;
         return delta;
      }

      static void obliczanie2X0kwadratowej(double a, double b, double delta)
      {
         var x1 = ((b * (-1)) - Math.Sqrt(delta)) / (2 * a);
         var x2 = ((b * (-1)) + Math.Sqrt(delta)) / (2 * a);

         Console.WriteLine("Miejsca zerowe to: x1={0}, x2={1}", x1, x2);
      }

      static void obliczanieX0kwadratowej(double a, double b)
      {
         Console.WriteLine("x0 tej funkcji kwadratowej to: " + (b * (-1)) / (2 * a));
      }

      static void obliczanieX0liniowej(double a, double b)
      {
         Console.WriteLine("x0 tej funkcji liniowej to: " + (b * (-1)) / a);
      }
   }
}