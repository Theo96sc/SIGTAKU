using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    class FichaDeSeguimientoLaboral
    {
        private int _codigoFichaLaboral;
        private DateTime _fechaDeRealizacion;
        private string _cumpleResposabilidades;
        private string _relacionLaboralCompaneros;
        private string _cumpleHorarios;
        private string _cumpleNormas;
        private string _observacionesEmpleador;
        private string _recomendacionesEmpleador;
        private string _observaciones;

        public int CodigoFichaLaboral
        {
            get { return _codigoFichaLaboral; }
            set { _codigoFichaLaboral = value; }
        }
        public DateTime FechaDeRealizcacion
        {
            get { return _fechaDeRealizacion; }
            set { _fechaDeRealizacion = value; }
        }
        public string CumpleResponsabilidades
        {
            get { return _cumpleResposabilidades; }
            set { _cumpleResposabilidades = value; }
        }
        public string RelacionLaboralCompaneros
        {
            get { return _relacionLaboralCompaneros; }
            set { _relacionLaboralCompaneros = value; }
        }
        public string CumpleHorarios
        {
            get { return _cumpleHorarios; }
            set { _cumpleHorarios = value; }
        }
        public string CumpleNormas
        {
            get { return _cumpleNormas; }
            set { _cumpleNormas = value; }
        }
        public string ObservacionesEmpleadors
        {
            get { return _observacionesEmpleador; }
            set { _observacionesEmpleador = value; }
        }
        public string RecomendacionesEmpleador
        {
            get { return _recomendacionesEmpleador; }
            set { _recomendacionesEmpleador = value; }
        }
        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
    }
}
