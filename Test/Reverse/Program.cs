using System;

namespace Reverse
{
	class Program
	{
		static void Main(string[] args)
		{
		    
		}

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
    //TODO: Do this task again in other way without using 'Array.Reverse()'

    //TODO: Do this task again in other way just with digits (for numeric expression).
}
