using System;
using System.Linq;

namespace Palindrome
{
	class Program
	{
		static void Main(string[] args)
		{
			PalindromWith1For();
		//	PalindromWith2For();
		}
        //TODO: Implement again in other way with O(n) complicity. Big O
        
        //TODO: Implement again in other way with numeric numbers.

        //TODO: Implement again with while statement.
		private static void PalindromWith1For()
		{


			int userNumber = Convert.ToInt32(Console.ReadLine());

			int result = 0;
			while (userNumber != 0)
			{
				int remind = 0;
				userNumber = Math.DivRem(userNumber, 10, out remind);
				result = result * 10 + remind;
				
			}
            //TODO: ToArray is not needed.
			var a = userNumber.ToString().ToArray();
			var b = result.ToString().ToArray();
			Console.WriteLine(a.Length);
			for (int i = 0;i < a.Length / 2;i++)
			{
				if (a != b)
				{
                    //TODO: Break at the right moment.
					Console.WriteLine("Number isn't palindrome.");
				}
				else
				{
					Console.WriteLine("Number is Palindrome.");
				}
			}
			Console.Read();
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

        // http://bigocheatsheet.com/
        public static bool isPalindrome(string strToCheck)
        {
            for (int i = 0; i < strToCheck.Length / 2 ; i++)
            {
                int lastOffset = strToCheck.Length - 1 - i;
                if(strToCheck[i] != strToCheck[lastOffset])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
