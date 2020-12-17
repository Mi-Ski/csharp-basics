using System;

namespace c_
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            //converting enums to and from integers
            var Method = ShippingMethod.RegularAirMail;
            // System.Console.WriteLine((int)Method);

            // using casting to convert integers into shipping methods
            // var MethodID = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine((ShippingMethod)MethodID);

            // System.Console.WriteLine(Method.ToString());

            //converting a string to an enum
            var MethodName = Console.ReadLine();
            //parsing the string to a different type
            var shippingMethodFromString = Enum.Parse(typeof(ShippingMethod), MethodName);
            // ^Enum.Parse returns an object, casting that object to a shipping method
            System.Console.WriteLine((int)shippingMethodFromString);
        }
    }
}
