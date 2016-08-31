﻿using System;
using System.Windows;
using System.Windows.Controls;
using Caliburn.Micro;

namespace Elections.Server.Handler.ViewModels
{
    public class LoginViewModel : PropertyChangedBase
    {
        MainViewModel _mainViewModel;
        public void SetMain(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public void Login()
        {
            
            _mainViewModel.ScreenView = _mainViewModel.ControlPanelView;
            //_mainViewModel.TitleWindow = "Panel de Control";
            //HandlerBootstrapper.Title(_mainViewModel.TitleWindow);
        }
    }
}