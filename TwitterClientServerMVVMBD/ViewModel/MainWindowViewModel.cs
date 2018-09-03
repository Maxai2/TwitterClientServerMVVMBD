using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClientServerMVVMBD.Interface;

namespace TwitterClientServerMVVMBD.ViewModel
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        public IMainWindow View { get; private set; }

        public MainWindowViewModel(IMainWindow view)
        {
            View = view;
            view.BindDataContext(this);
        }
    }
}
