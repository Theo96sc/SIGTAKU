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
    class InformePAINABD
    {
        InformePAINA p = new InformePAINA();
        public void insertarPAINA(InformePAINA paina)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_InsertarPAINA";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@CODIGO_BENEFICIARIA", paina.CodigoBeneficiariaP);
            comm.Parameters.AddWithValue("@FECHA_REALIZACION", paina.FechaDeRealizacionP);
            comm.Parameters.AddWithValue("@FECHA_PROXIMA_EVALUACION", paina.FechaProximaEvaluacion);
            comm.Parameters.AddWithValue("@OBJETIVO_GENERAL", paina.ObjetivoGeneral);
            comm.Parameters.AddWithValue("@DESARROLLO_PERSONAL",paina.DesarrolloPersonal);
            comm.Parameters.AddWithValue("@DESARROLLO__SOCIAL", paina.DesarrolloSocial);
            comm.Parameters.AddWithValue("@PROFESION", paina.Profesion);
            comm.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public void consultarInformePAINA(DataGridView dtgv, int codBeneficiaria)
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
                da = new SqlDataAdapter("SELECT COD_INFORME_PAINA, FECHA_REALIZACION, FECHA_PROXIMA_EVALUACION, ip.CODIGO_BENEFICIARIA, b.NOMBRES, b.APELLIDOS  FROM INFORME_PAINA ip JOIN BENEFICIARIA b ON(ip.CODIGO_BENEFICIARIA = b.CODIGO_BENEFICIARIA) WHERE ip.CODIGO_BENEFICIARIA = '" + codBeneficiaria + "'", conexion.conn);
                da.Fill(dt);
                dtgv.DataSource = dt;
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los elementos");
            }
        }
        public InformePAINA retornarPAINA(int id)
        {
            //abrir conexion 
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            string consulta = "select top 1 * from INFORME_PAINA where CODIGO_BENEFICIARIA= " + id;
            try
            {
                SqlCommand comando = new SqlCommand(consulta, conexion.conn);//crea el comando, pero aun no ejecuta
                SqlDataReader lector = comando.ExecuteReader();//lee los datos provenientes de la consulta y los guarda en lector
                while (lector.Read())
                {
                    p = new InformePAINA(int.Parse(lector.GetValue(0).ToString()), DateTime.Parse(lector.GetValue(2).ToString()), DateTime.Parse(lector.GetValue(3).ToString()), lector.GetValue(4).ToString(),
                                        lector.GetValue(5).ToString(), lector.GetValue(6).ToString(), lector.GetValue(7).ToString());
                }
                conexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al retornar el objeto PAINA"+ex);
            }
            return p;

        }

    }
}
