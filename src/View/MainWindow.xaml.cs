using Model.MineSweeper;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;  
using System.Windows.Documents;
using System.Windows.Input;
using ViewModel;
using ViewModel.Game;

namespace View
{
    public partial class MainWindow : Window
    {
            public MainWindow()
            {
                InitializeComponent();
                this.DataContext = new MainViewModel();
            }
    }
}
