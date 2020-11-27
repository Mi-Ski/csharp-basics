using System;
using _21.Math;  

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Person();
            user.firstName = Convert.ToString(System.Console.ReadLine());
            user.lastName = Convert.ToString(System.Console.ReadLine());
            user.Introduce();

            Calculator calc = new Calculator();
            var result = calc.Add(23, 4);
            System.Console.WriteLine(result);
        }
    }
}
