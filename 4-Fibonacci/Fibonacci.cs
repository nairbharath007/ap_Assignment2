using System;

class Fibonacci
{
	public static void Main(string[] args)
	{
		int totalNumbers=8;
		int previousNumber=0;
		int currentNumber=1;
		
		Console.Write("Fibonacci Sequence: "+previousNumber+ " " +currentNumber);
		
		for(int i=2;i<totalNumbers;i++)
		{
			int nextNumber= previousNumber+ currentNumber;
			Console.Write(" "+ nextNumber);
			
			previousNumber=currentNumber;
			currentNumber=nextNumber;
		}
		Console.WriteLine();
	}
}
		