using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = new string[12] { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
            int numberOfDays;

            foreach (string el in months)
            {
                switch (el)
                {
                    case "february":
                        numberOfDays = 28;
                        break;

                    case "april":
                    case "june":
                    case "august":
                    case "september":
                    case "november":
                        numberOfDays = 30;
                        break;

                    default:
                        numberOfDays = 31;
                        break;
                }
                Console.WriteLine(el + " " + numberOfDays);
            }
        }
    }
}
