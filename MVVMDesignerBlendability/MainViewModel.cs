using System.ComponentModel;

namespace MVVMDesignerBlendability
{
    public class MainViewModel : ASettingsModel
    {
        public MainViewModel()
        {
            TestString = "Hello";
        }


        private string _testTring;
        public string TestString
        {
            get => _testTring;
            set => SetField(ref _testTring, value, nameof(TestString));
        }
        
    }
}
