﻿using System;
using System.Windows;
using System.Windows.Controls;
using Caliburn.Micro;

namespace Elections.Server.Handler.ViewModels
{
    public class MainViewModel : PropertyChangedBase
    {


        Int64 _height;
        public Int64 Width
        {
            get { return _width; }
            set
            {
                _width = value;
                NotifyOfPropertyChange(() => Width);
            }
        }

        Int64 _width;
        public Int64 Height
        {
            get{return _height;}
            set
            {
                _height = value;
                NotifyOfPropertyChange(() => Height);
            }
        }

        String _titleWindow;
        public String TitleWindow
        {
            get
            {
                return _titleWindow;

            }

            set
            {
                _titleWindow = value;
                NotifyOfPropertyChange(() => TitleWindow);
            }
        }

        Object _screenView;
        public Object ScreenView 
        {
            get { return _screenView; }
            set
            {
                _screenView = value;
                NotifyOfPropertyChange(() => ScreenView);
            } 
        }

        LoginViewModel _loginView;
        public LoginViewModel LoginView
        {
            get { return _loginView; }
            set
            {
                _loginView = value;
                NotifyOfPropertyChange(() => LoginView);
            }
        }

        ControlPanelViewModel _controlPanelView;
        public ControlPanelViewModel ControlPanelView
        {
            get { return _controlPanelView; }
            set
            {
                _controlPanelView = value;
                NotifyOfPropertyChange(() => ControlPanelView);
            }
        }

        public MainViewModel()
        {
            Height = 531;
            Width = 1096;
            ControlPanelView = new ControlPanelViewModel();
            LoginView = new LoginViewModel();
            LoginView.SetMain(this);
            ScreenView = LoginView;
        }
    }
}