using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    class ResumenClinico
    {
        private int _codSesion;
        private int _codBeneficiaria;
        private DateTime _fechaDeRealizacion;
        private string _condicionActual;
        private string _queRefiere;
        private string _intervencion;
        private string _indicaciones;
        private DateTime _fechaSiguienteSesion;

        public ResumenClinico(int codBeneficiaria, DateTime fechaDeRealizacion, string condicionActual, string queRefiere, string intervencion, string indicaciones, DateTime fechaSiguienteSesion)
        {
            _codBeneficiaria = codBeneficiaria;
            _fechaDeRealizacion = fechaDeRealizacion;
            _condicionActual = condicionActual;
            _queRefiere = queRefiere;
            _intervencion = intervencion;
            _indicaciones = indicaciones;
            _fechaSiguienteSesion = fechaSiguienteSesion;
        }

        public int CodSesion
        {
            get { return _codSesion; }
            set { _codSesion = value; }
        }
        public int CodBeneficiariaRC
        {
            get { return _codBeneficiaria; }
            set { _codBeneficiaria = value; }
        }
        public DateTime FechaDeRealizacionRC
        {
            get { return _fechaDeRealizacion; }
            set { _fechaDeRealizacion = value; }
        }
        public string CondicionActual
        {
            get { return _condicionActual; }
            set { _condicionActual = value; }
        }
        public string QueRefiere
        {
            get { return _queRefiere; }
            set { _queRefiere = value; }
        }
        public string Intervencion
        {
            get { return _intervencion; }
            set { _intervencion = value; }
        }
        public string Indicaciones
        {
            get { return _indicaciones; }
            set { _indicaciones = value; }
        }
        public DateTime FechaSiguienteSesion
        {
            get { return _fechaSiguienteSesion; }
            set { _fechaSiguienteSesion = value; }
        }
    }
}
