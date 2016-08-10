using System;
using System.Linq;

namespace Palindrome
{
	class Program
	{
		static void Main(string[] args)
		{
			PalindromWith2For();
		}
        //TODO: Implement again in other way with O(n) complicity. Big O
        
        //TODO: Implement again in other way with numeric numbers.

        //TODO: Implement again with while statement.
		private static void PalindromWith1For()
		{
			var number = (Console.ReadLine()).ToLower();
			char[] x = number.ToCharArray();
			var a = string.Copy(number);
			char[] arr = a.ToCharArray();
			Array.Reverse(arr);

			for (int i = 0;i < arr.Length/2;i++)
			{
			{

			}
			}
		}

		private static void PalindromWith2For()
		{
			var number = (Console.ReadLine()).ToLower();
			char[] numberArray = number.ToArray();
			int countMatches = 0;
			for (int i = 0; i<numberArray.Length/2;i++)
			{
				for (int j = numberArray.Length - 1 - i; j >=numberArray.Length/2;j--)
				{
					if (numberArray[i] == numberArray[j])
					{
						Console.WriteLine("{0} = {1}", numberArray[i], numberArray[j]);

						countMatches++;
						break;
					}
}
			}

			if (countMatches == numberArray.Length / 2)
			{
				Console.WriteLine("Number is Palindrome.");
			}
			else
			{
				Console.WriteLine("Number is doesn't palindrome.");
			}
			Console.ReadLine();
		}

    }
}
