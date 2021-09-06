using System;
public class VENDING
{	public static void countCurrency(int amount)
	{
		int[] currency= new int[] { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
		int[] Counter = new int[10];

		for (int i = 0; i < 10; i++)
		{
			if (amount >= currency[i])
			{
				Counter[i] = amount / currency[i];
				amount = amount -Counter[i] * currency[i];
			}
		}

		Console.WriteLine("Notes Count :");
		for (int i = 0; i < 10; i++)
		{
			if (Counter[i] != 0)
			{
				Console.WriteLine(currency[i] + " * " + Counter[i]);
			}
		}
	}
	public static void Main()
	{
		Console.WriteLine("Enter amount:");
		int amount = Convert.ToInt32(Console.ReadLine());
		countCurrency(amount);
	}


}