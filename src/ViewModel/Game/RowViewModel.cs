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
    public class RowViewModel
    {
        public IEnumerable<SquareViewModel> Squares { get; }

        public RowViewModel(ICell<IGame> game, int row)
        {
            Squares = Row(game, row);
        }

        private IEnumerable<SquareViewModel> Row(ICell<IGame> game, int row)
        {
            var squares = new List<SquareViewModel>();
            for (int i = 0; i < game.Derive(g => g.Board.Width).Value; i++)
            {
                var squareViewModel = new SquareViewModel(game, new Vector2D(i, row));
                squares.Add(squareViewModel);
            }
            return squares;
        }
    }
}
