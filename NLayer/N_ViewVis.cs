using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLayer;
using ELayer;

namespace NLayer
{
    public class N_ViewVis
    {

        public List<E_ViewVis> ListaEa(int name, string user)
        {
            D_ViewVis objDato = new D_ViewVis();
            return objDato.ListarVis(name, user);
        }

        

        public List<E_ViewVis> Listaa(int name)
        {
            D_ViewVis objDato = new D_ViewVis();
            return objDato.ListarVisA(name);
        }

    }
}
