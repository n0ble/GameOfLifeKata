using GameOfLifeKata.Contract;
using GameOfLifeKata.Implementation.Models;

namespace GameOfLifeKata.Tests
{
	internal class TestHelper
	{
		public static ICell GetAliveCell()
		{
			return new Cell(row: 3, column: 3, isAlive: true);
		}

		public static ICell GetDeadCell()
		{
			return new Cell(row: 3, column: 3, isAlive: false);
		}

		public static ICell GetCellWithThreeAliveSiblings()
		{
			return new Cell(row: 3, column: 3, isAlive: false, aliveSiblingsCount:3);
		}
	}
}
