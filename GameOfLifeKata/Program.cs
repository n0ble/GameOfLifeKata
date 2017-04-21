using System.Collections.Generic;
using GameOfLifeKata.Contract;
using GameOfLifeKata.Implementation.Models;

namespace GameOfLifeKata
{
	class Program
	{
		static void Main(string[] args)
		{
			var game = new Game ( GetField());
			var generationsNumber = 100;

			for (int i = 0; i < generationsNumber; i++)
			{
				game.PrintCurrentGeneration();
				game.MakeNextGeneration();
			}


		}

		private static  IEnumerable<ICell> GetField()
		{
			int rows = 10;
			int columns = 10;

			var cells = new List<ICell>();
			for (var x = 0; x < rows; x++) {
				for (var y = 0; y < columns; y++) {
						var cell = new Cell(x, y, ( x == 0 || x == 2 || x == 1)  && y== 3);
						cells.Add(cell);
				}
			}

			return cells;
		}

	}
}
