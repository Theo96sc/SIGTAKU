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
    class PersonalBD
    {
        Personal p = new Personal();
        SqlConnection c = new SqlConnection();
        public void listarPersonal(DataGridView dtgv, int buscaPor, string datoConsulta)
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
                if(buscaPor == 0 || datoConsulta == "") //busca Todos
                {
                    consulta = "SELECT TIPO, IDENTIFICACION, APELLIDOS, NOMBRES, FECHA_NACIMIENTO, LUGAR_NACIMIENTO, ESTADO_CIVIL, DIRECCION, TELF_FIJO, TELF_MOVIL, CORREO_ELECTRONICO, ESTUDIOS_REALIZADOS, FECHA_INICIO_CONTRATO FROM PERSONAL ORDER BY APELLIDOS, NOMBRES";
                }else if(buscaPor == 1)
                {
                    consulta = "SELECT TIPO, IDENTIFICACION, APELLIDOS, NOMBRES, FECHA_NACIMIENTO, LUGAR_NACIMIENTO, ESTADO_CIVIL, DIRECCION, TELF_FIJO, TELF_MOVIL, CORREO_ELECTRONICO, ESTUDIOS_REALIZADOS, FECHA_INICIO_CONTRATO FROM PERSONAL WHERE YEAR(FECHA_NACIMIENTO) = '" + datoConsulta + "'ORDER BY APELLIDOS, NOMBRES";
                }
                else
                {
                    consulta = "SELECT TIPO, IDENTIFICACION, APELLIDOS, NOMBRES, FECHA_NACIMIENTO, LUGAR_NACIMIENTO, ESTADO_CIVIL, DIRECCION, TELF_FIJO, TELF_MOVIL, CORREO_ELECTRONICO, ESTUDIOS_REALIZADOS, FECHA_INICIO_CONTRATO FROM PERSONAL WHERE YEAR(FECHA_INICIO_CONTRATO) = '" + datoConsulta + "'ORDER BY APELLIDOS, NOMBRES";
                }
                da = new SqlDataAdapter(consulta, conexion.conn);
                da.Fill(dt);
                dtgv.DataSource = dt;
                c = conexion.cerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los elementos");
            }
        }

        public void consultarPersonal(DataGridView dtgv, int buscaPor,String datoConsulta)
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
                if (datoConsulta == "")
                {
                    consulta = "SELECT IDENTIFICACION, APELLIDOS, NOMBRES, TIPO FROM PERSONAL ORDER BY APELLIDOS, NOMBRES";
                }
                else
                {
                    if (buscaPor == 0)
                    {
                        consulta = "SELECT IDENTIFICACION, APELLIDOS, NOMBRES FROM PERSONAL WHERE IDENTIFICACION='" + datoConsulta + "'";
                    }
                    else if (buscaPor == 1)
                    {
                        consulta = "SELECT IDENTIFICACION, APELLIDOS, NOMBRES FROM PERSONAL WHERE APELLIDOS='" + datoConsulta + "'";
                    }
                }                
                da = new SqlDataAdapter(consulta, conexion.conn);
                da.Fill(dt);
                dtgv.DataSource = dt;
                c = conexion.cerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los elementos");
            }         
           
        }

        

        public Personal retornarObjetoPersonal(String identificacion)
        {
            //abrir conexion 
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            string consulta = "SELECT * FROM PERSONAL WHERE IDENTIFICACION = '" + identificacion +"'";
            try
            {
                SqlCommand comando = new SqlCommand(consulta, conexion.conn);//crea el comando, pero aun no ejecuta
                SqlDataReader lector = comando.ExecuteReader();//lee los datos provenientes de la consulta y los guarda en lector
                while (lector.Read())
                {
                    p = new Personal(lector.GetValue(0).ToString(), Convert.ToInt16(lector.GetValue(1)), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), Convert.ToDateTime(lector.GetValue(5)),
                        lector.GetValue(6).ToString(), lector.GetValue(7).ToString(), Convert.ToInt32(lector.GetValue(8)), Convert.ToInt32(lector.GetValue(9)), lector.GetValue(10).ToString(), lector.GetValue(11).ToString(), Convert.ToInt16(lector.GetValue(12)),
                        lector.GetValue(13).ToString(), lector.GetValue(14).ToString(), lector.GetValue(15).ToString(), Convert.ToInt32(lector.GetValue(16)), lector.GetValue(17).ToString(), Convert.ToDateTime(lector.GetValue(18)), Convert.ToBoolean(lector.GetValue(19)), lector.GetValue(20).ToString(), lector.GetValue(21).ToString());                    
                }
                conexion.cerrarConexion();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al retornar el objeto Personal");
            }
            return p;                
        }


        public Boolean iniciarSesion(string identificacion, string contrasena)
        {
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            SqlCommand comando = new SqlCommand("SELECT IDENTIFICACION, CONTRASENA FROM PERSONAL WHERE IDENTIFICACION = '" + identificacion +"'AND CONTRASENA = '"+ contrasena + "'", conexion.conn);
            SqlDataReader lector = comando.ExecuteReader();
            Console.WriteLine(contrasena);
            if(lector.Read())
            {
                return true;
            }
            else
            {
                return false;
            }            
        }


        public void insertarPersonal(Personal per)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_InsertPersonal";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@IDENTIFICACION", per.IdentificacionPersonal);
            comm.Parameters.AddWithValue("@SEDE_ID", per.SedeId);
            comm.Parameters.AddWithValue("@NOMBRES", per.Nombres);
            comm.Parameters.AddWithValue("@APELLIDOS", per.Apellidos);
            comm.Parameters.AddWithValue("@LUGAR_NACIMIENTO", per.LugarNacimiento);
            comm.Parameters.AddWithValue("@FECHA_NACIMIENTO", per.FechaNacimiento);
            comm.Parameters.AddWithValue("@DIRECCION", per.Direccion);
            comm.Parameters.AddWithValue("@ESTADO_CIVIL", per.EstadoCivil);
            comm.Parameters.AddWithValue("@TELF_FIJO", per.TelfFijo);
            comm.Parameters.AddWithValue("@TELF_MOVIL", per.TelfMovil);
            comm.Parameters.AddWithValue("@TIPO_SANGRE", per.TipoSangre);
            comm.Parameters.AddWithValue("@CORREO_ELECTRONICO", per.CorreoElectronico);
            comm.Parameters.AddWithValue("@NUM_HIJOS", per.NumHijos);
            comm.Parameters.AddWithValue("@ESTUDIOS_REALIZADOS", per.EstudiosRealizados);
            comm.Parameters.AddWithValue("@IDENTIFICACION_REFERENTE_FAMILIAR", per.IdentificacionReferenteFamiliar);
            comm.Parameters.AddWithValue("@NOMBRES_APELLIDOS_REFERENTE_FAMILIAR", per.NombresApellidosReferenteFamiliar);
            comm.Parameters.AddWithValue("@TELEFONO_REF_FAMILIAR", per.TelefonoRefFamiliar);
            comm.Parameters.AddWithValue("@DIRECCION_REF_FAMILIAR", per.DireccionRefFamiliar);
            comm.Parameters.AddWithValue("@FECHA_INICIO_CONTRATO", per.FechaInicioContrato);
            comm.Parameters.AddWithValue("@TIENE_ENFERMEDAD", per.TieneEnfermedad);
            comm.Parameters.AddWithValue("@TIPO", per.Tipo);
            comm.Parameters.AddWithValue("@CONTRASENA", per.Contrasena);
            comm.ExecuteNonQuery();
        }

        public void crearUsuario(String identificacion, String pass)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_CrearUsuario";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@IDENTIFICACION", identificacion);
            comm.Parameters.AddWithValue("@PASSWORD", pass);
            comm.ExecuteNonQuery();
        }

        public void actualizarPersonal(Personal per)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_ActualizarPersonal";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@IDENTIFICACION", per.IdentificacionPersonal);
            comm.Parameters.AddWithValue("@SEDE_ID", per.SedeId);
            comm.Parameters.AddWithValue("@NOMBRES", per.Nombres);
            comm.Parameters.AddWithValue("@APELLIDOS", per.Apellidos);
            comm.Parameters.AddWithValue("@LUGAR_NACIMIENTO", per.LugarNacimiento);
            comm.Parameters.AddWithValue("@FECHA_NACIMIENTO", per.FechaNacimiento);
            comm.Parameters.AddWithValue("@DIRECCION", per.Direccion);
            comm.Parameters.AddWithValue("@ESTADO_CIVIL", per.EstadoCivil);
            comm.Parameters.AddWithValue("@TELF_FIJO", per.TelfFijo);
            comm.Parameters.AddWithValue("@TELF_MOVIL", per.TelfMovil);
            comm.Parameters.AddWithValue("@TIPO_SANGRE", per.TipoSangre);
            comm.Parameters.AddWithValue("@CORREO_ELECTRONICO", per.CorreoElectronico);
            comm.Parameters.AddWithValue("@NUM_HIJOS", per.NumHijos);
            comm.Parameters.AddWithValue("@ESTUDIOS_REALIZADOS", per.EstudiosRealizados);
            comm.Parameters.AddWithValue("@IDENTIFICACION_REFERENTE_FAMILIAR", per.IdentificacionReferenteFamiliar);
            comm.Parameters.AddWithValue("@NOMBRES_APELLIDOS_REFERENTE_FAMILIAR", per.NombresApellidosReferenteFamiliar);
            comm.Parameters.AddWithValue("@TELEFONO_REF_FAMILIAR", per.TelefonoRefFamiliar);
            comm.Parameters.AddWithValue("@DIRECCION_REF_FAMILIAR", per.DireccionRefFamiliar);
            comm.Parameters.AddWithValue("@FECHA_INICIO_CONTRATO", per.FechaInicioContrato);
            comm.Parameters.AddWithValue("@TIENE_ENFERMEDAD", per.TieneEnfermedad);
            comm.Parameters.AddWithValue("@TIPO", per.Tipo);
            comm.ExecuteNonQuery();
        }

        public void actualizarContrasena(String identificacion, String contrasena)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_ActualizarContrasena";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@IDENTIFICACION", identificacion);
            comm.Parameters.AddWithValue("@CONTRASENA", contrasena);
            comm.ExecuteNonQuery();
        }

        public Boolean verificarId(String identificacion)
        {
            Boolean verificado = true;
            //abrir conexion 
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();           
            try
            {
                string consulta = "SELECT IDENTIFICACION FROM PERSONAL WHERE IDENTIFICACION = '" + identificacion + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion.conn);//crea el comando, pero aun no ejecuta
                SqlDataReader lector = comando.ExecuteReader();//lee los datos provenientes de la consulta y los guarda en lector
                while (lector.Read())
                {
                    verificado = false;  //ya esxiste en la BD
                }
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el ID");
                verificado = false;
            }
            return verificado;
        }

        public void eliminarPersonal(Personal per)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_eliminarPersonal";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@IDENTIFICACION", per.IdentificacionPersonal);
            comm.ExecuteNonQuery();
        }
    }
}

