using GameOfLifeKata.Contract;
using GameOfLifeKata.Implementation.Rules;
using GameOfLifeKata.Tests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLifeKata.Tests
{
	[TestClass]
	public class RuleTests
	{
		class TestCellRule : ICellRule
		{
			public void Apply(ICell cell)
			{
			}
		}

		[TestMethod]
		public void RuleCanBeApplied()
		{
			ICellRule rule = new TestCellRule();
			ICell cell= new TestCell();
			rule.Apply(cell);

		}

		[TestMethod]
		public void CellMustDieRuleCanKill()
		{
			ICellRule rule = new  CellMustDieRule();
			ICell cell = TestHelper.GetAliveCell();
			cell.AliveSiblingsCount = 4;
			rule.Apply(cell);
			var result = cell.IsAlive;
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void CellMustLiveRuleCanRevive()
		{
			ICellRule rule = new  CellMustDieRule();
			ICell cell = TestHelper.GetAliveCell();
			cell.AliveSiblingsCount = 4;
			rule.Apply(cell);
			var result = cell.IsAlive;
			Assert.IsFalse(result);
		}
	}
}
