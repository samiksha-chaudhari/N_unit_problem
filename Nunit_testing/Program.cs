using System;
namespace Nunit_testing
{
    class Sqrt
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter number :");
            int c = Convert.ToInt32(Console.ReadLine());

            double epsilon = 1e-15;    
            double t = c;             

            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            Console.WriteLine("square root is :" +t);
        }
        
    }
}