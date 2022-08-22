using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELayer;
using DLayer;

namespace NLayer
{
    public class N_Register
    {


        public void Ncreate(E_Register _Register) 
        {
        D_Register objDato = new D_Register();
        objDato.createR(_Register);
        }
        
    }
}
