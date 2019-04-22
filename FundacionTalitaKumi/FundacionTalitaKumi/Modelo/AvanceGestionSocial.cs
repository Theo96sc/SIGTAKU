using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    class AvanceGestionSocial
    {
        private int _codAvance;
        private int _codBeneficiaria;
        private DateTime _fechaDeRealizacion;
        private string _actividad;
        private string _logro;

        public int CodAvance
        {
            get { return _codAvance; }
            set { _codAvance = value; }
        }
        public int CodBeneficiariaAvGS
        {
            get { return _codBeneficiaria; }
            set { _codBeneficiaria = value; }
        }
        public DateTime FechaDeRealizacionAvGS
        {
            get { return _fechaDeRealizacion; }
            set { _fechaDeRealizacion = value; }
        }
        public string Actividad
        {
            get { return _actividad; }
            set { _actividad = value; }
        }
        public string Logro
        {
            get { return _logro; }
            set { _logro = value; }
        }
    }
}
