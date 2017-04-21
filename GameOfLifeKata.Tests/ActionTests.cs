using GameOfLifeKata.Contract;
using GameOfLifeKata.Implementation.Actions;
using GameOfLifeKata.Tests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLifeKata.Tests
{
	[TestClass]
	public class ActionTests
	{
		private class TestCellRuleAction : ICellRuleAction
		{
			public void Act(ICell cell)
			{
				

			}
		}

		[TestMethod]
		public void ActionCanAct()
		{
			ICellRuleAction action = new TestCellRuleAction();
			ICell cell = new TestCell();
			action.Act(cell);
			Assert.IsTrue(true);
		}

		[TestMethod]
		public void KillActionCanKill()
		{
			ICell cell = TestHelper.GetAliveCell();
			ICellRuleAction action = new CellMustDieAction();
			action.Act(cell);
			Assert.IsFalse(cell.IsAlive);

		}

		[TestMethod]
		public void ReviveActionCanRevive()
		{
			ICell cell = TestHelper.GetDeadCell();
			ICellRuleAction action = new CellMustLiveAction();
			action.Act(cell);
			Assert.IsTrue(cell.IsAlive);
		}
	}
}
