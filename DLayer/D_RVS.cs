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
    public class D_RVS
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

        public DataTable ShowBuilds()
        {
            SqlDataAdapter da = new SqlDataAdapter("readBuils", conectar);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable FilCom(E_RVS e_RVS) 
        {
          
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new
                    SqlCommand("spComC", conectar))
                {
                    conectar.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@action", e_RVS.PAction);
                    cmd.Parameters.AddWithValue("@idC", e_RVS.Idc); 
                    if (e_RVS.PAction == "BI")
                    { }
                    else if (e_RVS.PAction == "CR")
                    { 
                    cmd.Parameters.AddWithValue("@idC", e_RVS.Idc);

                    }
                    conectar.Close();
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return dt;
        }

        public void CreateV(E_RVS e_RVS)
        {
            SqlCommand cmd = new SqlCommand("sp_CreateC", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            AbrirConexion();

            cmd.Parameters.AddWithValue("@Nombrev", e_RVS.Nombrev);
            cmd.Parameters.AddWithValue("@Apel", e_RVS.Apel);
            cmd.Parameters.AddWithValue("@Carrera", e_RVS.Carrera);
            cmd.Parameters.AddWithValue("@Mail", e_RVS.Mail);
            cmd.Parameters.AddWithValue("@Edif", e_RVS.Edif);
            cmd.Parameters.AddWithValue("@AulaR", e_RVS.AulaR);
            cmd.Parameters.AddWithValue("@Checkin", e_RVS.Checkin);
            cmd.Parameters.AddWithValue("@Checout", e_RVS.Checout);
            cmd.Parameters.AddWithValue("@MotV", e_RVS.MotV);
            cmd.Parameters.AddWithValue("@PhVis", e_RVS.PhVis);

            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

    }
}
