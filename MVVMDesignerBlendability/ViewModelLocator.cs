using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace MVVMDesignerBlendability
{
    public class ViewModelLocator
    {
        public IMainViewModel MainViewModel { get; set; }

        // you can set up a different design time viewmodel and define it in the xaml file 
        // d:DataContext="{Binding DesignTimeViewModel, Source={StaticResource Locator}}"
        // or resolve isDesignMode in code switch there
        public IMainViewModel DesignTimeViewModel { get; set; } = new MockMainViewModel();

        public ViewModelLocator()
        {
            var unityContainer = new UnityContainer();

            var isDesignMode = System.ComponentModel.DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject());

            if (!isDesignMode)
            {
                unityContainer.RegisterType<IMainViewModel, MainViewModel>();
            }
            else
            {
                unityContainer.RegisterType<IMainViewModel, MockMainViewModel>();
            }

            MainViewModel = unityContainer.Resolve<IMainViewModel>();
        }
    }
}
