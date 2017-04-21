using GameOfLifeKata.Contract;

namespace GameOfLifeKata.Tests.Models
{
	internal class TestCell : ICell
	{

		public int AliveSiblingsCount { get; set; }
		public int Row { get; set; }
		public int Column { get; set; }
		public bool IsAlive{ get; set; }
	}
}
