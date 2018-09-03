using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClientServerMVVMBD.Interface;

namespace TwitterClientServerMVVMBD.ViewModel
{
    public class LoginWindowViewModel : ILoginWindowViewModel
    {
        public ILoginWindow View { get; private set; }

        public LoginWindowViewModel(ILoginWindow view)
        {
            View = view;
            view.BindDataContext(this);

        }
    }
}
