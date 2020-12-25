using System;

namespace iteration_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // for foreach while do-while
            System.Console.WriteLine("for loop");
            for (var i = 0; i < 10; i++)
            {
                System.Console.WriteLine(i);
                if(i >= 7) break;
            }

            System.Console.WriteLine("foreach loop");
            var numbers = new int[5]{1,2,3,5,4};

            foreach (var i in numbers)
            {
                System.Console.WriteLine(i);
            }

            // System.Console.WriteLine("while loop");
            // while (true)
            // {
            //     System.Console.WriteLine(2);
            // }

            System.Console.WriteLine("do-while loop");
            var a = 10;
            do
            {
                ++a;
                System.Console.WriteLine(a);
            } while (a < 10);
        }
    }
}
