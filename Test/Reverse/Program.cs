using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
	class Program
	{
		static void Main(string[] args)
		{
			//TODO: To many tabs \t
				Console.WriteLine("Введите значение"); //TODO: Where char ':' should be inserted? 
				string s = Console.ReadLine();
				char[] str = s.ToCharArray();
				Array.Reverse(str);
            //TODO: What was outputed? A bit confused.
				Console.Write(str);
		        Console.ReadKey();
			
		}
	}
    //TODO: Do this task again in other way without using 'Array.Reverse()'

    //TODO: Do this task again in other way just with digits (for numeric expression).
}
