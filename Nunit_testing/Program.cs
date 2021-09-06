using System;
public class Tobinary
{
       public static void Main(string[] args)
    {
        Console.WriteLine("Enter input for conversion of binary:");
        int input = Convert.ToInt32(Console.ReadLine());
        string binary = string.Empty;
        while (input > 0)
        {
            int addBinary = input % 2;
            binary = addBinary + string.Empty + binary;
            input = input / 2;
        }

        Console.WriteLine(binary);
        string string1 = binary.Substring(0, binary.Length / 2);
        string string2 = binary.Substring(binary.Length / 2, binary.Length - (binary.Length / 2));
        Console.WriteLine(string1);
        Console.WriteLine(string2);
        int b=(Convert.ToInt32(string2 + string1));
        Console.WriteLine(b);

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
