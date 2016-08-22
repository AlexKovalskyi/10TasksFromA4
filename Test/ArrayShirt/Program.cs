using System;

namespace ArrayInversion
{
	class Program
	{

		public const int arrayRols = 3;
		const int arrayColumn = 4;

		static void Main(string[] args)
		{

			int[,] array = new int[arrayRols, arrayColumn] { { 4, 5, 6, 7 },
															 { 1, 2, 4, 1 },
															 { 4, 3, 6, 8 } };
			//Print array
			Console.WriteLine("Our Array:");
			Print2DArrays(array);
			//Array inversion
			int step = 1;
			int newColum ;
			int newRols ;
			Console.WriteLine();
			Console.WriteLine("Araay after inversion:");
			for (int i = 0;i < arrayRols;i++)
			{
				for (int j = 0;j < arrayColumn;j++)
				{
					newColum = (i + (step % arrayColumn)) % arrayRols;
					newRols = j % arrayColumn;
					Console.Write("\t" + array[newColum, newRols]);
					
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			
			Console.ReadLine();
		}
		static void Print2DArrays(int[,] arr)
		{
			for (int i = 0;i < arrayRols;i++)
			{
				for (int j = 0;j < arrayColumn;j++)
				{
					Console.Write("\t" + arr[i, j]);
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}
