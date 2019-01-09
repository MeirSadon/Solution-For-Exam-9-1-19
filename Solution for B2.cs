using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] board = new int[3,3]
			{ { 1, 1, 1 }, { 0, 0, 0 }, { 0, 0, 0 } };
			WinX0(board);

		}
		static int WinX0(int[,] board)
		{
		if(board.GetLength(0) != 3 || board.GetLength(1) != 3)
		return -1;
			for (int i = 0; i < board.GetLength(0); i++)
			{
				for (int j = 0; j < board.GetLength(1); j++)
				{
					if (board[i, j] != 0 && board[i, j] != 1)
						return - 2;
				}
			}
			for (int i = 0; i < board.GetLength(0); i++)
			{
				for (int j = 0; j < board.GetLength(1); j++)
				{
					if(board[i,j] == 0)
				}
			}
			return 1;
		}

	}
}
