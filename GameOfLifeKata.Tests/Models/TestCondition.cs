using GameOfLifeKata.Contract;

namespace GameOfLifeKata.Tests.Models
{
		internal class TestCondition : ICellRuleCondition
		{
			public bool Check(ICell cell)
			{
				return cell != null;
			}
		}
}
