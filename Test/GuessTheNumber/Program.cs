using System;
//TODO: Remove unused namespaces.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			catch //TODO: I will have no reference to exception if it will occur.
			{
				Console.WriteLine("Wrong format");//TODO: Where is '.' ??
				Console.WriteLine("Press enter to close program"); //TODO: Where is '.' ??
                Console.ReadLine();
			}
		}

		private static void RandomNumberGame()
		{
			Random random = new Random();
			int number;
			while (true)
			{
                //TODO: 1-100 ??? random.Next(0, 500); ??
                Console.WriteLine("Computer generater number in range 1-100, try ty guess it");
                //TODO: woat? 
				Console.WriteLine("If you woat exit from programm press '0'");
				number = random.Next(0, 500);
				int i = 0;
				int tryCount = 0;
				while (i == 0)
				{
					Console.WriteLine("Write possible number");
					int possibleNumber = Convert.ToInt32(Console.ReadLine());
					if (0 < possibleNumber & possibleNumber < 500)
					{

						if (number > possibleNumber)
						{
							Console.WriteLine("You number lowest then computer");
							tryCount++;
						}
						else if (number < possibleNumber)
						{
                            //TODO: biggest
							Console.WriteLine("You number biggestst then computer");
							tryCount++;
						}
                        //TODO: May be else should be here? 
						else if (number == possibleNumber)
						{
							Console.WriteLine("Congratulations. Computer number was {0}, you try {1}-th times", number, tryCount);
							Console.WriteLine("Press enter to try again");
							Console.WriteLine("Press '0' to exit from program");
							tryCount++;
							i++;
						}
                        //TODO: What does this statement do in the program? 
						else
						{
							Console.WriteLine("Wrong data type");
						}
					}
					else if (possibleNumber == 0)
					{
						Environment.Exit(0);
					}

					else
					{
						Console.WriteLine("Write number in range 1-500");
					}
				}

				Console.ReadLine();

			}
		}
	}
}
