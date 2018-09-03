using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClientServerMVVMBD.Interface
{
    public interface ILoginWindow
    {
        void BindDataContext(ILoginWindowViewModel context);
        void ShowAlert(string text, string caption);
        bool? ShowDialog();
    }
}
