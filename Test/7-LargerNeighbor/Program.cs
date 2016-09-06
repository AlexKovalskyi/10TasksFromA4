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
		        for (int i = 0 ;i < arrNumbers.Length; i++)
		        {
		            number[i] = Convert.ToInt32(arrNumbers[i]);
		        }

		        // 1. Requirements 
                // 2. Readability
                // 3. Performance
		        Console.WriteLine("Larger Numbers from neighbors:");
		        for (int pos = 1; pos < number.Length - 1; pos++)
		        {
		            int next = pos + 1;
		            int prev = pos - 1;
                    if (number[prev] < number[pos] && number[pos] > number[next])
                    {
                        Console.WriteLine(number[pos]);
                    }
                    if (pos == 1 && number[prev] > number[pos])
		            {
		                Console.WriteLine(number[prev]);
		            }
		            else if (pos == number.Length - 2 && number[next] > number[pos])
		            {
		                Console.WriteLine(number[next]);
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
