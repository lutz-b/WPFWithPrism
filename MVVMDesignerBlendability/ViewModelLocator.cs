using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDesignerBlendability
{
    public class ViewModelLocator
    {
        public MainViewModel MainViewModel;

        public ViewModelLocator()
        {
            MainViewModel = new MainViewModel();
        }

        public static ViewModelLocator Instance()
        {
            return new ViewModelLocator();
        }
    }
}
