using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLayer;
using ELayer;

namespace NLayer
{
    public class N_RVS
    {
        
        public DataTable ShowBuill()
        {

            D_RVS objdato = new D_RVS();
            return objdato.ShowBuilds();

        }



        public void Creav(E_RVS _RVS)
        {
            D_RVS objdato = new D_RVS();
            objdato.CreateV(_RVS);
        }

        public DataTable ShowBNC(E_RVS _RVS)
        {

            D_RVS objdato = new D_RVS();
            return objdato.FilCom(_RVS);
        }

}
}
    
    

