using System;

namespace ChessBoard
{
    class Program
    {
		static void Main(string[] args)
		{
			try
			{
				ShowChessBoard();
			}
			catch
			{
				Console.WriteLine("Wrong DataFormat");
				Console.ReadLine();
			}
		}

			public static void ShowChessBoard()
			{
			Console.WriteLine("Enter  the cell height");
			int height = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the cell width");
			int width = Convert.ToInt32(Console.ReadLine());
			for (int i = 0;i < 7;i++)
			{
				for (int ii = 0;ii < width;ii++)
				{
					for (int j = 0;j < 7;j++)
					{
						for (int jj = 0;jj < height;jj++)
						{
							if (i % 2 == 1)
							{
								if (j % 2 == 1)
								{
									Console.Write("-");
								}
								else
									Console.Write("*");
							}

							else if (j % 2 == 1)
							{
								Console.Write("*");
							}
							else
								Console.Write("-");

						}

					}

					Console.Write("\n");
				}
			}

			Console.ReadLine();
		}
	}
}
