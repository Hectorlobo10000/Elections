using System.Windows;
using Caliburn.Micro;
using Elections.Server.Handler.ViewModels;

namespace Elections.Server.Handler
{
    public class HandlerBootstrapper : BootstrapperBase
    {
        public HandlerBootstrapper()
        {
            Initialize();
        }

        static Application _application;
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainViewModel>();
            _application = Application;
            _application.MainWindow.Title = "Login";
            _application.MainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _application.MainWindow.ResizeMode = ResizeMode.NoResize;
        }


        public static void Title(string titleWindow)
        {
            _application.MainWindow.Title = titleWindow;
        }
    }
}