using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
	class Program
	{
		static void Main(string[] args)
		{
			
				Console.WriteLine("Введите значение");
				string s = Console.ReadLine();
				char[] str = s.ToCharArray();
				Array.Reverse(str);
				Console.Write(str);
				Console.ReadKey();
			
		}
	}
}
