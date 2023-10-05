using Cells;
using Model.MineSweeper;
using ViewModel.Game;

namespace ViewModel
{
    public class MainViewModel
    {
        
        public MainViewModel()
        {
            

            CurrentScreen = Cell.Create<ScreenViewModel>(null);
            var game = IGame.CreateRandom(10, .1, true, null);

            var firstScreen = new StartScreenViewModel(game,CurrentScreen);

            // Put first screen in CurrentScreen cell
            CurrentScreen.Value = firstScreen;
        }
        public ICell<ScreenViewModel> CurrentScreen { get; }
    }
}
