using GameOfLifeKata.Contract;

namespace GameOfLifeKata.Implementation.Actions
{
	class CellMustDieAction : ICellRuleAction
	{
		public void Act(ICell cell)
		{
			cell.IsAlive = false;
		}
	}
}
