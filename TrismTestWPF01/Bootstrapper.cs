using TrismTestWPF01.Views;
using System.Windows;
using Prism.Modularity;
using Microsoft.Practices.Unity;
using Prism.Unity;

namespace TrismTestWPF01
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            var moduleCatalog = (ModuleCatalog)ModuleCatalog;
            //moduleCatalog.AddModule(typeof(YOUR_MODULE));
            moduleCatalog.AddModule(typeof(HelloWorldModule.HelloWorldModule));
        }
    }
}
