using Caliburn.Micro;

namespace Elections.Server.Handler.ViewModels
{
    public class RecordViewModel : PropertyChangedBase
    {
        MainViewModel _mainViewModel;
        public void SetMain(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public void AddStudent()
        {
            _mainViewModel.TitleWindow = "Agregar Estudiante";
            _mainViewModel.Height =485;
            _mainViewModel.Width =268;
        }
    }
}