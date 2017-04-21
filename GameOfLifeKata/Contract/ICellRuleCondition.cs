namespace GameOfLifeKata.Contract
{
	internal interface ICellRuleCondition
	{
		bool Check(ICell cell);
	}
}
