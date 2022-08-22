using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELayer;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace DLayer
{
    public class D_ViewVis
    {
        SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public SqlConnection AbrirConexion()
        {
            if (conectar.State == ConnectionState.Closed)
                conectar.Open();
            return conectar;
        }
        public SqlConnection CerrarConexion()
        {
            if (conectar.State == ConnectionState.Open)
                conectar.Close();
            return conectar;
        }

        public List<E_ViewVis> ListarVis(int name, string user)
        {
            SqlDataReader leerR;
            SqlCommand cmd = new SqlCommand("sp_ReadC", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@user", user);

            leerR = cmd.ExecuteReader();

            List<E_ViewVis> list = new List<E_ViewVis>();
            while (leerR.Read())
            {
                    list.Add(new E_ViewVis
                {

                    ID = leerR.GetInt32(0),
                    Nombre_Visitante = leerR.GetString(1),
                    Apellido = leerR.GetString(2),
                    Carrera = leerR.GetString(3),                
                    Correo = leerR.GetString(4),
                    Id_Edificio = leerR.GetInt32(5),
                    Edificio = leerR.GetString(6),
                    Aula = leerR.GetString(7),
                    Check_in = leerR.GetString(8),
                    Check_out = leerR.GetString(9),
                    Motivo_Visita = leerR.GetString(10),

                }) ;
            }
            conectar.Close();
            leerR.Close();
            return list;
        }


        public List<E_ViewVis> ListarVisA(int name)
        {
            SqlDataReader leerR;
            SqlCommand cmd = new SqlCommand("sp_ReadCCA", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@name", name);

            leerR = cmd.ExecuteReader();

            List<E_ViewVis> list = new List<E_ViewVis>();
            while (leerR.Read())
            {
                list.Add(new E_ViewVis
                {

                    ID = leerR.GetInt32(0),
                    Nombre_Visitante = leerR.GetString(1),
                    Apellido = leerR.GetString(2),
                    Carrera = leerR.GetString(3),
                    Correo = leerR.GetString(4),
                    Id_Edificio = leerR.GetInt32(5),
                    Edificio = leerR.GetString(6),
                    Aula = leerR.GetString(7),
                    Check_in = leerR.GetString(8),
                    Check_out = leerR.GetString(9),
                    Motivo_Visita = leerR.GetString(10),

                });
            }
            conectar.Close();
            leerR.Close();
            return list;
        }
        
    }


}
