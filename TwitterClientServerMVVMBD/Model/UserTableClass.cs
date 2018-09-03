using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClientServerMVVMBD.Common;

namespace TwitterClientServerMVVMBD.Model
{
    public class UserTableClass : NotifiableObject
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; base.OnPropertyChanged(); }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; base.OnPropertyChanged(); }
        }

        private string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; base.OnPropertyChanged(); }
        }

        private string avatar;
        public string Avatar
        {
            get { return avatar; }
            set { avatar = value; base.OnPropertyChanged(); }
        }

        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; base.OnPropertyChanged(); }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; base.OnPropertyChanged(); }
        }

    }
}
