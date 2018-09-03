using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClientServerMVVMBD.Interface
{
    public interface IMainWindow
    {
        void BindDataContext(IMainWindowViewModel context);
        void ShowAlert(string text, string caption);
        bool? ShowDialog();
    }
}
