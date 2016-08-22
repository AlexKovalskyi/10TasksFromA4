using System;

namespace ArrayShifting
{
	class Program
	{
		private const int ArrROWS = 3;
		private const int ArrCOLS = 4;

		private static void Main(string[] args)
		{
			int[,] array = new int[ArrROWS, ArrCOLS] { { 4, 5, 6, 7 },
													   { 1, 2, 4, 1 },
													   { 4, 3, 6, 8 } };
			Console.WriteLine("Initial array:");
			Print2DArray(array);

			Console.Write("Please enter count of array shifting: ");
			int countArrayShift = Convert.ToInt32(Console.ReadLine());
			int[,] shiftedArr = new int[ArrROWS, ArrCOLS];
            int newColum, newRols;
            for (int i = 0; i < ArrROWS; i++)
			{
				for (int j = 0; j < ArrCOLS; j++)
				{
					newColum = (i + (countArrayShift % ArrCOLS)) % ArrROWS;
					newRols = j % ArrCOLS;
					shiftedArr[i, j] = array[newColum, newRols];
				}
			}

            Console.WriteLine("Array after shifting:");
            Print2DArray(shiftedArr);
			
			Console.ReadLine();
		}

		private static void Print2DArray(int[,] arr)
		{
			for (int i = 0; i < ArrROWS; i++)
			{
				for (int j = 0; j < ArrCOLS; j++)
				{
					Console.Write("\t" + arr[i, j]);
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}
