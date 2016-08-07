using System;
using System.Linq;

namespace UserNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter your number");
			string userNumber = Console.ReadLine();
			char[] a = userNumber.ToArray();
			Console.Write("Amount of symbol number: ");
			Console.Write(a.Length);
			string[] y = new string[a.Length];
			int[] z = new int[a.Length];
			for (int i = 0;i < a.Length;i++)
			{
				y[i] = Convert.ToString(a[i]);
				z[i] = Convert.ToInt32(y[i]);
			}
			int value = 0;
			for (int i = 0;i < z.Length;i++)
			{
				value = value + z[i];
			}
			Console.WriteLine("The sum of numeric: {0}", value);
			int arithmetic = value / z.Length;
			Console.WriteLine("Arithmetic mean is {0}", arithmetic);
			
			Console.ReadLine();
		}
	}
}
