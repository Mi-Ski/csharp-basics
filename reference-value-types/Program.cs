using System;

// 2 main types in c# from which we create new types: Classes and Structures
// Structures: Primitive Types, Custom structures - no more than 8 bytes - value types
// Classes: Arrays, Strings, Custom classes - reference types
/*
    Value types:
        *allocated on stack
        *memory allocation done automatically
        *immediately removed when out of scope
    Reference types:
        *you need to allocate memory
        *memory allocated on heap
        *garbage collected by CLR
*/
namespace reference_value_types
{
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         // value types
    //         var a = 10;
    //         var b = a;
    //         b++;
    //         System.Console.WriteLine("a: {0}, b: {1}", a, b); //a: 10, b: 11
    //         // reference types
    //         var array1 = new int[3]{3, 4, 7};
    //         var array2 = array1;
    //         array2[0] = 9;
    //         System.Console.WriteLine(array1[0]); // 9
    //         //when copying reference types address to the memory is copied, not the actual value
    //     }
    // }


    class Person
    {
        public int Age;
    }

    class PersonOperations
    {
        static void Main(string[] args)
        {
            var number = 5;
            Increment(number);
            System.Console.WriteLine(number);
            // returns 1 since it's a value type, number in the Increment function is a differnet variable 
            var person = new Person() {Age = 21};
            MakeOld(person);
            System.Console.WriteLine(person.Age);
        }
        
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person thingToChange)
        {
            thingToChange.Age += 102;
        }
    }
}
