using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    class HistorialCronologico
    {
        private int _codBeneficiaria;
        private string _nombreCasaAcogida;
        private string _ciudad;
        private DateTime _fechaDeEntrada;
        private DateTime _fechaDeSalida;

        public int CodBeneficiariaHC
        {
            get { return _codBeneficiaria; }
            set { _codBeneficiaria = value; }
        }
        public string NombreCasaAcogida
        {
            get { return _nombreCasaAcogida; }
            set { _nombreCasaAcogida = value; }
        }
        public string Ciudad
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }
        private DateTime FechaDeEntrada
        {
            get { return _fechaDeEntrada; }
            set { _fechaDeEntrada = value; }
        }
        private DateTime FechaDeSalida
        {
            get { return _fechaDeSalida; }
            set { _fechaDeSalida = value; }
        }
    }
}
