using System;
using System.Collections.Generic;
using System.Linq;
using GameOfLifeKata.Contract;

namespace GameOfLifeKata.Implementation.Printers
{
	internal class ConsoleGamePrinter : IGamePrinter
	{
		private IEnumerable<ICell> _cells;

		public void Print(IEnumerable<ICell> cells)
		{
			_cells = cells;

			for (var x = 0; x < 10; x++) {
				for (var y = 0; y < 10; y++) {
					Console.Write(GetSymbol(GetCell(x, y).IsAlive));
				}
				Console.Write("\r\n");
			}

			Console.WriteLine("\r\n\r\n\r\n\r\n\r\n");
			Console.SetCursorPosition(0,0);
		}

		private ICell GetCell(int row, int column)
		{
			return _cells.FirstOrDefault(c => c.Row == row && c.Column == column);
		}

		private static char GetSymbol(bool isAlive)
		{
			return isAlive?  'O' : '—';
		}
	}
}
