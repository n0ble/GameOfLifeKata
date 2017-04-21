using System.Collections.Generic;

namespace GameOfLifeKata.Contract
{
	internal interface IGamePrinter
	{
		void Print(IEnumerable<ICell> cells);
	}
}
