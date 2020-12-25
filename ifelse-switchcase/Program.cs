using System;

namespace ifelse_switchcase
{
    public enum Seasons
    {
        Spring,
        Summer,
        Autumn,
        Winter
    };

    class Program
    {
        static void Main(string[] args)
        {
            // bool isGoldCustomer = true;
            
            // // if (isGoldCustomer)
            // // {
            // //     price = 19.95f;
            // // }
            // // else
            // // {
            // //     price = 29.95f;
            // // }
            // float price = (isGoldCustomer) ? 12.21f : 53.31f;
            // System.Console.WriteLine(price);
            var season = Seasons.Autumn;
            switch (season)
            {
                case Seasons.Autumn:
                case Seasons.Winter:
                    System.Console.WriteLine("wake me up when the weather's better");
                    break;
                
                case Seasons.Spring:
                    System.Console.WriteLine("s p r i n g");
                    break;
                
                case Seasons.Summer:
                    System.Console.WriteLine("getting a bit hot innit?");
                    break;
                
                default:
                    System.Console.WriteLine("There are only 4 seasons, insert a correct one, goofball!");
                    break;
            };
        }
    }
}
