using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayShirt
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] array = new int[3, 4] { { 4, 5, 6, 7 }, { 1, 2, 4, 1 }, { 4, 3, 6, 8 } };
			foreach (var item in array)
			{
				Console.WriteLine("\t"+item);
			}
			Console.ReadLine();

		}
	}
}
