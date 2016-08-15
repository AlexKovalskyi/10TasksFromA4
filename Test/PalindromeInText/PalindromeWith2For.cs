using System;
using System.IO;
using System.Text.RegularExpressions;

namespace PalindromeInText
{
	class PalindromeWith2For
	{

		public void PalindromWith2For()
		{
			StreamWriter streamWriter = new StreamWriter(@"I:\Palindroms2.txt");
			var text = Properties.Resources.LargeTXT;
			text = Regex.Replace(text, "[-.?!)(,:]–", "");
			string[] words = text.Split(' ');
			string[] originalWords = new string[text.Length];
			words.CopyTo(originalWords, 0);
			int i = 0;
			while (i < words.Length)
			{
				if (words[i].Length > 1)
				{
					if (IsPalindome(words[i].ToString().ToLower()))
					{

						Console.WriteLine("Word: {0}  - is Palindrome.", originalWords[i]);
						streamWriter.WriteLine(originalWords[i]);

					}
				}
				i++;
			}
		}

		public bool IsPalindome(string verifyPalindrome)
		{
			int countMatches=0;
			bool checkPalindrom = false;
			for (int i = 0;i < verifyPalindrome.Length / 2;i++)
			{
				for (int j = verifyPalindrome.Length - 1 - i;j >= verifyPalindrome.Length / 2;j--)
				{
					if (verifyPalindrome[i] == verifyPalindrome[j])
					{
						countMatches++;
						break;
					}
				}
			}
			if (countMatches == verifyPalindrome.Length / 2)
			{
				checkPalindrom = true;
			}
			return checkPalindrom;
		}

		
	}
}
