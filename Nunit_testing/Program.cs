using System;

namespace Nunit_testing
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double p, y, r,n,rate, pay;
            Console.WriteLine("Enter the Principal : ");
            p = int.Parse(Console.ReadLine());  

            Console.WriteLine("Enter the Year : ");
            y = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the Rate : ");
            r = int.Parse(Console.ReadLine());
            
            n = (12 * y);
            //Console.WriteLine("n : " +n);
            rate = (r / (12*100));
            //Console.WriteLine("rate :" +rate);

            pay = (p * rate) / (1 - Math.Abs(Math.Pow((1 + rate), (-n))));
           
            Console.WriteLine("payment is :" +pay);
        }
    }
}
