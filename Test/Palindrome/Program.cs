using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
	class Program
	{
		static void Main(string[] args)
		{
			string number = Console.ReadLine();
			char[] numberArray = number.ToArray();
			int countMatches = 0;
			for (int i = 0;i < numberArray.Length/2;i++)
			{
				for (int j = numberArray.Length-1-i;j >=numberArray.Length/2;j--)
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
				Console.WriteLine("Number is Palindrome");
			}
			else
			{
				Console.WriteLine("Number is doesn't palindrome");
			}
			Console.ReadLine();

		}
	}
}
