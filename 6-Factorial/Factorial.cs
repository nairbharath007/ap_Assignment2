using System;

class Factorial
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
		int factorial=1;

        if (number < 0)
        {
            Console.WriteLine("Enter positive integers only.");
            return;
        }

        for (int i=1; i<=number; i++)
        {
            factorial*=i;
        }

        Console.WriteLine("Factorial of "+number+" is: "+factorial);
    }
}
