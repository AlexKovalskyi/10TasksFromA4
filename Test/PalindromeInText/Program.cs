using System;
using PalindromeInText.Properties;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace PalindromeInText
{
	class Program
	{
		static void Main(string[] args)
		{
            
		}


        //TODO: Remove
        public static void OldCode()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            PalindromeN palindromeWith1For = new PalindromeN();
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed: {0}", stopwatch.Elapsed);
            stopwatch.Reset();
            Console.ReadLine();


            stopwatch.Start();
            PalindromeN2 palindromeWith2For = new PalindromeN2();
            palindromeWith2For.PalindromWith2For();
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed: {0}", stopwatch.Elapsed);
            Console.ReadLine();
        }
	}
}
