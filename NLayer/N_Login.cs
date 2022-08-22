using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLayer;
using ELayer;
using System.Data;

namespace NLayer
{
    public class N_Login
    {
        D_Login obj = new D_Login();


        public DataTable N_Log(E_Login obje)
        { 
        
        return obj.D_Log(obje);
        }
    }
}
