using Caliburn.Micro;

namespace MVVMTest.ViewModels
{
    public class SecondChildViewModel : Screen
    {
        private string _title = "Second Tab";
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                NotifyOfPropertyChange(() => Title);
            }
        }

        public SecondChildViewModel()
        {
            _title = "2nd Tab";
            this.ActivateAsync();
        }
    }
}
