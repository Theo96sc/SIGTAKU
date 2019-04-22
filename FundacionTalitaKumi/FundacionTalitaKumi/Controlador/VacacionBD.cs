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
    class VacacionBD
    {
        public void consultarVacaciones(DataGridView dtgv, int numRegistros, String datoConsulta)
        {
            //INSERTAR VALORES DESDE BD
            //abrir conexion 
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            //insertar valores
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            string consulta = "";
            try
            {
                if (numRegistros == 0)
                {
                    consulta = "SELECT v.IDENTIFICACION, APELLIDOS, NOMBRES, FECHA_INICIO, FECHA_FIN FROM VACACION v JOIN PERSONAL p ON (v.IDENTIFICACION = p.IDENTIFICACION) WHERE v.IDENTIFICACION='" + datoConsulta + "'ORDER BY APELLIDOS, NOMBRES, FECHA_INICIO";
                }
                else if (numRegistros == 1)//5 útlimos
                {
                    consulta = "SELECT TOP 5 v.IDENTIFICACION, APELLIDOS, NOMBRES, FECHA_INICIO, FECHA_FIN FROM VACACION v JOIN PERSONAL p ON (v.IDENTIFICACION = p.IDENTIFICACION) WHERE v.IDENTIFICACION='" + datoConsulta + "'ORDER BY APELLIDOS, NOMBRES, FECHA_INICIO";
                }
                else
                {
                    consulta = "SELECT TOP 10 v.IDENTIFICACION, APELLIDOS, NOMBRES, FECHA_INICIO, FECHA_FIN FROM VACACION v JOIN PERSONAL p ON (v.IDENTIFICACION = p.IDENTIFICACION) WHERE v.IDENTIFICACION='" + datoConsulta + "'ORDER BY APELLIDOS, NOMBRES, FECHA_INICIO";
                }
                da = new SqlDataAdapter(consulta, conexion.conn);
                da.Fill(dt);
                dtgv.DataSource = dt;
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los elementos");
            }
        }

        public void listarVacaciones(DataGridView dtgv, int buscaPor, String fecha)
        {
            //INSERTAR VALORES DESDE BD
            //abrir conexion 
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            //insertar valores
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            string consulta = "";
            try
            {
                if (buscaPor == 0) //busca Todos
                {
                    consulta = "SELECT v.IDENTIFICACION, APELLIDOS, NOMBRES, FECHA_INICIO, FECHA_FIN FROM VACACION v JOIN PERSONAL p ON (v.IDENTIFICACION = p.IDENTIFICACION)";
                }
                else if (buscaPor == 1)
                {
                    consulta = "SELECT v.IDENTIFICACION, APELLIDOS, NOMBRES, FECHA_INICIO, FECHA_FIN FROM VACACION v JOIN PERSONAL p ON (v.IDENTIFICACION = p.IDENTIFICACION) WHERE MONTH(FECHA_INICIO) = '" + fecha + "'";
                }
                else if (buscaPor == 2)
                {
                    consulta = "SELECT v.IDENTIFICACION, APELLIDOS, NOMBRES, FECHA_INICIO, FECHA_FIN FROM VACACION v JOIN PERSONAL p ON (v.IDENTIFICACION = p.IDENTIFICACION) WHERE MONTH(FECHA_FIN) = '" + fecha + "'";
                }
                da = new SqlDataAdapter(consulta, conexion.conn);
                da.Fill(dt);
                dtgv.DataSource = dt;
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los elementos");
            }
        }

        //verifica 30 dias por ley
        public int insertarVacacion(Vacacion v)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_InsertarVacacion";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@IDENTIFICACION", v.IdentificacionPersonalV);
            comm.Parameters.AddWithValue("@FECHA_INICIO", v.FechaInicioVacaciones);
            comm.Parameters.AddWithValue("@FECHA_FIN", v.FechaFinVacaciones);
            //obtener parametro de retorno
            comm.Parameters.Add("@VERIFICACION", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;
            comm.ExecuteNonQuery();
            int retornoProcedure = Convert.ToInt32(comm.Parameters["@VERIFICACION"].Value);
            Console.WriteLine(retornoProcedure);
            if (retornoProcedure != 1)
            {
                MessageBox.Show("Ha sobrepasado el límite de 30 días de vacaciones para el año actual");
            }
            return retornoProcedure;
        }

        //verifica que no pueda ingresar en el intervalo de otra vacacion
        public int verificarFechaParaVacacion(Vacacion v)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_consultarFechaInicioVacacion";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@FECHA_INICIO", v.FechaInicioVacaciones);
            comm.Parameters.AddWithValue("@FECHA_FIN", v.FechaFinVacaciones);
            comm.Parameters.AddWithValue("@IDENTIFICACION", v.IdentificacionPersonalV);
            //obtener parametro de retorno
            comm.Parameters.Add("@VERIFICACION", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;
            comm.ExecuteNonQuery();
            int retornoProcedure = Convert.ToInt32(comm.Parameters["@VERIFICACION"].Value);
            Console.WriteLine(retornoProcedure);
            if (retornoProcedure != 0)
            {
                MessageBox.Show("No puede guardar una nueva vacación dentro del periodo de otra vacación");
            }
            return retornoProcedure;
        }


        public void eliminarVacacion(Vacacion v)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_eliminarVacacion";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@IDENTIFICACION", v.IdentificacionPersonalV);
            comm.Parameters.AddWithValue("@FECHA_INICIO", v.FechaInicioVacaciones);
            comm.Parameters.AddWithValue("@FECHA_FIN", v.FechaFinVacaciones);
            comm.ExecuteNonQuery();
        }

        public void actualizarVacacion (Vacacion v)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_ActualizarVacacion";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@IDENTIFICACION", v.IdentificacionPersonalV);
            comm.Parameters.AddWithValue("@FECHA_INICIO", v.FechaInicioVacaciones);
            comm.Parameters.AddWithValue("@FECHA_FIN", v.FechaFinVacaciones);
            comm.ExecuteNonQuery();
        }


        public Vacacion retornarObjetoVacacion(String identificacion)
        {
            //abrir conexion 
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            Vacacion v = new Vacacion();
            string consulta = "SELECT * FROM VACACION WHERE IDENTIFICACION =" + identificacion;
            try
            {
                SqlCommand comando = new SqlCommand(consulta, conexion.conn);//crea el comando, pero aun no ejecuta
                SqlDataReader lector = comando.ExecuteReader();//lee los datos provenientes de la consulta y los guarda en lector
                while (lector.Read())
                {
                    v = new Vacacion(lector.GetValue(0).ToString(), Convert.ToDateTime(lector.GetValue(1)), Convert.ToDateTime(lector.GetValue(2)));
                }
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta");
            }
            return v;
        }
    }
}
