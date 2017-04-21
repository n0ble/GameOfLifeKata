using System.Collections.Generic;

namespace GameOfLifeKata.Contract
{
	internal interface IGame
	{
		IEnumerable<ICell> GameField { get; set; }
		IEnumerable<ICellRule> Rules { get; set; }
		int CurrentGeneration { get; set; }
		void MakeNextGeneration();
		void PrintCurrentGeneration();
	}
}
