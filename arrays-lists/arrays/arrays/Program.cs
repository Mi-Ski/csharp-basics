using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // array: a fixed number of values of a particular type
            // 2 types: single dimensional, multi dimensional
            // single dimensional:  var number = new int[5]{1,2,3,4,5};
            // multi dimensional arrays: 2 types - rectangular and jagged
            // rectangular arrays: each row has the same ammount of columns
            // jagged arays: an "array of arrays"

            // declaring a 2-dimensional rectangular array:
            // var matrix = new int[3,5];
            // ^3 rows, 5 columns

            var matrix = new int[3, 5]
            {
                {1,2,3,4,5 },
                {6,7,8,9,10 },
                {11,12,13,14,15 }
            };
            var element = matrix[1, 3]; // 9
            Console.WriteLine(element);

            // jagged arrays:
            var array = new int[3][]; // declaring the top level array first
            // initializing each element of this array to a different array
            array[0] = new int[4] { 1, 2, 3, 4 };
            array[1] = new int[8] { 5, 6, 7, 8, 9, 10, 11, 12 };
            array[2] = new int[2] { 13, 14 };
            Console.WriteLine(array[1][7]); // 12
        }
    }
}
