using System;
using arrays;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3] {3,5,56};
            System.Console.WriteLine(numbers[1]+numbers[0]+numbers[2]);

            var flags = new bool[3];
            flags[2] = true;
            System.Console.WriteLine(flags[0]);
            System.Console.WriteLine(flags[1]);
            System.Console.WriteLine(flags[2]);

            var names = new string[3] { "Jack", "Jane", "Jill" };
            string listNames = string.Join(", ", names);
            System.Console.WriteLine(listNames);

            Strings potega = new Strings();
            var variable = potega.Potega(3);
            System.Console.WriteLine(variable);

            var text = "Hi X\nLook, I made a new line!\nJust like that!\\";
            System.Console.WriteLine(text);

            var verbatimString = @"Lorem ipsum
dolor sit amet";
            System.Console.WriteLine(verbatimString);
        }
    }
}
