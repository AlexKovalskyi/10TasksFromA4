using System;

namespace ArrayInversion
{
	class Program
	{
		static void Main(string[] args)
		{
			const int arrayRols = 3;
			const int arrayColumn = 4;
			int[,] array = new int[arrayRols, arrayColumn] { { 4, 5, 6, 7 },
															 { 1, 2, 4, 1 },
															 { 4, 3, 6, 8 } };
			//Print array
			for (int i = 0;i <3;i++)
			{
				for (int j = 0;j < 4;j++)
				{
					Console.Write(array[i,j]);
				}
				Console.WriteLine();
			}

			//Array inversion
			for (int i = 0;i < arrayColumn;i++)
			{
				int temp;
				temp = array[0, i];
				array[0, i] = array[arrayRols - 1, i];
				array[arrayRols - 1, i] = temp;
			}
			Console.WriteLine();

			//Print inversed array
			for (int i = 0;i < 3;i++)
			{
				for (int j = 0;j < 4;j++)
				{
					Console.Write(+array[i, j]);
				}
				Console.WriteLine();
			}

			Console.ReadLine();
		}
	}
}
