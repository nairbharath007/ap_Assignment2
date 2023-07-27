using System;

class ReverseNumber{
	public static void Main(string[] args)
	{
		Console.Write("Enter a number: ");
		int number=int.Parse(Console.ReadLine());
		int reversedNumber=0;

		while(number != 0)
		{
			int reminder=number%10;
			reversedNumber=reversedNumber*10+reminder;
			number/=10;
		}   
		Console.Write("Reversed Number: "+reversedNumber);   
	}
}