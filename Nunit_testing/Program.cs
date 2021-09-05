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
        /* switch (h)
        {
            case 0:
                Console.WriteLine("Saturday");
                break;

            case 1:
                Console.WriteLine("Sunday");
                break;

            case 2:
                Console.WriteLine("Monday");
                break;

            case 3:
                Console.WriteLine("Tuesday");
                break;

            case 4:
                Console.WriteLine("Wednesday");
                break;

            case 5:
                Console.WriteLine("Thursday");
                break;

            case 6:
                Console.WriteLine("Friday");
                break;
        }*/
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
       // DateTime dt = new DateTime(y, d, m);
        
        //Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);
    }
}