using System;
class Sample
{
    static void dayofweek(int day,int month, int year)
    {
        int q = day;
        int m = month;
        int k = year % 100;
        int j = year / 100;
        int h = q + 13 * (m + 1) / 5 + k + k / 4 + j / 4 + 5 * j;
        h = h % 7;
        string[] days = { "Saturday", "Sunday","Monday","Tuesday","Wednesday","Thursday","Friday" };
        Console.WriteLine("Day for given input is :" +days[h]);
    }

    public static void Main()
    {
        Console.WriteLine("Enter year :");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter date :");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter month  :");
        int m = Convert.ToInt32(Console.ReadLine());
        dayofweek(d,m,y);
    }
}