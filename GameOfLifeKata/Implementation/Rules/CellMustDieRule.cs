using GameOfLifeKata.Contract;
using GameOfLifeKata.Implementation.Actions;
using GameOfLifeKata.Implementation.Conditions;

namespace GameOfLifeKata.Implementation.Rules
{
	internal class CellMustDieRule : ICellRule
	{
		private readonly ICellRuleCondition _condition;
		private readonly ICellRuleAction _action;

		public CellMustDieRule()
		{
			_condition = new CellMustDieCondition();
			_action = new CellMustDieAction();
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
