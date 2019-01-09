using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
	class Program
	{

		static void Main(string[] args)
		{
			Console.WriteLine("Enter a number:");
			int x = Convert.ToInt32(Console.ReadLine());
			Power2(x);
			Convert.ToInt32(Console.ReadLine());
		}
		

		private static void Power2(int i)
		{
			i = i * 2;
			Console.WriteLine($"mul 2 of your number is {i}");
		}

	}
}
