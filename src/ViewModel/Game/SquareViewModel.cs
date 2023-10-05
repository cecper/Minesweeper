using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel.Commands;

namespace ViewModel.Game
{
    public class SquareViewModel
    {
        public ICell<Square> Square { get; }
        public ICommand Uncover { get; }
        public ICommand ToggleFlag { get; }
        private readonly ICell<IGame> _game;
        //public bool ButtonBool { get; set; }
        public SquareViewModel(ICell<IGame> game, Vector2D position)
        {
            _game = game;
            Square = game.Derive(g => g.Board[position]);
            Uncover = new UncoverSquareCommand(game, position);
            ToggleFlag = new ToggleFlagCommand(game, position);
            //buttonEnabledFunction(position);
        }

        /*public void buttonEnabledFunction(Vector2D position)
        {
            ButtonBool= _game.Value.IsSquareCovered(position);
        }*/
    }
}
