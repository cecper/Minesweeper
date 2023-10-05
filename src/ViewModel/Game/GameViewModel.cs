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
    public class GameViewModel
    {
        public GameBoardViewModel Board { get; set; }

        public GameViewModel(IGame game) 
        {
            ICell<IGame> gameCell = Cell.Create(game);
            Board = new GameBoardViewModel(gameCell);
            
        }
    }
}
