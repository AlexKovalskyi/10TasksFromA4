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
			catch (Exception ex)
			{
				Console.WriteLine("Error : please try again. Maybe you are using wrong argments.");
				Console.WriteLine("Press enter to close program.");
				Console.ReadLine();
			}
		}

		public static void ShowChessBoard()
		{
			Console.Write("Enter  the cell height: ");
			int cellHeight = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the cell width: ");
			int cellWidth = Convert.ToInt32(Console.ReadLine());
			//TODO: Too complex. Read about algorithm complexity. Big O.
			Console.Write("Enter  the board height: ");
			int boardHeight = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the board width: ");
			int boardWidth = Convert.ToInt32(Console.ReadLine());
			for (int i = 0;i < boardHeight;i++)
			{
				for (int ii = 0;ii < cellWidth;ii++)
				{
					for (int j = 0;j < boardWidth;j++)
					{
						for (int jj = 0;jj < cellHeight;jj++)
						{
							if (i % 2 == 1)
							{
								Console.Write((j % 2 == 1) ? "-" : "*");
							}
							else
								Console.Write((j % 2 == 1) ? "*" : "-");
						}
                       
					}
					Console.WriteLine();
				}
			}
			Console.ReadLine();
		}
	}
}
