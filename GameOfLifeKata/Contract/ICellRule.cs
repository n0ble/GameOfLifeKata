namespace GameOfLifeKata.Contract
{
	internal interface ICellRule
	{
		void Apply(ICell cell);
	}
}
