using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerNeighbor
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter sequence of number:");
			string sequence = Console.ReadLine();
			sequence.ToArray();
			Console.WriteLine("Large Number from neighbor:");
			for (int i = 0;i < sequence.Length;i++)
			{
				if ( i+2 == sequence.Length)
				{
					break;
				}
				if (sequence[i] < sequence[i + 1] && sequence[i+1] > sequence[i + 2])
				{
					Console.WriteLine(sequence[i + 1]);
				}
			}
			Console.ReadLine();
		}
	}
}
