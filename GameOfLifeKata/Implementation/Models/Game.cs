using System.Collections.Generic;
using System.Linq;
using System.Threading;
using GameOfLifeKata.Contract;
using GameOfLifeKata.Implementation.Printers;
using GameOfLifeKata.Implementation.Rules;

namespace GameOfLifeKata.Implementation.Models
{
	internal class Game : IGame
	{
		private readonly IGamePrinter _printer;
		public IEnumerable<ICell> GameField { get; set; }
		public IEnumerable<ICellRule> Rules { get; set; }
		public int CurrentGeneration { get; set; }

		public Game(IEnumerable<ICell> gameField)
		{
			GameField = gameField;
			_printer = new ConsoleGamePrinter();
			Rules = new ICellRule[] {new CellMustDieRule(), new CellMustLiveRule()};
			CurrentGeneration = -1;
			MakeNextGeneration();
		}

		private bool FoundAliveSibling(ICell cell, int rowShift, int columnShift)
		{
			var sibling = GameField.FirstOrDefault(c => c.Row == cell.Row + rowShift && c.Column == cell.Column + columnShift);
			return sibling != null && sibling.IsAlive;
		}

		private void CalculateCellAliveSiblings(ICell cell)
		{
			var result = 0;
			var siblingCoordsShifts = new[,]
			{
				{0,1},
				{1,1},
				{1,0},
				{1,-1},
				{0,-1},
				{-1,-1},
				{-1,0},
				{-1,1}
			};

			for (var i = 0; i < siblingCoordsShifts.GetLength(0); i++)
			{
				if (FoundAliveSibling(cell, siblingCoordsShifts[i, 0], siblingCoordsShifts[i, 1]))
				{
					result++;
				}
			}

			cell.AliveSiblingsCount = result;
		}

		public void MakeNextGeneration()
		{
			foreach (var cell in GameField)
			{
				CalculateCellAliveSiblings(cell);
			}

			if (CurrentGeneration >= 0)
			{
				foreach (var cell in GameField)
				{
					foreach (var rule in Rules)
					{
						rule.Apply(cell);
					}
				}
			}
			
			CurrentGeneration++;
			Thread.Sleep(500);
		}

		public void PrintCurrentGeneration()
		{
			_printer.Print(GameField);
		}
	}
}
