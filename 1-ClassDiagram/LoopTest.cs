using System;

class LoopTest
{
    public static void Main(string [] args)
    {
        Console.Write("Enter your name: ");
		string name= Console.ReadLine();
		
		Console.WriteLine("\nUsing for loop:");
        for (int i=0; i<name.Length; i++)
        {
            Console.Write(name[i]);
        }
        Console.WriteLine("\nUsing while loop:");
        
		int j=0;
        while (j<name.Length)
        {
            Console.Write(name[j]);
            j++;
        }
    }
}