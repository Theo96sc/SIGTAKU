using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    class InformeUnicoAjueces
    {
        private int _codigoInforme;
        private int _codigoBeneficiaria;
        private DateTime _fechaDeRealizacion;
        private string _tipoInforme;
        private string _nombresApellidosEntidad;
        private string _direccion;
        private string _provincia;
        private string _representanteLegal;
        private int _telefono;
        private string _situacionFamiliar;
        private string _conclusiones;
        private string _recomendaciones;

        public int CodigoInformeJueces
        {
            get { return _codigoInforme; }
            set { _codigoInforme = value; }
        }
        public int CodigoBeneficiariaJ
        {
            get { return _codigoBeneficiaria; }
            set { _codigoBeneficiaria = value; }
        }
        public DateTime FechaDeRealizacionJ
        {
            get { return _fechaDeRealizacion; }
            set { _fechaDeRealizacion = value; }
        }
        public string TipoInforme
        {
            get { return _tipoInforme; }
            set { _tipoInforme = value; }
        }
        public string NombresApellidosEntidad
        {
            get { return _nombresApellidosEntidad; }
            set { _nombresApellidosEntidad = value; }
        }
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public string Provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }
        public string RepresentanteLegal
        {
            get { return _representanteLegal; }
            set { _representanteLegal = value; }
        }
        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string SituacionFamiliar
        {
            get { return _situacionFamiliar; }
            set { _situacionFamiliar = value; }
        }
        public string Conclusiones
        {
            get { return _conclusiones; }
            set { _conclusiones = value; }
        }
        public string Recomendaciones
        {
            get { return _recomendaciones; }
            set { _recomendaciones = value; }
        }

    }
}
