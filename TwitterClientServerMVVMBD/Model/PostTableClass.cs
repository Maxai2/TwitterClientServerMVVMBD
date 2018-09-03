using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClientServerMVVMBD.Common;

namespace TwitterClientServerMVVMBD.Model
{
    public class PostTableClass : NotifiableObject
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; base.OnPropertyChanged(); }
        }

        private int senderId;
        public int SenderId
        {
            get { return senderId; }
            set { senderId = value; base.OnPropertyChanged(); }
        }

        private string senderTime;
        public string SenderTime
        {
            get { return senderTime; }
            set { senderTime = value; base.OnPropertyChanged(); }
        }

        private string theme;
        public string Theme
        {
            get { return theme; }
            set { theme = value; base.OnPropertyChanged(); }
        }

        private string tag;
        public string Tag
        {
            get { return tag; }
            set { tag = value; base.OnPropertyChanged(); }
        }
    }
}
