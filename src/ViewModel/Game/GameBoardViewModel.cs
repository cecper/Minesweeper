using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.Game
{
    public class GameBoardViewModel
    {
        private readonly ICell<IGameBoard> board;
        public IEnumerable<RowViewModel> Rows { get; }

        public GameBoardViewModel(ICell<IGame> board)
        {
            this.board = board.Derive(g => g.Board);
            Rows = RowsInit(board);
        }

        private IEnumerable<RowViewModel> RowsInit(ICell<IGame> game)
        {
            var rows = new List<RowViewModel>();
            for (int i = 0; i < board.Derive(h => h.Height).Value; i++)
            {
                var squares = new RowViewModel(game, i);
                rows.Add(squares);
            }
            return rows;
        }
    }
}
