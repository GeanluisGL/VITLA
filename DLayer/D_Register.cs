using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELayer;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DLayer
{
    public class D_Register
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

        public void createR(E_Register e_Register)
        {
            SqlCommand cmd = new SqlCommand("sp_CreateCR", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            AbrirConexion();

            cmd.Parameters.AddWithValue("@MatricID", e_Register.MatricID);
            cmd.Parameters.AddWithValue("@NameU", e_Register.NameU);
            cmd.Parameters.AddWithValue("@LastNa", e_Register.LastNa);
            cmd.Parameters.AddWithValue("@Career", e_Register.Career);
            cmd.Parameters.AddWithValue("@Mail", e_Register.Mail);
            cmd.Parameters.AddWithValue("@Pword", e_Register.Pword);
            cmd.Parameters.AddWithValue("@UserRole", e_Register.UserRole);

            cmd.ExecuteNonQuery();
            CerrarConexion();
        }


        }

    }

