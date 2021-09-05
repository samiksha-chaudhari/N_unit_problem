using System;

namespace TempConver
{
    class TempConver
    {
        static void Main()
        {
            double cel, far;
            Console.WriteLine("Enter the Temperature in Celsius(°C) : ");
            cel = int.Parse(Console.ReadLine());
            far = (cel * 9) / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit is : " + far + "°F");
            Console.WriteLine("Enter the value of Fahrenheit:");
            far = Convert.ToDouble(Console.ReadLine());
            cel = (far - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celsius is: " + cel + "°C");
            
        }
    }
}