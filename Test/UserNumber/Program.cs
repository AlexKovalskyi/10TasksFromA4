using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNumber
{
	class Program
	{
        //TODO: What was it? 
		static void Main(string[] args)
		{
			string number = Console.ReadLine();
			char[] a = number.ToArray<char>();
			Console.Write("the number of numeric in the number: ");//TODO: WTF?
			Console.WriteLine(a.Length);
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
			Console.WriteLine("arithmetic mean is {0}", arithmetic);
			
			Console.ReadLine();
		}
	}
}
