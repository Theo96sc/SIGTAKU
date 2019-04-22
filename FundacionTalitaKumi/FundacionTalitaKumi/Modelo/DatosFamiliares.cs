using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    class DatosFamiliares
    {
        private int _codigoBeneficiaria;
        private string _identificacionContacto;
        private string _nombresFamiliar;
        private string _apellidosFamiliar;
        private DateTime _fechaDeNacimientoFa;
        private string _nivelEducativo;
        private string _profesion;
        private string _direccionDomicilio;
        private string _parentezco;
        private int _telefono;
        private string _situacionLaboral;
        private string _horarioDeTrabajo;
        private float _ingresoMensual;
        private bool _tieneDiscapacidad;
        private string _observaciones;

        public DatosFamiliares()
        {
        }

        public DatosFamiliares(int codigoBeneficiaria, string identificacionContacto, string nombresFamiliar, string apellidosFamiliar, DateTime fechaDeNacimientoFa, string nivelEducativo, string profesion, string direccionDomicilio, string parentezco, int telefono, string situacionLaboral, string horarioDeTrabajo, float ingresoMensual, bool tieneDiscapacidad, string observaciones)
        {
            _codigoBeneficiaria = codigoBeneficiaria;
            _identificacionContacto = identificacionContacto;
            _nombresFamiliar = nombresFamiliar;
            _apellidosFamiliar = apellidosFamiliar;
            _fechaDeNacimientoFa = fechaDeNacimientoFa;
            _nivelEducativo = nivelEducativo;
            _profesion = profesion;
            _direccionDomicilio = direccionDomicilio;
            _parentezco = parentezco;
            _telefono = telefono;
            _situacionLaboral = situacionLaboral;
            _horarioDeTrabajo = horarioDeTrabajo;
            _ingresoMensual = ingresoMensual;
            _tieneDiscapacidad = tieneDiscapacidad;
            _observaciones = observaciones;
        }

        public int CodigoBeneficiaria
        {
            get { return _codigoBeneficiaria; }
            set { _codigoBeneficiaria = value; }
        }
        public string IdentifiacionContacto
        {
            get { return _identificacionContacto; }
            set { _identificacionContacto = value; }
        }
        public string NombresFamiliar
        {
            get { return _nombresFamiliar; }
            set { _nombresFamiliar = value; }
        }
        public string ApellidosFamiliar
        {
            get { return _apellidosFamiliar; }
            set { _apellidosFamiliar = value; }
        }
        public DateTime FechDeNacimientoFa
        {
            get { return _fechaDeNacimientoFa; }
            set { _fechaDeNacimientoFa = value; }
        }
        public string NivelEducativo
        {
            get { return _nivelEducativo; }
            set { _nivelEducativo = value; }
        }
        public string Profesion
        {
            get { return _profesion; }
            set { _profesion = value; }
        }
        public string DireccionDomicilio
        {
            get { return _direccionDomicilio; }
            set { _direccionDomicilio = value; }
        }
        public string Prentezco
        {
            get { return _parentezco; }
            set { _parentezco = value; }
        }
        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string SituacionLaboral
        {
            get { return _situacionLaboral; }
            set { _situacionLaboral = value; }
        }
        public string HorarioDeTrabajo
        {
            get { return _horarioDeTrabajo; }
            set { _horarioDeTrabajo = value; }
        }
        public float IngresoMensual
        {
            get { return _ingresoMensual; }
            set { _ingresoMensual = value; }
        }
        public bool TieneDiscapacidad
        {
            get { return _tieneDiscapacidad; }
            set { _tieneDiscapacidad = value; }
        }
        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }





    }
}
