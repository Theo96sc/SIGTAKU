using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace FundacionTalitaKumi.Controlador
{
    class ConexionBD
    {
        public SqlConnection conn = new SqlConnection("Data Source = LAPTOP-GDVU0HBQ; Initial Catalog = TALITAKUMI_BD; Integrated Security = True");
        public SqlConnection abrirConexion()
        {
            if (conn.State == System.Data.ConnectionState.Closed) { }
                conn.Open();
            return conn;
        }

        public SqlConnection cerrarConexion()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
            return conn;
        }

       

    }
}
