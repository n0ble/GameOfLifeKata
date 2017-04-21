using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLifeKata.Tests
{
	[TestClass]
	public class CellTests
	{
		[TestMethod]
		public void CanGetAliveCellState()
		{
			var cell = TestHelper.GetAliveCell();
			var state = cell.IsAlive;
			Assert.IsTrue(state);
		}

		[TestMethod]
		public void CanGetDeadCellState()
		{
			var cell = TestHelper.GetDeadCell();
			var state = cell.IsAlive;
			Assert.IsFalse(state);
		}

		[TestMethod]
		public void CanSetCellState()
		{
			var cell = TestHelper.GetDeadCell();
			cell.IsAlive = true;
			var state = cell.IsAlive;
			Assert.IsTrue(state);
		}

		[TestMethod]
		public void CanSetAliveSiblingsCount()
		{
			var cell = TestHelper.GetAliveCell();
			cell.AliveSiblingsCount = 8;
			Assert.AreEqual(8, cell.AliveSiblingsCount);
		}

		[TestMethod]
		public void CanGetAliveSiblingsCount()
		{
			var cell = TestHelper.GetCellWithThreeAliveSiblings();
			Assert.AreEqual(3, cell.AliveSiblingsCount);
		}

		
	}
}
