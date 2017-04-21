using GameOfLifeKata.Contract;

namespace GameOfLifeKata.Implementation.Conditions
{
	internal class CellMustDieCondition : ICellRuleCondition
	{
		public bool Check(ICell cell)
		{
			return cell.AliveSiblingsCount < 2 || cell.AliveSiblingsCount > 3;
		}
	}
}
