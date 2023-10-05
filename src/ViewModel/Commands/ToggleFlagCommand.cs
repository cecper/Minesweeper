using Cells;
using Model.Data;
using Model.MineSweeper;
using System.Windows.Input;


namespace ViewModel.Commands
{
    public class ToggleFlagCommand : ICommand
    {
        private ICell<IGame> _game;
        private Vector2D position;
        public ToggleFlagCommand(ICell<IGame> game, Vector2D position)
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
            return _game.Value.IsSquareCovered(position) && _game.Value.Status.Equals(GameStatus.InProgress);
        }

        void ICommand.Execute(object? parameter)
        {
            _game.Value = _game.Value.ToggleFlag(position);
        }

    }
}
