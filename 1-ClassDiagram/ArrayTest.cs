using System;
class ArrayTest
{
	public static void Main(string [] args)
	{
		string[] nicePlaces ={"Dharavi","Republic of Vichumbe","Sakinaka","Chinchpokli","Bhendi Bazaar"};
		
		Console.WriteLine("using for loop:");
		for (int i=0;i<nicePlaces.Length;i++)
		{
			Console.WriteLine(i+". "+nicePlaces[i]);
		}
		
		Console.WriteLine("Using foreach loop:");
		foreach( string place in nicePlaces)
		{
			Console.WriteLine(place);
		}
	}
}