using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    class DatosVivienda
    {
        private int _codigoBeneficiaria;
        private string _tipoDeVivienda;
        private string _condicionesGeneralesDeVivienda;
        private string _materialVivienda;
        private string _posesionVivienda;
        private bool _svAgua;
        private bool _svLuz;
        private bool _svTelefono;
        private bool _svSSHH;
        private bool _svInternet;
        private bool _svRecoleccionBasura;
        private bool _tieneSala;
        private bool _tieneComedor;
        private bool _tieneBaño;
        private bool _tieneCocina;
        private bool _tienePozoSeptico;
        private short _numDormitorios;
        private string _estadoTecho;
        private string _estadoPisos;
        private string _estadoParedes;
        private string _estadoPuertas;
        private string _estadoVentanas;
        private string _tipoBarrio;
        private string _equipamientoServicios;
        private string _tejidoSocial;

        public int CodigoBeneficiaria
        {
            get { return _codigoBeneficiaria; }
            set { _codigoBeneficiaria = value; }
        }
        public string TipoDeVivienda
        {
            get { return _tipoDeVivienda; }
            set { _tipoDeVivienda = value; }
        }

        public string CondicionesDeVivienda
        {
            get { return _condicionesGeneralesDeVivienda; }
            set { _condicionesGeneralesDeVivienda = value; }
        }
        public string MaterialVivienda
        {
            get { return _materialVivienda; }
            set { _materialVivienda = value; }
        }
        public string PosesionVivienda
        {
            get { return _posesionVivienda; }
            set { _posesionVivienda = value; }
        }

        public bool SvAgua
        {
            get { return _svAgua; }
            set { _svAgua = value; }
        }

        public bool SvLuz
        {
            get { return _svLuz; }
            set { _svLuz = value; }
        }

        public bool SvTelefono
        {
            get { return _svTelefono; }
            set { _svTelefono = value; }
        }

        public bool SvSSHH
        {
            get { return _svSSHH; }
            set { _svSSHH = value; }
        }

        public bool SvInternet
        {
            get { return _svInternet; }
            set { _svInternet = value; }
        }
        public bool svRecoleccionBasura
        {
            get { return _svRecoleccionBasura; }
            set { _svRecoleccionBasura = value; }
        }
        public bool TieneSala
        {
            get { return _tieneSala; }
            set { _tieneSala = value; }
        }
        public bool TieneComedor
        {
            get { return _tieneComedor; }
            set { _tieneComedor = value; }
        }
        public bool TieneBaño
        {
            get { return _tieneBaño; }
            set { _tieneBaño = value; }
        }
        public bool TieneCocina
        {
            get { return _tieneCocina; }
            set { _tieneCocina = value; }
        }
        public bool TienePozoSeptico
        {
            get { return _tienePozoSeptico; }
            set { _tienePozoSeptico = value; }
        }
        public short NumeroDormitorios
        {
            get { return _numDormitorios; }
            set { _numDormitorios = value; }
        }
        public string EstadoTecho
        {
            get { return _estadoTecho; }
            set { _estadoTecho = value; }
        }
        public string EstadoPisos
        {
            get { return _estadoPisos; }
            set { _estadoPisos = value; }
        }
        public string EstadoParedes
        {
            get { return _estadoParedes; }
            set { _estadoParedes = value; }
        }
        public string EstadoPuertas
        {
            get { return _estadoPuertas; }
            set { _estadoPuertas = value; }
        }
        public string EstadoVentanas
        {
            get { return _estadoVentanas; }
            set { _estadoVentanas = value; }
        }
        public string TipoBarrio
        {
            get { return _tipoBarrio; }
            set { _tipoBarrio = value; }
        }
        public string EquipamientoServicios
        {
            get { return _equipamientoServicios; }
            set { _equipamientoServicios = value; }
        }
        public string TejidoSocial
        {
            get { return _tejidoSocial; }
            set { _tejidoSocial = value; }
        }




    }
}
