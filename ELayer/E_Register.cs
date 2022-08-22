using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELayer
{
    public class E_Register
    {
        private string _MatricID;
        private string _NameU;
        private string _LastNa;
        private string _Career;
        private string _Mail;
        private string _Pword;
        private int _UserRole;

        public string MatricID { get => _MatricID; set => _MatricID = value; }
        public string NameU { get => _NameU; set => _NameU = value; }
        public string LastNa { get => _LastNa; set => _LastNa = value; }
        public string Career { get => _Career; set => _Career = value; }
        public string Mail { get => _Mail; set => _Mail = value; }
        public string Pword { get => _Pword; set => _Pword = value; }
        public int UserRole { get => _UserRole; set => _UserRole = value; }
    }
}
