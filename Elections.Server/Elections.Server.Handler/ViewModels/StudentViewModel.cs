using System;
using Caliburn.Micro;
using Elections.Server.Handler.Others;


namespace Elections.Server.Handler.ViewModels
{
    public class StudentViewModel : PropertyChangedBase
    {
        MainViewModel _mainViewModel;
        public void SetMain(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public void Save(Object contentGrid)
        {
            if (Validations.ValidateFields(contentGrid) == 0)
            {
                
            }
        }
    }
}