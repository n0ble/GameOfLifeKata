namespace GameOfLifeKata.Contract
{
	internal interface ICell
	{
		bool IsAlive{ get; set; }
		int AliveSiblingsCount { get; set; }
		int Row { get; set; }
		int Column { get; set; }
	}
}
