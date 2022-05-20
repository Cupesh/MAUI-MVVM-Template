﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp1.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        int count = 0;
        public string BtnText { get; set; }
        public ICommand OnCounterClicked { get { return new Command(() => OnClicked()); } }

        public MainPageViewModel()
        {
            BtnText = "Click Me";
        }

        public void OnClicked()
        {
            count++;

            if (count == 1)
                BtnText = $"Clicked {count} time";
            else
                BtnText = $"Clicked {count} times";

            RaisePropertyChanged(nameof(BtnText));
            SemanticScreenReader.Announce(BtnText);
        }
    }
}
