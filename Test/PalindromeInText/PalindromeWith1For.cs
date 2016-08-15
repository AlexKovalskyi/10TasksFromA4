using System;
using System.IO;
using System.Text.RegularExpressions;

namespace PalindromeInText
{
	class PalindromeWith1For
	{

		public void PalindromWith1For()
		{
			StreamWriter streamReader = new StreamWriter(@"I:\Palindroms.txt");
			string text = Properties.Resources.LargeTXT;
			text = Regex.Replace(text, "[-\\.\"?!)(,:]–", "");
			string[] words = text.Split(' ');
			string[] originalWords = new string[words.Length];
			words.CopyTo(originalWords, 0);
			int i = 0;
			while (i < words.Length)
			{
				if (words[i].Length > 1)
				{
					if (IsPalindome(words[i].ToLower()))
					{
						Console.WriteLine("Word: {0}  - is Palindrome.", originalWords[i]);
						streamReader.WriteLine(originalWords[i]);

					}
				}
				i++;
			}
		}
		public bool IsPalindome(string verifyPalindrome)
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
	}
}
