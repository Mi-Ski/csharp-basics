using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   while (true)
               {
                   Console.WriteLine("Type your name: ");
                   var input = Console.ReadLine();

                   if (!String.IsNullOrWhiteSpace(input))
                   {
                       Console.WriteLine("@Echo: " + input);
                       // program continues on the beginning of the loop
                       continue;
                   }
                   break;
               }*/

            var random = new Random();
            const byte passwordLength = 12;
            char[] buffer = new char[passwordLength];

            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);

        }
    }
}
