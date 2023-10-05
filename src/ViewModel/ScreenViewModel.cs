﻿using Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public abstract class ScreenViewModel
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="currentScreen">
        /// Cell containing the current screen
        /// </param>
        /// 

        protected ScreenViewModel(ICell<ScreenViewModel> currentScreen)
        {
            this.CurrentScreen = currentScreen;
        }

        /// <summary>
        /// Cell containing the current screen.
        /// Overwrite the contents of this cell to switch screens.
        /// </summary>
        protected ICell<ScreenViewModel> CurrentScreen { get; }
    }
}
