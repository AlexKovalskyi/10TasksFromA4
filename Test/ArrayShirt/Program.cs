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
			Console.WriteLine("Our Array:");
			Print2DArray(array);
			Console.Write("Please enter count of array shirt: ");
			int countArrayShitr = Convert.ToInt32(Console.ReadLine());
			int newColum ;
			int newRols ;
			Console.WriteLine();
			Console.WriteLine("Araay after inversion:");
			int[,] shirtArray = new int[arrayRols, arrayColumn];
			for (int i = 0;i < arrayRols;i++)
			{
				for (int j = 0;j < arrayColumn;j++)
				{
					newColum = (i + (countArrayShitr % arrayColumn)) % arrayRols;
					newRols = j % arrayColumn;
					shirtArray[i, j] = array[newColum, newRols];
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			Print2DArray(shirtArray);
			
			Console.ReadLine();
		}
		static void Print2DArray(int[,] arr)
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
