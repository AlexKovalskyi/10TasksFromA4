using PalindromeInText.Interface;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace PalindromeInText 
{
    public class PalindromeN2 : IPalindrome
    {
        public void PalindromWith2For()
        {
            using (StreamWriter streamWriter = new StreamWriter(@"I:\Palindroms.txt"))
            {
                string text = Properties.Resources.LargeTXT;
                text = Regex.Replace(text, "[-\\.\"?!)(,:]–", "");
                string[] words = text.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length > 1)
                    {
                        string originalWord = string.Copy(words[i]);
                        if (IsPalindome(words[i].ToLower()))
                        {
                            Console.WriteLine("Word: {0}  - is Palindrome.", originalWord[i]);
                            streamWriter.WriteLine(originalWord[i]);
                        }
                    }
                }
            }
        }

        public bool IsPalindome(string verifyPalindrome)
        {
            int countMatches = 0;
            bool checkPalindrom = false;
            for (int i = 0; i < verifyPalindrome.Length / 2; i++)
            {
                for (int j = verifyPalindrome.Length - 1 - i; j >= verifyPalindrome.Length / 2; j--)
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