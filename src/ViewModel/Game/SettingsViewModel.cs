using Cells;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel.Game
{
    public class SettingsViewModel : ScreenViewModel, INotifyPropertyChanged
    {
        public IGame newGame;
        private float mineProbability;
        public float MineProbability
        {
            get { return mineProbability; }
            set
            {
                if (mineProbability != value)
                {
                    mineProbability = value;
                    OnPropertyChanged(nameof(MineProbability));
                }
            }
        }

        private int boardSize;
        public int BoardSize
        {
            get { return boardSize; }
            set
            {
                if (boardSize != value)
                {
                    boardSize = value;
                    OnPropertyChanged(nameof(BoardSize));
                }
            }
        }
        public SettingsViewModel(IGame game,ICell<ScreenViewModel> currentScreen) : base(currentScreen)
        {

            BoardSize = game.Board.Width;

            IGame newgame= IGame.CreateRandom(BoardSize, .1, true, null);

            Debug.WriteLine(BoardSize);
            SwitchToMain = new ActionCommand(() => CurrentScreen.Value = new StartScreenViewModel(newgame,CurrentScreen));
        }
        public ICommand SwitchToMain { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            newGame = IGame.CreateRandom(BoardSize, .1, true, null);
            Debug.WriteLine(BoardSize);
            SwitchToMain = new ActionCommand(() => CurrentScreen.Value = new StartScreenViewModel(newGame, CurrentScreen));
        }
    }
}
