using Cells;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel.Game
{
    public class StartScreenViewModel:ScreenViewModel
    {
        public GameViewModel Game { get; }
        public StartScreenViewModel(IGame game,ICell<ScreenViewModel> currentScreen) : base(currentScreen)
        {
            // Create empty cell
            Game= new GameViewModel(game);
            // Create screen A
            SwitchToSettings = new ActionCommand(() => CurrentScreen.Value = new SettingsViewModel(game,this.CurrentScreen));
        }

        public ICommand SwitchToSettings { get; }
    }
}
