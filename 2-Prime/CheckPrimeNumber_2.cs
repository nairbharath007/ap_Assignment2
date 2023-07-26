//0 and 1 are not prime numbers
/*Square root used as
1.reduced iterations-divisor can be found within the sq.root
2.optimization- w/o sq.root, n/2 can be computationally expensive for larger nos
3.performance- from O(n) to O(√n), algo becoms faster as n increases.
*/ 
using System;

class CheckPrimeNumber
{
	public static void Main(string[] args)
	{
		Console.Write("Enter a number: ");
		int number = int.Parse(Console.ReadLine());

		bool isPrime=true;

		if(number<=1)
		{
			isPrime=false;
		}
		else
		{
			for (int i=2;i<=Math.Sqrt(number); i++)
			{
				if(number%i == 0)
				{
					isPrime=false;
					break;
				}
			}
		}
		if(isPrime)
		{
			Console.WriteLine(number+" is prime");
		}
		else
		{
			Console.WriteLine(number+" is not prime");
		}
	}
			
}
