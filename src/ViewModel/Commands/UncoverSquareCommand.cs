using Cells;
using Model.Data;
using Model.MineSweeper;
using System.Data.SqlTypes;
using System.Windows.Input;
using ViewModel.Game;

namespace ViewModel.Commands
{
    public class UncoverSquareCommand : ICommand
    {
        private ICell<IGame> _game;
        private Vector2D position;
        public UncoverSquareCommand(ICell<IGame> game, Vector2D position)
        {
            this.position = position;
            _game = game;
        }

        event EventHandler? ICommand.CanExecuteChanged
        {
            add
            { }

            remove
            { }
        }

        bool ICommand.CanExecute(object? parameter)
        {
            SquareViewModel square = new SquareViewModel(_game, position);
            return _game.Value.IsSquareCovered(position) && _game.Value.Status.Equals(GameStatus.InProgress) && !square.Square.Value.Status.Equals(SquareStatus.Flagged);
        }

        void ICommand.Execute(object? parameter)
        {
            _game.Value = _game.Value.UncoverSquare(position);
        }

    }
}
