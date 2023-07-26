//0 and 1 are not prime numbers
using System;

class CheckPrimeNumber
{
	public static void Main(string[] args)
	{
		Console.Write("Enter a number: ");
		int number = int.Parse(Console.ReadLine());

		if (IsPrime(number))
		{
			Console.WriteLine(number+" is prime");
		}
		else
		{
			Console.WriteLine(number+ " is not prime");
		}
	}
	public static bool IsPrime(int num)
	{
		if(num<=1)
			return false;
		
		for (int i=2;i<=Math.Sqrt(num); i++)
		{
			if(num%i == 0)
				return false;
		}
		return true;
	}
}
