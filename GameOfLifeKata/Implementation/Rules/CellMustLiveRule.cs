using GameOfLifeKata.Contract;
using GameOfLifeKata.Implementation.Actions;
using GameOfLifeKata.Implementation.Conditions;

namespace GameOfLifeKata.Implementation.Rules
{
		internal class CellMustLiveRule : ICellRule
	{
		private readonly ICellRuleCondition _condition;
		private readonly ICellRuleAction _action;

		public CellMustLiveRule()
		{
			_condition = new CellMustLiveCondition();
			_action = new CellMustLiveAction();
		}

		public void Apply(ICell cell)
		{
			if (_condition.Check(cell))
			{
				_action.Act(cell);
			}
		}
	}
}
