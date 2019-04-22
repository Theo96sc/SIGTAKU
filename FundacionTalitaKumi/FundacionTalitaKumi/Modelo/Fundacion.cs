using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    class Fundacion
    {
        private int _sedeId;
        private int _codBeneficiaria;
        private string _nombreFundacion;
        private string _direccionFundacion;
        private string _telefonoFundacion;

        public int SedeID
        {
            get { return _sedeId; }
            set { _sedeId = value; }
        }
        public int CodBeneficiariaFun
        {
            get { return _codBeneficiaria; }
            set { _codBeneficiaria = value; }
        }
        public string NombreFundacion
        {
            get { return _nombreFundacion; }
            set { _nombreFundacion = value; }
        }
        public string DireccionFundacion
        {
            get { return _direccionFundacion; }
            set { _direccionFundacion = value; }
        }
        public string TelefonoFundacion
        {
            get { return _telefonoFundacion; }
            set { _telefonoFundacion = value; }
        }
    }
}
