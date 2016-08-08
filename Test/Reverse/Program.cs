using System;

namespace Reverse
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter number what must be reversed: ");
			int numberForRevers = Convert.ToInt32(Console.ReadLine());
			int result = 0;
			while (numberForRevers != 0)
			{
				int remaind;
				numberForRevers = Math.DivRem(numberForRevers, 10, out remaind);
				result = result * 10 + remaind;
			}
			Console.WriteLine("After revers we take {0}", result);
			Console.ReadLine();
		}
		
        //TODO: Method name should meet its context.
		public static void KoSolution()
		{
			Console.WriteLine("Enter number what must be reversed: ");
			string numberForRevers = Console.ReadLine();
			char[] reversNumber = numberForRevers.ToCharArray();
			Array.Reverse(reversNumber);
			Console.Write(reversNumber);
			Console.ReadKey();
		}
		
	}
	
}
