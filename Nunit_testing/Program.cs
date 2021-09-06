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
    }
}