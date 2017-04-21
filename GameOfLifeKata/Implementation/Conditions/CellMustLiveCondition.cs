using GameOfLifeKata.Contract;

namespace GameOfLifeKata.Implementation.Conditions
{
	internal class CellMustLiveCondition : ICellRuleCondition
	{
		public bool Check(ICell cell)
		{
			return cell.AliveSiblingsCount == 3;
		}
	}
}
