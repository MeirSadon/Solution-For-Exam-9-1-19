using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
	class Program
	{
		static void Main(string[] args)
		{
			Random r = new Random();
			int[] a = new int[r.Next(11)];
			int[] b = new int[r.Next(11)];

			for (int i = 0; i < a.Length; i++)
			{
				a[i] = r.Next(100);
				Console.WriteLine(a[i]);
			}
			Console.WriteLine();
			for (int i = 0; i < b.Length; i++)
			{
				b[i] = r.Next(100);
				Console.WriteLine(b[i]);

			}
			Console.WriteLine();

			if (Measure(a, b) == 1)
				Console.WriteLine("1");
			if (Measure(a, b) == 0)
				Console.WriteLine("0");
			if (Measure(a, b) == -1)
				Console.WriteLine("-1");


			Convert.ToInt32(Console.ReadLine());
		}
		static int Measure(int[] a, int[] b)
		{
			int aScore = 0;
			int bScore = 0;
			int small;
			if (a.Length < b.Length)
				small = a.Length;
			else small = b.Length;

			for (int i = 0; i < small; i++)
			{
				if (a[i] > b[i])
					aScore++;
				if (b[i] > a[i])
					bScore++;
			}


			if (aScore > bScore)
				return 1;
			if (aScore == bScore)
				return 0;
			else
				return -1;
		}

	}
}
