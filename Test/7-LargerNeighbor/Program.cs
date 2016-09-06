using System;

namespace LargerNeighbor
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter sequence of numbers:");
			string sequence = Console.ReadLine();
            if (!string.IsNullOrEmpty(sequence))
		    {
		        string[] arrNumbers = sequence.Split(' ');
		        int[] number = new int[arrNumbers.Length];
		        for (int i = 0 ;i < arrNumbers.Length - 1; i++)
		        {
		            number[i] = Convert.ToInt32(arrNumbers[i]);
		        }
		        Console.WriteLine("Larger Numbers from neighbors:");
		        for (int pos = 1; pos < number.Length - 1; pos++)
		        {
		            int next = pos + 1;
		            int prev = pos - 1;
		            if (number[prev] < number[pos] && number[pos] > number[next])
		            {
		                Console.WriteLine(number[pos]);
		            }
		        }
		    }
		    else
		    {
		        Console.WriteLine("Incorrect input.");
		    }
		    Console.ReadLine();
		}
	}
}
