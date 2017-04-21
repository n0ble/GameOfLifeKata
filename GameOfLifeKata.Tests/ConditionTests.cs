using GameOfLifeKata.Contract;
using GameOfLifeKata.Implementation.Conditions;
using GameOfLifeKata.Tests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLifeKata.Tests
{
	[TestClass]
	public class ConditionTests
	{
		[TestMethod]
		public void ConditionCanCheck()
		{
			ICellRuleCondition condition = new TestCondition();
			ICell cell = new TestCell();
			var result = condition.Check(cell);
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CellWithLtTwoAliveSiblingsMustDie()
		{
			ICellRuleCondition condition = new CellMustDieCondition();
			ICell cell = new TestCell();
			cell.AliveSiblingsCount = 1;
			var result = condition.Check(cell);
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CellWithTwoAliveSiblingsMustNotDie()
		{
			ICellRuleCondition condition = new CellMustDieCondition();
			ICell cell = new TestCell();
			cell.AliveSiblingsCount = 2;
			var result = condition.Check(cell);
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void CellWithThreeAliveSiblingsMustNotDie()
		{
			ICellRuleCondition condition = new CellMustDieCondition();
			ICell cell = new TestCell();
			cell.AliveSiblingsCount = 3;
			var result = condition.Check(cell);
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void CellWithGtThreeAliveSiblingsMustDie()
		{
			ICellRuleCondition condition = new CellMustDieCondition();
			ICell cell = new TestCell();
			cell.AliveSiblingsCount = 4;
			var result = condition.Check(cell);
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CellWithZeroliveSiblingsMustDie()
		{
			ICellRuleCondition condition = new CellMustDieCondition();
			ICell cell = new TestCell();
			cell.AliveSiblingsCount = 0;
			var result = condition.Check(cell);
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CellWithNegativeNumberOfAliveSiblingsMustDie()
		{
			ICellRuleCondition condition = new CellMustDieCondition();
			ICell cell = new TestCell();
			cell.AliveSiblingsCount = -1;
			var result = condition.Check(cell);
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CellWithIntMinNumberOfAliveSiblingsMustDie()
		{
			ICellRuleCondition condition = new CellMustDieCondition();
			ICell cell = new TestCell();
			cell.AliveSiblingsCount = int.MinValue;
			var result = condition.Check(cell);
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CellWithIntMaxNumberOfAliveSiblingsMustDie()
		{
			ICellRuleCondition condition = new CellMustDieCondition();
			ICell cell = new TestCell();
			cell.AliveSiblingsCount = int.MaxValue;
			var result = condition.Check(cell);
			Assert.IsTrue(result);
		}





		[TestMethod]
		public void CellWithThreeAliveSiblingsMustRevive()
		{
			ICellRuleCondition condition = new CellMustLiveCondition();
			ICell cell = new TestCell();
			cell.AliveSiblingsCount = 3;
			var result = condition.Check(cell);
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CellWithLtThreeAliveSiblingsMustNotRevive()
		{
			ICellRuleCondition condition = new CellMustLiveCondition();
			ICell cell = new TestCell();
			cell.AliveSiblingsCount = 2;
			var result = condition.Check(cell);
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void CellWithGtThreeAliveSiblingsMustNotRevive()
		{
			ICellRuleCondition condition = new CellMustLiveCondition();
			ICell cell = new TestCell();
			cell.AliveSiblingsCount = 4;
			var result = condition.Check(cell);
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void CellWithZeroAliveSiblingsMustNotRevive()
		{
			ICellRuleCondition condition = new CellMustLiveCondition();
			ICell cell = new TestCell();
			cell.AliveSiblingsCount = 0;
			var result = condition.Check(cell);
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void CellWithNegativeNumberOfAliveSiblingsMustNotRevive()
		{
			ICellRuleCondition condition = new CellMustLiveCondition();
			ICell cell = new TestCell();
			cell.AliveSiblingsCount = -1;
			var result = condition.Check(cell);
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void CellWithIntMinNumberOfAliveSiblingsMustNotRevive()
		{
			ICellRuleCondition condition = new CellMustLiveCondition();
			ICell cell = new TestCell();
			cell.AliveSiblingsCount = int.MinValue;
			var result = condition.Check(cell);
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void CellWithIntMaxNumberOfAliveSiblingsMustNotRevive()
		{
			ICellRuleCondition condition = new CellMustLiveCondition();
			ICell cell = new TestCell();
			cell.AliveSiblingsCount = int.MaxValue;
			var result = condition.Check(cell);
			Assert.IsFalse(result);
		}

	}
}
