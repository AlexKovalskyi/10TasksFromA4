using System;
using System.Linq;

//TODO: 'UserNumber' name of the project does not meet actual context.
namespace UserNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter your number: ");
			string userNumber = Console.ReadLine();

            //TODO: There is no need to cast string to chars array. Remove this transformation. And use [string].Length property. Below example.
            char[] a = userNumber.ToArray();
            //Removable Example 
            const string smallString = "S";
            Console.WriteLine($"{smallString.Length}");
            //Removable Example

            Console.Write("Amount of symbols number: ");
			Console.Write($"{a.Length}\n");
            
            //TODO: What is the destination of 'y' variable?
			string[] y = new string[a.Length];
			int[] z = new int[a.Length];
			for (int i = 0;i < a.Length;i++)
			{
                //TODO: What is the destination of 'y' variable?
                y[i] = Convert.ToString(a[i]);
				z[i] = Convert.ToInt32(y[i]);
			}
			int summ = 0;
			for (int i = 0;i < z.Length;i++)
			{
				summ += z[i];
			}
			Console.WriteLine("The sum of numeric: {0}", summ);
			int averageValue = summ / z.Length;
			Console.WriteLine("Average value is {0}", averageValue);
			
			Console.ReadLine();
		}
	}
}
