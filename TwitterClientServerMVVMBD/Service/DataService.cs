using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClientServerMVVMBD.Repository;

namespace TwitterClientServerMVVMBD.Service
{
    public class DataService
    {
        PostDupper postDupper;
        UserDupper userDupper;

        public DataService()
        {
            postDupper = new PostDupper();
            userDupper = new UserDupper();
        }
    }
}
