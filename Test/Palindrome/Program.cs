using System;
using System.Linq;

namespace Palindrome
{
	class Program
	{
		static void Main(string[] args)
		{
			PalindromWith1For();
		//	PalindromWithNueric();
		//	PalindromWith2For();
			Console.ReadLine();
		}
        //TODO: Implement again in other way with O(n) complicity. Big O
		private static void PalindromWithNueric()
		{
			Console.Write("Please enter your number: ");
			int userNumber = Convert.ToInt32(Console.ReadLine());
			int copyUserNumber = userNumber;
			int result = 0;
			while (userNumber != 0)
			{
				int remind = 0;
				userNumber = Math.DivRem(userNumber, 10, out remind);
				result = result * 10 + remind;

			}
			if(copyUserNumber==result)
			{
				Console.WriteLine("Number is Palindrome.");
			}
			else
			{
				Console.WriteLine("Number is doesn't palindrome.");
			}
			
		}



		private static void PalindromWith2For()
		{
			Console.Write("Please enter your number: ");
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
				Console.WriteLine("Number isn't palindrome.");
			}
			Console.ReadLine();
		}
		static bool IsPalindome(string verifyPalindrome)
		{
			
			bool checkPalindrom = true;
			for (int i = 0;i < verifyPalindrome.Length / 2;i++)
			{
				if (verifyPalindrome[i] != verifyPalindrome[verifyPalindrome.Length - i - 1])
				{
					checkPalindrom = false;
					break;
				}

			}
			return checkPalindrom;
		}
		
		static void PalindromWith1For()
		{
			Console.Write("Please enter your number: ");
			string userNumber = Console.ReadLine();
			if (IsPalindome(userNumber))
			{
				Console.WriteLine("Number is Palindrome.");
			}
			else
			{
				Console.WriteLine("Number isn't palindrome.");
			}
			Console.Read();
			
		}
		//// http://bigocheatsheet.com/
		//public static bool isPalindrome(string strToCheck)
		//{
		//    for (int i = 0; i < strToCheck.Length / 2 ; i++)
		//    {
		//        int lastOffset = strToCheck.Length - 1 - i;
		//        if(strToCheck[i] != strToCheck[lastOffset])
		//        {
		//            return false;
		//        }
		//    }

		//    return true;
		//}
	}
}
