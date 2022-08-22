using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELayer
{
    public class E_ViewVis
    {
        private int _ID;
        private string _Nombre_Visitante;
        private string _Apellido;
        private string _Carrera;
        private string _Correo;
        private int _Id_Edificio;
        private string _Edificio;  
        private string _AulaR;
        private string checkin;
        private string checout;
        private string _MotV;
        private string _PhVis;

        public int ID { get => _ID; set => _ID = value; }
        public string Nombre_Visitante { get => _Nombre_Visitante; set => _Nombre_Visitante = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Carrera { get => _Carrera; set => _Carrera = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public int Id_Edificio { get => _Id_Edificio; set => _Id_Edificio = value; }
        public string Edificio { get => _Edificio; set => _Edificio = value; }
        public string Aula { get => _AulaR; set => _AulaR = value; }
        public string Check_in { get => checkin; set => checkin = value; }
        public string Check_out { get => checout; set => checout = value; }
        public string Motivo_Visita { get => _MotV; set => _MotV = value; }
        //public string Foto_Visita { get => _PhVis; set => _PhVis = value; }
    }
}
