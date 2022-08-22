using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELayer
{
    public class E_Login
    {

        private string _User;
        private string _Password;

        public string User { get => _User; set => _User = value; }
        public string Password { get => _Password; set => _Password = value; }
    }
}
