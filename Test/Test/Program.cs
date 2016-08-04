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
			catch //TODO: how to debug? 
			{
				Console.WriteLine("Wrong DataFormat"); //TODO: What is DataFormat? 
				Console.ReadLine();
			}
		}

			public static void ShowChessBoard()
			{//TODO: Something with tabs again?
			Console.WriteLine("Enter  the cell height");
			int height = Convert.ToInt32(Console.ReadLine()); //TODO: Type this in front of WriteLine (upper operation)
			Console.WriteLine("Enter the cell width");
			int width = Convert.ToInt32(Console.ReadLine());
            //TODO: Too complex. Read about algorithm complexity. Big O.
            for (int i = 0;i < 7;i++)
			{
				for (int ii = 0;ii < width;ii++)
				{
					for (int j = 0;j < 7;j++)
					{
						for (int jj = 0;jj < height;jj++)
						{
							if (i % 2 == 1)// true --> Odd number, otherwise even number.
							{
                                //TODO: Use ternary operator here.
								if (j % 2 == 1)
								{
									Console.Write("-");
								}
								else
									Console.Write("*");
							}
                            //TODO: Use ternary operator here.
                            else if (j % 2 == 1)
							{
								Console.Write("*");
							}
							else
								Console.Write("-");
						}
                        
					}
					Console.Write("\n"); //Escape sequences
				}
			}

			Console.ReadLine();
		}
	}
}
