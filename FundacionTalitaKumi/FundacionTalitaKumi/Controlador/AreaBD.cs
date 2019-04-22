using FundacionTalitaKumi.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundacionTalitaKumi.Controlador
{
    class AreaBD
    {
        Area a1 = new Area();
        public void insertarArea(Area area)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_InsertarArea";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@NOMBRE", area.Nombre);
            comm.Parameters.AddWithValue("@CODIGO_BENEFICIARIA", area.CodigoBeneficiaria);
            comm.Parameters.AddWithValue("@DIAGNOSTICO", area.Diagnostico);
            comm.Parameters.AddWithValue("@OBJETIVO", area.Objetivo);
            comm.Parameters.AddWithValue("@SOLICITA", area.Solicita);
            comm.Parameters.AddWithValue("@RESPONSABLES_ACTIVIDADES", area.ResponsablesActividades);
            comm.Parameters.AddWithValue("@TIEMPO_ACTIVIDADES", area.TiempoActividades);
            comm.Parameters.AddWithValue("@EVALUACION", area.Evaluacion);
            comm.Parameters.AddWithValue("@OBSERVACIONES", area.Observaciones);
            comm.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public void consultarArea(DataGridView dtgv, int datoConsulta)
        {
            //INSERTAR VALORES DESDE BD
            //abrir conexion 
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            //insertar valores
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                da = new SqlDataAdapter("SELECT NOMBRE, DIAGNOSTICO, OBJETIVO, SOLICITA, RESPONSABLES_ACTIVIDADES, TIEMPO_ACTIVIDADES, EVALUACION, OBSERVACIONES FROM AREA WHERE CODIGO_BENEFICIARIA=" + datoConsulta, conexion.conn);
                da.Fill(dt);
                dtgv.DataSource = dt;
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los elementos");
            }
        }

        public Area retornarArea(int id)
        {
            //abrir conexion 
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            string consulta = "SELECT top 1 NOMBRE, DIAGNOSTICO, OBJETIVO, SOLICITA, RESPONSABLES_ACTIVIDADES, TIEMPO_ACTIVIDADES, EVALUACION, OBSERVACIONES FROM AREA WHERE CODIGO_BENEFICIARIA=" + id;
            try
            {
                SqlCommand comando = new SqlCommand(consulta, conexion.conn);//crea el comando, pero aun no ejecuta
                SqlDataReader lector = comando.ExecuteReader();//lee los datos provenientes de la consulta y los guarda en lector
                while (lector.Read())
                {
                    string first = lector.GetValue(0).ToString();
                    a1 = new Area(first, lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), 
                                  lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString(),
                                  lector.GetValue(6).ToString(), lector.GetValue(7).ToString());                    
                }
                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al retornar el objeto Area"+ex);
            }
            return a1;
           
        }

    }
}
