using System;
using Caliburn.Micro;

namespace Elections.Server.Handler.ViewModels
{
    public class StudentViewModel : PropertyChangedBase
    {
        MainViewModel _mainViewModel;
        public void SetMain(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public void Cancel()
        {
            //_mainViewModel.TitleWindow = "Registro";
            _mainViewModel.Height = 350;
            _mainViewModel.Width = 600;
        }
    }
}