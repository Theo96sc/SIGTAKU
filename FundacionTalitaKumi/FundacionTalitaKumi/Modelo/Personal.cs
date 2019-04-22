using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    public class Personal
    {
        private String _identificacion;
        private short _sedeID;
        private String _nombres;
        private String _apellidos;
        private String _lugarNacimiento;
        private DateTime _fechaNacimiento;
        private String _direccion;
        private String _estadoCivil;
        private int _telfFijo;
        private int _telfMovil;
        private String _tipoSangre;
        private String _correoElectronico;
        private short _numHijos;
        private String _estudiosRealizados;
        private String _identificacionreferenteFamiliar;
        private String _nombresapellidosreferenteFamiliar;
        private int _telefonorefFamiliar;
        private String _direccionrefFamiliar;
        private DateTime _fechainicioContrato;
        private bool _tieneEnfermedad;
        private String _tipo;
        private string _contrasena;

        public Personal(string identificacion, short sedeID, string nombres, string apellidos, string lugarNacimiento, DateTime fechaNacimiento, string direccion, string estadoCivil, int telfFijo, int telfMovil, string tipoSangre, string correoElectronico, short numHijos, string estudiosRealizados, string identificacionreferenteFamiliar, string nombresapellidosreferenteFamiliar, int telefonorefFamiliar, string direccionrefFamiliar, DateTime fechainicioContrato, bool tieneEnfermedad, string tipo, string contrasena)
        {
            _identificacion = identificacion;
            _sedeID = sedeID;
            _nombres = nombres;
            _apellidos = apellidos;
            _lugarNacimiento = lugarNacimiento;
            _fechaNacimiento = fechaNacimiento;
            _direccion = direccion;
            _estadoCivil = estadoCivil;
            _telfFijo = telfFijo;
            _telfMovil = telfMovil;
            _tipoSangre = tipoSangre;
            _correoElectronico = correoElectronico;
            _numHijos = numHijos;
            _estudiosRealizados = estudiosRealizados;
            _identificacionreferenteFamiliar = identificacionreferenteFamiliar;
            _nombresapellidosreferenteFamiliar = nombresapellidosreferenteFamiliar;
            _telefonorefFamiliar = telefonorefFamiliar;
            _direccionrefFamiliar = direccionrefFamiliar;
            _fechainicioContrato = fechainicioContrato;
            _tieneEnfermedad = tieneEnfermedad;
            _tipo = tipo;
            _contrasena = contrasena;
        }

        public Personal()
        {

        }

        public String IdentificacionPersonal
        {
            get{return _identificacion;}
            set { _identificacion = value; }
        }
        public short SedeId
        {
            get { return _sedeID; }
            set { _sedeID = value; }
        }
        public String Nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }
        public String Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }
        public String LugarNacimiento
        {
            get { return _lugarNacimiento; }
            set { _lugarNacimiento = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public String Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public String EstadoCivil
        {
            get { return _estadoCivil; }
            set { _estadoCivil = value; }
        }
        public int TelfFijo
        {
            get { return _telfFijo; }
            set { _telfFijo = value; }
        }
        public int TelfMovil
        {
            get { return _telfMovil; }
            set { _telfMovil = value; }
        }
        public String TipoSangre
        {
            get { return _tipoSangre; }
            set { _tipoSangre = value; }
        }
        public String CorreoElectronico
        {
            get { return _correoElectronico; }
            set { _correoElectronico = value; }
        }
        public short NumHijos
        {
            get { return _numHijos; }
            set { _numHijos = value; }
        }
        public String EstudiosRealizados
        {
            get { return _estudiosRealizados; }
            set { _estudiosRealizados = value; }
        }
        public String IdentificacionReferenteFamiliar
        {
            get { return _identificacionreferenteFamiliar; }
            set { _identificacionreferenteFamiliar = value; }
        }
        public String NombresApellidosReferenteFamiliar
        {
            get { return _nombresapellidosreferenteFamiliar; }
            set { _nombresapellidosreferenteFamiliar = value; }
        }
        public int TelefonoRefFamiliar
        {
            get { return _telefonorefFamiliar; }
            set { _telefonorefFamiliar = value; }
        }
        public String DireccionRefFamiliar
        {
            get { return _direccionrefFamiliar; }
            set { _direccionrefFamiliar = value; }
        }
        public DateTime FechaInicioContrato
        {
            get { return _fechainicioContrato; }
            set { _fechainicioContrato = value; }
        }
        public bool TieneEnfermedad
        {
            get { return _tieneEnfermedad; }
            set { _tieneEnfermedad = value; }
        }
        public String Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public String Contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }
    }
}
