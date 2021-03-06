﻿using Prism.Mvvm;

namespace TrismTestWPF01.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
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
    }
}
