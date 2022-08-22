using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using ELayer;
using DLayer;

namespace NLayer
{
    public class N_Auser
    {
        public List<E_Auser> viewEU(string name)
        {
            D_Auser objD = new D_Auser();
            return objD.ListE(name);
        }

        public DataTable ViewA()
        {

            D_Auser objD = new D_Auser();
            DataTable table = new DataTable();
            table = objD.ViewE();
            return table;

        }

        public void Showlist()
        {
            D_Auser objD = new D_Auser();
            objD.Showlist();
        }

        public void DeleterA(E_Auser _Auser)
        {
            D_Auser objD = new D_Auser();
            objD.DeleteA(_Auser);
        }

        public void UppdateA(E_Auser _Auser)
        {
            D_Auser objD = new D_Auser();
            objD.updateA(_Auser);

        }

    }
}
