using System;

namespace test2
{
    class Osoba
    {
        static void Main(string[] args)
        {
            string imie, nazwisko, drugieImie, tytul, narodowosc, sklejonyString, plec;
            uint wiek;

            imie = UstawImie();
            drugieImie = UstawDrugieImie();
            nazwisko = UstawNazwisko();
            tytul = UstawTytuly();

            sklejonyString = ToString(tytul, imie, drugieImie, nazwisko);
            Console.WriteLine(sklejonyString);

            plec = UstawPlec();
            Console.WriteLine(plec);

            wiek = UstawWiek();
            narodowosc = UstawNarodowosc();
            Console.WriteLine(wiek + " " + narodowosc);

            string pesel = UstawPesel(plec, wiek);
            Console.WriteLine(pesel);

            Console.ReadKey(true);
        }
        // DO SKLEJENIA
        static string UstawImie()
        {
            Console.Write("Podaj swoje imię: ");
            var imie = Convert.ToString(Console.ReadLine());
            return imie;
        }

        static string UstawNazwisko()
        {
            Console.Write("Podaj swoje nazwisko: ");
            var nazwisko = Convert.ToString(Console.ReadLine());
            return nazwisko;
        }

        static string UstawDrugieImie()
        {
            Console.Write("Podaj swoje drugie imię/imiona (jesli ich nie masz nacisnij Enter): ");
            var drugieImie = Convert.ToString(Console.ReadLine());
            return drugieImie;
        }

        static string UstawTytuly()
        {
            Console.Write("Podaj swoje tytuly: ");
            var tytuly = Convert.ToString(Console.ReadLine());
            return tytuly;
        }
        // RESZTA INFO
        static string UstawNarodowosc()
        {
            Console.Write("Podaj swoją narodowosc: ");
            var narodowosc = Convert.ToString(Console.ReadLine());
            return narodowosc;
        }

        static uint UstawWiek()
        {
            Console.Write("Podaj swój wiek: ");
            var wiek = Convert.ToUInt32(Console.ReadLine());
            return wiek;
        }
        // SKLEJANIE STRINGA
        static string ToString(string tytul, string pImie, string dImie, string nazwisko)
        {
            if (dImie.Length > 1)
            {
                string sklejone = String.Concat(tytul + " " + pImie + " " + dImie + " " + nazwisko);
                return sklejone;
            }
            else
            {
                string sklejone = String.Concat(tytul + " " + pImie + " " + nazwisko);
                return sklejone;
            }
        }
        // PŁEĆ
        static string UstawPlec()
        {
            string ustawionaPlec = "";

            Console.Write("Napisz swoją płeć: ");
            string odpowiedz = Convert.ToString(Console.ReadLine());

            if (odpowiedz == "m" || odpowiedz == "male" || odpowiedz == "mężczyzna" || odpowiedz == "mezczyzna" || odpowiedz == "chłopak" || odpowiedz == "chłopiec")
            {
                ustawionaPlec = "mężczyzna";
            }
            else if (odpowiedz == "k" || odpowiedz == "f" || odpowiedz == "female" || odpowiedz == "kobieta" || odpowiedz == "dziewczyna" || odpowiedz == "dziewczynka")
            {
                ustawionaPlec = "kobieta";
            }
            return ustawionaPlec;
        }
        // PESEL
        static string UstawPesel(string plec, uint wiek)
        {
            string pesel = "";
            string plecZPeselu = "";
            /*uint wiekZPeselu = 0;*/
            /*uint rokUrodzenia = Convert.ToUInt32(DateTime.Now.Year - wiek);*/

            Console.WriteLine("Napisz swój nr PESEL: ");
            string podanyPesel = Convert.ToString(Console.ReadLine());

            char[] peselCharArr = podanyPesel.ToCharArray();


            // sprawdzanie plci z nr pesel
            if (peselCharArr[9] % 2 == 0)
            {
                plecZPeselu = "kobieta";
            }
            else
            {
                plecZPeselu = "mężczyzna";
            }

            // sprawdzanie wieku z nr pesel
            String dwiePierwszeCyfryPeselu = String.Concat(Convert.ToString(peselCharArr[0]) + Convert.ToString(peselCharArr[1]));
            string stringRokUrodzenia = Convert.ToString(DateTime.Now.Year - wiek);

            char[] rokUrodzeniaCharArr = stringRokUrodzenia.ToCharArray();
            String dwieOstatnieCyfryRokuUrodzenia = String.Concat(Convert.ToString(rokUrodzeniaCharArr[2]) + Convert.ToString(rokUrodzeniaCharArr[3]));

            // sprawdzanie warunku spełnialności nr pesel

            bool warunek = (9 * Char.GetNumericValue(peselCharArr[0]) + 7 * Char.GetNumericValue(peselCharArr[1]) + 3 * Char.GetNumericValue(peselCharArr[2]) + 1 * Char.GetNumericValue(peselCharArr[3]) + 9 * Char.GetNumericValue(peselCharArr[4]) + 7 * Char.GetNumericValue(peselCharArr[5]) + 3 * Char.GetNumericValue(peselCharArr[6]) + 1 * Char.GetNumericValue(peselCharArr[7]) + 9 * Char.GetNumericValue(peselCharArr[8]) + 7 * Char.GetNumericValue(peselCharArr[9])) % 10 == Char.GetNumericValue(peselCharArr[10]);

            if ((peselCharArr.Length == 11) && (plecZPeselu == plec) && (dwiePierwszeCyfryPeselu == dwieOstatnieCyfryRokuUrodzenia) && warunek)
            {
                Console.WriteLine("wszystko sie zgadza");
                return podanyPesel;
            }
            else
            {
                Console.WriteLine(peselCharArr[1]);
                Console.WriteLine(3 * Char.GetNumericValue(peselCharArr[1]));
                Console.WriteLine("podaj prawdziwy pesel!");
                return podanyPesel;
            }
        }
    }
}
