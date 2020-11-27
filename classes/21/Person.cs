using System;

namespace _21
{
    public class Person 
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            System.Console.WriteLine("Hello, " + firstName + " " + lastName);
        }
    }
}