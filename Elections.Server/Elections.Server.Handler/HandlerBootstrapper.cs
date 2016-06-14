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

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainViewModel>();
        }
    }
}