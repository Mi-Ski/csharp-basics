using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculations.Greetings();
            Console.WriteLine(Calculations.calculateAge(1974));
        }
    }

    class Calculations
    {
        static int variable1 = 10;
        public static void Greetings()
        {
            Console.WriteLine("Hello everyone");
            variable1++;
        }

        public static int calculateAge(int yearOfBirth)
        {
            var age = DateTime.Now.Year - yearOfBirth + variable1;
            return age;
        }
    }
}
