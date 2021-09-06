using System;
public class Tobinary
{       
       public static void Main(string[] args)
    {
        Console.WriteLine("Enter input for conversion of binary:");
        int n = Convert.ToInt32(Console.ReadLine());
        string binary = string.Empty;
        while (n > 0)
        {
            int addBinary = n % 2;
            binary = addBinary + string.Empty + binary;
            n = n / 2;
        }
        Console.WriteLine(binary);
        
        //swapping binary nibb
        string str1 = binary.Substring(0, binary.Length / 2);
        string str2 = binary.Substring(binary.Length / 2, binary.Length - (binary.Length / 2));
        Console.WriteLine(str1);
        Console.WriteLine(str2);
        int b=(Convert.ToInt32(str2 + str1));
        Console.WriteLine(b);

        //converting to decimal
        double decimalValue = 0;
        int count = 0;
        while (b > 0)
        {
            int power = b % 10;
            decimalValue += Math.Pow(2, count) * power;
            b = b / 10;
            count++;  
        }
        Console.WriteLine(decimalValue);

    }


}
