using GameOfLifeKata.Contract;

namespace GameOfLifeKata.Implementation.Models
{
	internal class Cell : ICell
	{
		public int Row { get; set; }
		public bool IsAlive { get; set; }
		public int Column { get; set; }
		public int AliveSiblingsCount { get; set; }

		public Cell(int row, int column, bool isAlive, int aliveSiblingsCount = 0)
		{
			IsAlive = isAlive;
			AliveSiblingsCount = aliveSiblingsCount;
			Row = row;
			Column = column;
		}
	}
}
