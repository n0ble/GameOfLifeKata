namespace GameOfLifeKata.Contract
{
	internal interface IGridAnalyzer
	{
		int CalculateCellAliveSiblings(ICell cell);
	}
}
