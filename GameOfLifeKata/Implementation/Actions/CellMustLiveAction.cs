using GameOfLifeKata.Contract;

namespace GameOfLifeKata.Implementation.Actions
{
	internal class CellMustLiveAction : ICellRuleAction
	{
		public void Act(ICell cell)
		{
			cell.IsAlive = true;
		}
	}
}
