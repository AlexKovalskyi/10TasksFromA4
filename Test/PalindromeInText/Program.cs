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
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			PalindromeWith1For palindromeWith1For = new PalindromeWith1For();
			stopwatch.Stop();
			Console.WriteLine("Time Elapsed: {0}", stopwatch.Elapsed);
			stopwatch.Reset();
			Console.ReadLine();


			stopwatch.Start();
			PalindromeWith2For palindromeWith2For = new PalindromeWith2For();
			palindromeWith2For.PalindromWith2For();
			stopwatch.Stop();
			Console.WriteLine("Time Elapsed: {0}", stopwatch.Elapsed);
			Console.ReadLine();
		}


	}
}
