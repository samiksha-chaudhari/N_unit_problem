using System;

namespace Nunit_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, y, r;
            double rate, a, b, c, d, pay;
            Console.WriteLine("Enter the Principal : ");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Year : ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Rate : ");
            r = int.Parse(Console.ReadLine());
            int n = (12 * y);
            Console.WriteLine("n : " +n);
            rate = (r / (12*100));
            Console.WriteLine("rate :" +rate);
            a = (p * rate);
            Console.WriteLine("a : " +a);
            b = (1 + rate);
            Console.WriteLine("b : " +b);
            c = (1 - b);
            Console.WriteLine("c : " +c);
            d =Math.Pow(c, (-n));
            Console.WriteLine("d : "+d);
            pay = (a / d);
            Console.WriteLine(pay);
        }
    }
}
