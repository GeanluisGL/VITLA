using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELayer
{
    public class E_Auser
    {

        private string _Id;
        private string _Name;
        private string _Last_Name;
        private string _Career;
        private string _Mail;
        private int _Rol_Id;
        private string _Rol_User;

        public string Id { get => _Id; set => _Id = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Last_Name { get => _Last_Name; set => _Last_Name = value; }
        public string Career { get => _Career; set => _Career = value; }
        public string Mail { get => _Mail; set => _Mail = value; }
        public int Rol_Id { get => _Rol_Id; set => _Rol_Id = value; }
        public string Rol_User { get => _Rol_User; set => _Rol_User = value; }
    }
}
