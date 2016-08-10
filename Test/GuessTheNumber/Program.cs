using System;

namespace GuessTheNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				RandomNumberGame();
			}
			catch(Exception ex) 
			{
				Console.WriteLine("Error : please try again. Maybe you are using wrong argments.");
				Console.WriteLine("Press enter to close program.");
                Console.ReadLine();
			}
		}

		private static void RandomNumberGame()
		{
			Random random = new Random();
			int startOfrange = 1;
			int endOfRange = 500;
			while (true)
			{
				Console.WriteLine("Welcome in game GuessTheNumber.");
				Console.WriteLine("Computer generater number in range {0} - {1} try ty guess it.",startOfrange,endOfRange);
				Console.WriteLine("If you want exit from programm press '0'.");
				int randomNumber = random.Next(startOfrange,endOfRange);

                //TODO: You can redesign code and exclude variable 'i' at all.
				int i = 0;
				int tryCount = 0;
				while (i == 0)
				{
					Console.Write("Try to guess the number. Enter number in range: ");
					int userNumber = Convert.ToInt32(Console.ReadLine());
					if (startOfrange < userNumber & userNumber < endOfRange)
					{
                        tryCount++;
						if (randomNumber > userNumber)
						{
							Console.WriteLine("You number lowest then computer.");
							
						}
						else if (randomNumber < userNumber)
						{
							Console.WriteLine("You number biggest then computer.");
							
						}
						else
						{
							Console.WriteLine("Congratulations. Computer number was {0}, you try {1}-th times.", randomNumber, tryCount);
							Console.WriteLine("Press enter to try again.");
							Console.WriteLine("Press '0' to exit from program.");
							
							i++;
						}
					}
					else if (userNumber == 0)
					{
						break;
					}

					else
					{
						Console.WriteLine("Write number in range 1-500.");
					}
				}

				Console.ReadLine();

			}
		}
	}
}
