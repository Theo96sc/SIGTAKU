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
    class ResumenClinicoBD
    {
        public void insertarResumenClinico(ResumenClinico rc)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_InsertarResumenClinico";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@CODIGO_BENEFICIARIA", rc.CodBeneficiariaRC);
            comm.Parameters.AddWithValue("@FECHA_REALIZACION", rc.FechaDeRealizacionRC);
            comm.Parameters.AddWithValue("@CONDICION_ACTUAL", rc.CondicionActual);
            comm.Parameters.AddWithValue("@QUE_REFIERE", rc.QueRefiere);
            comm.Parameters.AddWithValue("@INTERVENCION", rc.Intervencion);
            comm.Parameters.AddWithValue("@INDICACIONES", rc.Indicaciones);
            comm.Parameters.AddWithValue("@FECHA_SIGUIENTE_SESION", rc.FechaSiguienteSesion);
            comm.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public void consultarResumenClinico(DataGridView dtgv, int codBeneficiaria)
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
                da = new SqlDataAdapter("SELECT COD_SESION, FECHA_REALIZACION, b.CODIGO_BENEFICIARIA, b.NOMBRES, b.APELLIDOS FROM RESUMEN_CLINICO rc JOIN BENEFICIARIA b ON(rc.CODIGO_BENEFICIARIA = b.CODIGO_BENEFICIARIA) WHERE rc.CODIGO_BENEFICIARIA = '" + codBeneficiaria + "'", conexion.conn);
                da.Fill(dt);
                dtgv.DataSource = dt;              
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los elementos");
            }
        }

    }
}
