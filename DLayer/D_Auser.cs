using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELayer;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;


namespace DLayer
{
    public class D_Auser
    {

            SqlDataReader reader;
            DataTable leerR = new DataTable();

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

        public List<E_Auser> ListE(string name)
        {
            SqlDataReader leerrR;
            SqlCommand cmd = new SqlCommand("sp_ReadCRN", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@name", name);
            leerrR = cmd.ExecuteReader();

            List<E_Auser> list = new List<E_Auser>();
            while (leerrR.Read())
            {
                list.Add(new E_Auser
                {
                    Id = leerrR.GetString(0),
                    Name = leerrR.GetString(1),
                    Last_Name = leerrR.GetString(2),
                    Career = leerrR.GetString(3), 
                    Mail = leerrR.GetString(4),
                    Rol_Id= leerrR.GetInt32(5),
                    Rol_User = leerrR.GetString(6),

                });
            }
            conectar.Close();
            leerrR.Close();
            return list;
        }

        public DataTable ViewE()
        {
            conectar.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ReadCRN";
            cmd.CommandType = CommandType.StoredProcedure;
            reader = cmd.ExecuteReader();
            leerR.Load(reader);
            conectar.Close();

            return leerR;
        }

        public void updateA(E_Auser e_Auser)
        {

            SqlCommand cmd = new SqlCommand("sp_UpdateCR", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            AbrirConexion();

            cmd.Parameters.AddWithValue("@MatricID", e_Auser.Id);
            cmd.Parameters.AddWithValue("@NameU", e_Auser.Name);
            cmd.Parameters.AddWithValue("@LastNa", e_Auser.Last_Name);
            cmd.Parameters.AddWithValue("@Career", e_Auser.Career);
            cmd.Parameters.AddWithValue("@Mail", e_Auser.Mail);
            cmd.Parameters.AddWithValue("@UserRole", e_Auser.Rol_Id);


            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public DataTable Showlist()
        {
            SqlDataReader leer;
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = AbrirConexion();
            cmd.CommandText = "Select * From vwregister";
            cmd.CommandType = CommandType.Text;
            leer = cmd.ExecuteReader();
            dataTable.Load(leer);
            conectar.Close();
            return dataTable;
        }

        public void DeleteA(E_Auser e_Auser)
        {

            SqlCommand cmd = new SqlCommand("sp_DeleteCR", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            AbrirConexion();

            cmd.Parameters.AddWithValue("@MatrID", e_Auser.Id);

            cmd.ExecuteNonQuery();
            CerrarConexion();

        }




    }
}
