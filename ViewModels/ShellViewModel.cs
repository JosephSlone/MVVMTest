using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MVVMTest.ViewModels
{
    public class ShellViewModel : Conductor<ShellViewModel>
    {
        public TabItem? Tab1 {get;set;}
        public TabItem? Tab2 { get; set; }

        public ShellViewModel()
        {
            Tab1 = new TabItem { Header = "Tab One", Content = "Hello 1" };
            Tab2 = new TabItem { Header = "Tab Two", Content = "Hello from tab 2" };
        }
    }

    public class TabItem
    {
        public string? Content { get; set; }
        public string? Header { get; set; }
    }
}
