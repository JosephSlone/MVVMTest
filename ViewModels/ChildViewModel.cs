using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Caliburn.Micro;

namespace MVVMTest.ViewModels
{
    public class ChildViewModel : Screen
    {
        private string _title = "First Tab";
        public string Title 
        { 
            get { return _title; } 
            set 
            { 
                _title = value;
                NotifyOfPropertyChange(() => Title);
            }
        }

        public ChildViewModel()
        {
            _title = "First Tab";
            this.ActivateAsync();
        }
    }
}
