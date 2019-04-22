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
    class BeneficiariaBD
    {
        Beneficiaria b = new Beneficiaria();
        DatosFamiliares df = new DatosFamiliares();
        DatosEducativos de = new DatosEducativos();
        public void insertarBeneficiaria(Beneficiaria bf)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_InsertBeneficiaria";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@CODIGO_BENEFICIARIA", bf.CodBeneficiaria);
            comm.Parameters.AddWithValue("@NUM_CAUSA ", bf.NumCausa);
            comm.Parameters.AddWithValue("@NOMBRES", bf.NombresBeneficiaria);
            comm.Parameters.AddWithValue("@APELLIDOS", bf.ApellidosBeneficiaria);
            comm.Parameters.AddWithValue("@ETNIA", bf.EtniaBe);
            comm.Parameters.AddWithValue("@NACIONALIDAD", bf.NacionalidadBe);
            comm.Parameters.AddWithValue("@IDENTIFICACION", bf.IdentificacionBe);
            comm.Parameters.AddWithValue("@FECHA_NACIMIENTO", bf.FechaDeNacimientoBe.Date);
            comm.Parameters.AddWithValue("@LUGAR_NACIMIENTO", bf.LugarDeNacimientoBe);
            comm.Parameters.AddWithValue("@SEXO ", bf.SexoBe);
            comm.Parameters.AddWithValue("@CORREO_ELECTRONICO", bf.CorreoElectronicoBe);
            comm.Parameters.AddWithValue("@ESTADO_CIVIL", bf.EstadoCivilBe);
            comm.Parameters.AddWithValue("@FECHA_ENTRADA", bf.FechaDeEntradaBe.Date);
            comm.Parameters.AddWithValue("@ID_CONTACTO_FAMILIAR_PRINCIPAL", bf.IdContactoFamiliarPrincipal);
            comm.Parameters.AddWithValue("@INSTITUCION_EDUCATIVA_ACTUAL", bf.InstitucionEducativaActual);
            comm.Parameters.AddWithValue("@ANO_ESCOLAR_ACTUAL", bf.AñoEscolar);
            comm.Parameters.AddWithValue("@DISCAPACIDAD", bf.Discapacidad);
            comm.Parameters.AddWithValue("@OBSERVACIONES", bf.ObservacioneBe);
            comm.ExecuteNonQuery();
            conexion.cerrarConexion();
        }


        public Boolean verificarId(String identificacion)
        {
            Boolean verificado = true;
            //abrir conexion 
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            string consulta = "SELECT CODIGO_BENEFICIARIA FROM BENEFICIARIA WHERE CODIGO_BENEFICIARIA ='" + identificacion + "'";
            try
            {
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
                MessageBox.Show("Error al ejecutar la consulta");
            }
            return verificado;
        }


        public void consultarBeneficiaria(DataGridView dtgv, int buscaPor, String datoConsulta)
        {
            //INSERTAR VALORES DESDE BD
            //abrir conexion 
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            //insertar valores
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            String consulta = "";
            Boolean existe = false;
            if (datoConsulta == "")
            {
                consulta = "SELECT CODIGO_BENEFICIARIA, IDENTIFICACION, NOMBRES, APELLIDOS FROM BENEFICIARIA";
            }
            else
            {
                if (buscaPor == 0)//busca por codigo de beneficiaria
                {
                    consulta = "SELECT CODIGO_BENEFICIARIA, IDENTIFICACION, NOMBRES, APELLIDOS FROM BENEFICIARIA WHERE CODIGO_BENEFICIARIA= '" + datoConsulta + "'";
                }
                else if (buscaPor == 1)
                {
                    consulta = "SELECT CODIGO_BENEFICIARIA, IDENTIFICACION, NOMBRES, APELLIDOS FROM BENEFICIARIA WHERE APELLIDOS= '" + datoConsulta + "'";
                }
                else
                {
                    consulta = "SELECT CODIGO_BENEFICIARIA, IDENTIFICACION, NOMBRES, APELLIDOS FROM BENEFICIARIA WHERE IDENTIFICACION= '" + datoConsulta + "'";
                }
            }
            try
            {

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

        public void listarBeneficiarias(DataGridView dtgv, int buscarPor, String datoConsulta)
        {
            //INSERTAR VALORES DESDE BD
            //abrir conexion 
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            //insertar valores
            DataTable dt = new DataTable();
            String consulta = "";
            if (buscarPor == 0) //todos
            {
                try
                {
                    consulta = "SELECT CODIGO_BENEFICIARIA, NUM_CAUSA, NOMBRES, APELLIDOS, IDENTIFICACION, FECHA_NACIMIENTO, LUGAR_NACIMIENTO, CORREO_ELECTRONICO,ESTADO_CIVIL, FECHA_ENTRADA, FECHA_SALIDA, OBSERVACIONES FROM BENEFICIARIA";
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar los elementos");
                }
            }
            else if (buscarPor == 1)
            {
                try
                {
                    consulta = "SELECT CODIGO_BENEFICIARIA, NUM_CAUSA, NOMBRES, APELLIDOS, IDENTIFICACION, FECHA_NACIMIENTO, LUGAR_NACIMIENTO, CORREO_ELECTRONICO,ESTADO_CIVIL, FECHA_ENTRADA, FECHA_SALIDA, OBSERVACIONES FROM BENEFICIARIA WHERE YEAR(FECHA_ENTRADA) = " + int.Parse(datoConsulta);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar los elementos");
                }
            }
            else if (buscarPor == 2)
            {
                try
                {
                    consulta = "SELECT CODIGO_BENEFICIARIA, NUM_CAUSA, NOMBRES, APELLIDOS, IDENTIFICACION, FECHA_NACIMIENTO, LUGAR_NACIMIENTO, CORREO_ELECTRONICO,ESTADO_CIVIL, FECHA_ENTRADA, FECHA_SALIDA, OBSERVACIONES FROM BENEFICIARIA WHERE YEAR(FECHA_SALIDA) = " + int.Parse(datoConsulta);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar los elementos");
                }
            }
            else if (buscarPor == 3)
            {
                try
                {

                    consulta = "SELECT CODIGO_BENEFICIARIA, NUM_CAUSA, NOMBRES, APELLIDOS, IDENTIFICACION, FECHA_NACIMIENTO, LUGAR_NACIMIENTO, CORREO_ELECTRONICO,ESTADO_CIVIL, FECHA_ENTRADA, FECHA_SALIDA, OBSERVACIONES FROM BENEFICIARIA WHERE CAST((DATEDIFF(DAY,FECHA_NACIMIENTO, GETDATE())/365.25) AS INT) = " + int.Parse(datoConsulta);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar los elementos");
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(consulta, conexion.conn);
            da.Fill(dt);
            dtgv.DataSource = dt;
        }


        public void consultarDatosFamiliares(DataGridView dtgv, int datoConsulta)
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
                da = new SqlDataAdapter("SELECT * FROM DATOS_FAMILIARES WHERE CODIGO_BENEFICIARIA=" + datoConsulta, conexion.conn);
                da.Fill(dt);
                dtgv.DataSource = dt;
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los elementos");
            }
        }

        public void consultarDatosEducativos(DataGridView dtgv, int datoConsulta)
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
                da = new SqlDataAdapter("SELECT * FROM DATOS_EDUCATIVOS WHERE CODIGO_BENEFICIARIA=" + datoConsulta, conexion.conn);
                da.Fill(dt);
                dtgv.DataSource = dt;
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los elementos");
            }
        }

        public void consultarDatosLaborales(DataGridView dtgv, int datoConsulta)
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
                da = new SqlDataAdapter("SELECT * FROM DATOS_LABORALES WHERE CODIGO_BENEFICIARIA=" + datoConsulta, conexion.conn);
                da.Fill(dt);
                dtgv.DataSource = dt;
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los elementos");
            }
        }

        public void consultarHistorialCronologico(DataGridView dtgv, int datoConsulta)
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
                da = new SqlDataAdapter("SELECT * FROM HISTORIAL_CRONOLOGICO WHERE CODIGO_BENEFICIARIA=" + datoConsulta, conexion.conn);
                da.Fill(dt);
                dtgv.DataSource = dt;
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los elementos");
            }
        }


        public void consultarTalleres(DataGridView dtgv, int datoConsulta)
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
                da = new SqlDataAdapter("SELECT * FROM TALLER WHERE CODIGO_BENEFICIARIA=" + datoConsulta, conexion.conn);
                da.Fill(dt);
                dtgv.DataSource = dt;
                conexion.cerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los elementos");
            }
        }       


        public void insertarDatosFamiliares(DatosFamiliares df)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_InsertarDatosFamiliares";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@CODIGO_BENEFICIARIA", df.CodigoBeneficiaria);
            comm.Parameters.AddWithValue("@IDENTIFICACION_CONTACTO ", df.IdentifiacionContacto);
            comm.Parameters.AddWithValue("@NOMBRES", df.NombresFamiliar);
            comm.Parameters.AddWithValue("@APELLIDOS", df.ApellidosFamiliar);;
            comm.Parameters.AddWithValue("@FECHA_NACIMIENTO", df.FechDeNacimientoFa.Date);
            comm.Parameters.AddWithValue("@NIVEL_EDUCATIVO", df.NivelEducativo);
            comm.Parameters.AddWithValue("@PROFESION ", df.Profesion);
            comm.Parameters.AddWithValue("@DIRECCION_DOMICILIO", df.DireccionDomicilio);
            comm.Parameters.AddWithValue("@PARENTESCO", df.Prentezco);
            comm.Parameters.AddWithValue("@TELEFONO", df.Telefono);
            comm.Parameters.AddWithValue("@SITUACION_LABORAL", df.SituacionLaboral);
            comm.Parameters.AddWithValue("@HORARIO_TRABAJO", df.HorarioDeTrabajo);
            comm.Parameters.AddWithValue("@INGRESO_MENSUAL", df.IngresoMensual);
            comm.Parameters.AddWithValue("@TIENE_DISCAPACIDAD", df.TieneDiscapacidad);
            comm.Parameters.AddWithValue("@OBSERVACIONES", df.Observaciones);
            comm.ExecuteNonQuery();
            conexion.cerrarConexion();
        }


        public void insertarDatosEducativos(DatosEducativos de)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_InsertarDatosEducativos";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@CODIGO_BENEFICIARIA", de.CodigoBeneficiaria);
            comm.Parameters.AddWithValue("@NOMBRE_INSTITUCION", de.NombresInstitucion);
            comm.Parameters.AddWithValue("@TELEFONO_INSTITUCION", de.TelefonoInstitucion); ;
            comm.Parameters.AddWithValue("@ANOS_CURSADOS", de.AñosCursados);
            comm.Parameters.AddWithValue("@JORNADA", de.Jornada);
            comm.Parameters.AddWithValue("@DIRECCION", de.Direccion);
            comm.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public void darDeBajaBeneficiaria(int codBeneficiara, DateTime fechaSalida)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_DarDeBajaBeneficiaria";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@CODIGO_BENEFICIARIA", codBeneficiara);
            comm.Parameters.AddWithValue("@FECHA_SALIDA", fechaSalida);
            comm.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public void reingresarBeneficiaria(int codBeneficiara, DateTime fechaEntrada)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_ReingresarBeneficiaria";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@CODIGO_BENEFICIARIA", codBeneficiara);
            comm.Parameters.AddWithValue("@FECHA_ENTRADA", fechaEntrada);
            comm.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public Boolean verificarFechaSalida(String identificacion)
        {
            Boolean verificado = false;
            //abrir conexion 
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            string consulta = "SELECT FECHA_SALIDA FROM BENEFICIARIA WHERE CODIGO_BENEFICIARIA ='" + identificacion + "'";
            try
            {
                SqlCommand comando = new SqlCommand(consulta, conexion.conn);//crea el comando, pero aun no ejecuta
                if (comando.ExecuteScalar().ToString() == "")
                {
                    verificado = true; //no tiene fecha de salida
                }
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta");
            }
            return verificado;
        }

        public Beneficiaria retornarObjetoBeneficiariaPrincipal(String identificacion)
        {
            //abrir conexion 
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            string consulta = "SELECT * FROM BENEFICIARIA WHERE CODIGO_BENEFICIARIA = '"+ identificacion+"'";    
            try
            {
                SqlCommand comando = new SqlCommand(consulta, conexion.conn);//crea el comando, pero aun no ejecuta
                SqlDataReader lector = comando.ExecuteReader();//lee los datos provenientes de la consulta y los guarda en lector 
                while (lector.Read())
                {
                    b = new Beneficiaria(int.Parse(lector.GetValue(0).ToString()), int.Parse(lector.GetValue(1).ToString()), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(),
                        lector.GetValue(4).ToString(), lector.GetValue(5).ToString(), lector.GetValue(6).ToString(), DateTime.Parse(lector.GetValue(7).ToString()), lector.GetValue(8).ToString(),
                        Boolean.Parse(lector.GetValue(9).ToString()), lector.GetValue(10).ToString(), lector.GetValue(11).ToString(), DateTime.Parse(lector.GetValue(12).ToString()),
                        lector.GetValue(16).ToString(), lector.GetValue(17).ToString(), lector.GetValue(18).ToString(),
                        Boolean.Parse(lector.GetValue(25).ToString()), lector.GetValue(26).ToString(), lector.GetValue(20).ToString());
                }
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {                
               MessageBox.Show("Error al ejecutar la consulta");
            }
            return b;
        }
        public DatosFamiliares retornarObjetoDatosFamiliares(int codigo)
        {
            //abrir conexion 
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            string consulta = "SELECT * FROM DATOS_FAMILIARES df JOIN BENEFICIARIA b ON (df.CODIGO_BENEFICIARIA = b.CODIGO_BENEFICIARIA) WHERE b.CODIGO_BENEFICIARIA =" + codigo;
            try
            {
                SqlCommand comando = new SqlCommand(consulta, conexion.conn);//crea el comando, pero aun no ejecuta
                SqlDataReader lector = comando.ExecuteReader();//lee los datos provenientes de la consulta y los guarda en lector 
                while (lector.Read())
                {
                    df = new DatosFamiliares(int.Parse(lector.GetValue(0).ToString()), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), DateTime.Parse(lector.GetValue(4).ToString()),
                        lector.GetValue(5).ToString(), lector.GetValue(6).ToString(), lector.GetValue(7).ToString(), lector.GetValue(8).ToString(), int.Parse(lector.GetValue(9).ToString()),
                        lector.GetValue(10).ToString(), lector.GetValue(11).ToString(), float.Parse(lector.GetValue(12).ToString()), Boolean.Parse(lector.GetValue(13).ToString()),
                        lector.GetValue(14).ToString());
                }
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta");
            }
            return df;
        }

        public DatosEducativos retornarObjetoDatosEducativos(String identificacion)
        {
            //abrir conexion 
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            int codigo = int.Parse(identificacion);
            string consulta = "SELECT * FROM DATOS_EDUCATIVOS de JOIN BENEFICIARIA b ON (de.CODIGO_BENEFICIARIA = b.CODIGO_BENEFICIARIA) WHERE b.CODIGO_BENEFICIARIA = " + codigo;
            try
            {
                SqlCommand comando = new SqlCommand(consulta, conexion.conn);//crea el comando, pero aun no ejecuta
                SqlDataReader lector = comando.ExecuteReader();//lee los datos provenientes de la consulta y los guarda en lector 
                while (lector.Read())
                {
                    de = new DatosEducativos(int.Parse(lector.GetValue(0).ToString()), lector.GetValue(1).ToString(), int.Parse(lector.GetValue(2).ToString()), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString());
                }
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta");
            }
            return de;
        }


        public void actualizarDatosFamiliares(DatosFamiliares df)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_ActualizarDatosFamiliares";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@CODIGO_BENEFICIARIA", df.CodigoBeneficiaria);
            comm.Parameters.AddWithValue("@IDENTIFICACION_CONTACTO ", df.IdentifiacionContacto);
            comm.Parameters.AddWithValue("@NOMBRES", df.NombresFamiliar);
            comm.Parameters.AddWithValue("@APELLIDOS", df.ApellidosFamiliar); ;
            comm.Parameters.AddWithValue("@FECHA_NACIMIENTO", df.FechDeNacimientoFa.Date);
            comm.Parameters.AddWithValue("@NIVEL_EDUCATIVO", df.NivelEducativo);
            comm.Parameters.AddWithValue("@PROFESION ", df.Profesion);
            comm.Parameters.AddWithValue("@DIRECCION_DOMICILIO", df.DireccionDomicilio);
            comm.Parameters.AddWithValue("@PARENTESCO", df.Prentezco);
            comm.Parameters.AddWithValue("@TELEFONO", df.Telefono);
            comm.Parameters.AddWithValue("@SITUACION_LABORAL", df.SituacionLaboral);
            comm.Parameters.AddWithValue("@HORARIO_TRABAJO", df.HorarioDeTrabajo);
            comm.Parameters.AddWithValue("@INGRESO_MENSUAL", df.IngresoMensual);
            comm.Parameters.AddWithValue("@TIENE_DISCAPACIDAD", df.TieneDiscapacidad);
            comm.Parameters.AddWithValue("@OBSERVACIONES", df.Observaciones);
            comm.ExecuteNonQuery();
        }

        public void actualizarDatosEducativos(DatosEducativos de)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_ActualizarDatosEducativos";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@CODIGO_BENEFICIARIA", de.CodigoBeneficiaria);
            comm.Parameters.AddWithValue("@NOMBRE_INSTITUCION", de.NombresInstitucion);
            comm.Parameters.AddWithValue("@TELEFONO_INSTITUCION", de.TelefonoInstitucion); ;
            comm.Parameters.AddWithValue("@ANOS_CURSADOS", de.AñosCursados);
            comm.Parameters.AddWithValue("@JORNADA", de.Jornada);
            comm.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

        public void actualizarBeneficiaria(Beneficiaria bf)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conexion.abrirConexion();
            comm.CommandText = "sp_ActualizarBeneficiaria";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@CODIGO_BENEFICIARIA", bf.CodBeneficiaria);
            comm.Parameters.AddWithValue("@NUM_CAUSA ", bf.NumCausa);
            comm.Parameters.AddWithValue("@NOMBRES", bf.NombresBeneficiaria);
            comm.Parameters.AddWithValue("@APELLIDOS", bf.ApellidosBeneficiaria);
            comm.Parameters.AddWithValue("@ETNIA", bf.EtniaBe);
            comm.Parameters.AddWithValue("@NACIONALIDAD", bf.NacionalidadBe);
            comm.Parameters.AddWithValue("@IDENTIFICACION", bf.IdentificacionBe);
            comm.Parameters.AddWithValue("@FECHA_NACIMIENTO", bf.FechaDeNacimientoBe.Date);
            comm.Parameters.AddWithValue("@LUGAR_NACIMIENTO", bf.LugarDeNacimientoBe);
            comm.Parameters.AddWithValue("@SEXO ", bf.SexoBe);
            comm.Parameters.AddWithValue("@CORREO_ELECTRONICO", bf.CorreoElectronicoBe);
            comm.Parameters.AddWithValue("@ESTADO_CIVIL", bf.EstadoCivilBe);
            comm.Parameters.AddWithValue("@FECHA_ENTRADA", bf.FechaDeEntradaBe.Date);
            comm.Parameters.AddWithValue("@ID_CONTACTO_FAMILIAR_PRINCIPAL", bf.IdContactoFamiliarPrincipal);
            comm.Parameters.AddWithValue("@INSTITUCION_EDUCATIVA_ACTUAL", bf.InstitucionEducativaActual);
            comm.Parameters.AddWithValue("@ANO_ESCOLAR_ACTUAL", bf.AñoEscolar);
            comm.Parameters.AddWithValue("@DISCAPACIDAD", bf.Discapacidad);
            comm.Parameters.AddWithValue("@OBSERVACIONES", bf.ObservacioneBe);
            comm.ExecuteNonQuery();
            conexion.cerrarConexion();
        }

    }
}
