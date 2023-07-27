using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Enter valid numbers as arguments.");
            return;
        }

        int count = args.Length;
        int sum = 0;
        int max = int.Parse(args[0]);
        int min = int.Parse(args[0]);

        for (int i=1;i< args.Length;i++)
        {
				int num=int.Parse(args[i]);
                sum += num;
                max = Math.Max(max, num);
                min = Math.Min(min, num);
        }
         

        float average = (float)sum / count;

        Console.WriteLine("Number of elements: "+count);
        Console.WriteLine("Sum of all elements: "+sum);
        Console.WriteLine("Average: "+average);
        Console.WriteLine("Maximum: "+max);
        Console.WriteLine("Minimum: "+min);
    }
}
