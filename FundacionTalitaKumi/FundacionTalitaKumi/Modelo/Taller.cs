using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    class Taller
    {
        private int _codTaller;
        private int _codFicha;
        private int _codBeneficiaria;
        private string _nombreTaller;
        private DateTime _fechaDeRealizacion;
        private DateTime _fechaDeFinalizacion;
        private string _nombresPersonaResponsable;
        private string _apellidosPersonaResponsable;
        private bool _certificado;

        public int CodTaller
        {
            get { return _codTaller; }
            set { _codTaller = value;  }
        }
        public int CodFichaT
        {
            get { return _codFicha; }
            set { _codFicha = value; }
        }
        public int CodBeneficiariaTaller
        {
            get { return _codBeneficiaria; }
            set { _codBeneficiaria = value; }
        }
        public string NombreTaller
        {
            get { return _nombreTaller; }
            set { _nombreTaller = value; }
        }
        public DateTime FechaDeRealizacion
        {
            get { return _fechaDeRealizacion; }
            set { _fechaDeRealizacion = value; }
        }
        public DateTime FechaDeFinalizacion
        {
            get { return _fechaDeFinalizacion; }
            set { _fechaDeFinalizacion = value; }
        }
        public string NombresPersonaResponsabelTaller
        {
            get { return _nombresPersonaResponsable; }
            set { _nombresPersonaResponsable = value; }
        }
        public string ApellidosPersonaResponsableTaller
        {
            get { return _apellidosPersonaResponsable; }
            set { _apellidosPersonaResponsable = value; }
        }
        public bool CertificadoTaller
        {
            get { return _certificado; }
            set { _certificado = value; }
        }
    }
}
