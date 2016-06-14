
using System;
using Caliburn.Micro;

namespace Elections.Server.Handler.ViewModels
{
    public class MainViewModel : Conductor<object>
    {

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

        public MainViewModel()
        {
            TitleWindow = "Login";
            ShowLoginView(); 
        }

        public void ShowLoginView()
        {
            ActivateItem(new LoginViewModel());
        }
    }
}