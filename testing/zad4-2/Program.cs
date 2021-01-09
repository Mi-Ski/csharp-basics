using System;

namespace zad4_2
{
   class Program
   {
      static void Main(string[] args)
      {
         System.Console.Write("Podaj liczbę naturalną n: ");
         var n = Convert.ToByte(Console.ReadLine());

         Console.Write("Podaj liczbę wymierną r: ");
         var r = Convert.ToDouble(Console.ReadLine());

         Console.Write("Podaj liczbę wymierną q: ");
         var q = Convert.ToDouble(Console.ReadLine());

         var tablica = new int[n, 5];
         int a = 1;
         int b = 1;
         int c = 0;
         double wyrazCiaguArt = 0;
         double a1ciaguArt = 0;
         double sumaPierwszychNwyrazow = 0;
         double wyrazCiaguGeo = 1;
         double sumaPierwszychWyrazowGeo = 0;

         for (byte i = 0; i < n; i++)
         {
            // Fibonacci (c)
            c = a + b;
            a = b;
            b = c;
            tablica[i, 0] = c;

            // Ciąg arytmetyczny
            tablica[i, 1] = Convert.ToInt32(wyrazCiaguArt);
            wyrazCiaguArt += r;

            // Suma i pierwszych wyrazów ciągu arytmetycznego
            tablica[i, 2] = Convert.ToInt32(sumaPierwszychNwyrazow);
            sumaPierwszychNwyrazow = ((a1ciaguArt + wyrazCiaguArt) / 2) * r;
      
            // Ciąg geometryczny
            tablica[i, 3] = Convert.ToInt32(wyrazCiaguGeo);
            wyrazCiaguGeo *= q;

            // Suma i pierwszych wyrazow ciągu geometrycznego
            tablica[i, 4] = Convert.ToInt32(sumaPierwszychNwyrazow);
            sumaPierwszychWyrazowGeo = (wyrazCiaguGeo * (1 - Math.Pow(q, i)) / (1 - q));
         }

         // Print tablicy
         for (var x = 0; x < n; x++)
         {
            for (var y = 0; y < 5; y++)
            {
               System.Console.Write("{0, 5}  ", tablica[x,y]);
            }
            System.Console.WriteLine();
         }
      }
   }
}
