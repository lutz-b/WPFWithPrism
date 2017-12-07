using Prism.Commands;
using Prism.Mvvm;
using System.ComponentModel;

namespace MVVMDesignerPrism.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application Title";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _subTitle = "Prism Application Subtitle";

        public string Subtitle
        {
            get { return _subTitle; }
            set { SetProperty(ref _subTitle, value); }
        }

        public MainWindowViewModel()
        {

        }

        public DelegateCommand ReplaceSubtitleCommand => new DelegateCommand( () =>
        {
            this.Subtitle = "Test";
        }
        
            
        );

        //private void SetSubtitle(string sub)
        //{
        //    Subtitle = sub;
        //}

    }
}
