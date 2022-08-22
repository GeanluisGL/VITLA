using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELayer
{
    public class E_RVS
    {

        private int _ID;
        private string _Nombrev;
        private string _Apel;
        private string _Bpel;
        private string _Carrera;
        private string _Mail;
        private int _Edif;
        private string _AulaR;
        private string checkin;
        private string checout;
        private string _MotV;
        private string _PhVis;
        private int _idc;
        string _pAction;
        int? _pId = null;



        public int ID { get => _ID; set => _ID = value; }
        public string Nombrev { get => _Nombrev; set => _Nombrev = value; }
        public string Apel { get => _Apel; set => _Apel = value; }
        public string Bpel { get => _Bpel; set => _Bpel = value; }
        public string Carrera { get => _Carrera; set => _Carrera = value; }
        public string Mail { get => _Mail; set => _Mail = value; }
        public int Edif { get => _Edif; set => _Edif = value; }
        public string AulaR { get => _AulaR; set => _AulaR = value; }
        public string Checkin { get => checkin; set => checkin = value; }
        public string Checout { get => checout; set => checout = value; }

        public int Idc { get => _idc; set => _idc = value; }
        public string PAction { get => _pAction; set => _pAction = value; }
        public int? PId { get => _pId; set => _pId = value; }
        public string MotV { get => _MotV; set => _MotV = value; }
        public string PhVis { get => _PhVis; set => _PhVis = value; }
    }
}
