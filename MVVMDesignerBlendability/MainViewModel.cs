using Prism.Commands;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Linq;

namespace MVVMDesignerBlendability
{
    public class MainViewModel : Prism.Mvvm.BindableBase, IMainViewModel
    {
        public MainViewModel()
        {
            TestString = "Hello MainViewModel";
        }

        private string _testTring;
        public string TestString
        {
            get => _testTring;
            set => SetProperty(ref _testTring, value, nameof(TestString));
        }


        private ObservableCollection<string> stringList = new ObservableCollection<string>(new List<string>
        {            "This",            "is",           "a",            "List" });
        public IList<string> StringList
        {
            get { return stringList; }
            set
            {
                stringList.Clear();
                value.ToList().ForEach(v => stringList.Add(v));
                RaisePropertyChanged(nameof(StringList));
            }
        }

        private ObservableCollection<IDisplayItem> objectList = new ObservableCollection<IDisplayItem>(new List<Mdl>
        {
            new Mdl("This"),
            new Mdl( "is"),
            new Mdl( "a"),
            new Mdl("object"),
            new Mdl("List")
        });
        public IList<IDisplayItem> ObjectList
        {
            get { return objectList; }
            set
            {
                objectList.Clear();
                value.ToList().ForEach(v => objectList.Add(v));
                RaisePropertyChanged(nameof(ObjectList));
            }
        }

        public ICommand AddCommand => new DelegateCommand(() =>
        {
            StringList.Add ("!");
            ObjectList.Add(new Mdl("!"));
        });
    }

    public class MockMainViewModel : Prism.Mvvm.BindableBase, IMainViewModel
    {
        public MockMainViewModel()
        {
            TestString = "Hello MockMainViewModel";
        }

        private string _testTring;
        public string TestString
        {
            get => _testTring;
            set => SetProperty(ref _testTring, value, nameof(TestString));
        }


        private ObservableCollection<string> stringList = new ObservableCollection<string>(new List<string>
        {            "This",            "is",           "a",            "Mock" });
        public IList<string> StringList
        {
            get { return stringList; }
        }

        private ObservableCollection<IDisplayItem> objectList = new ObservableCollection<IDisplayItem>(new List<Mdl>
        {
            new Mdl("Mock")
        });
        public IList<IDisplayItem> ObjectList
        {
            get { return objectList; }
        }

        public ICommand AddCommand => new DelegateCommand(() =>
        {
            TestString = "Not implemented!";
        });
    }


    public interface IMainViewModel
    {
        string TestString { get; }
        IList<string> StringList { get; }
        IList<IDisplayItem> ObjectList { get; }
        ICommand AddCommand { get; }
    }

    public class Mdl: IDisplayItem
    {
        public Mdl(string name)
        {
            Display = name;
        }
        public int Id { get; set; }
        public string Display { get; set; }
    }
    public interface IDisplayItem
    {
        string Display { get;}
    }
}
