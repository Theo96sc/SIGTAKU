using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    class FichaInfoGeneral
    {
        private int _codFicha;
        private int _codBeneficiaria;
        private string _observaciones;

        public int CodFichaGeneral
        {
            get { return _codFicha; }
            set { _codFicha = value; }
        }
        public int CodBeneficiariaFG
        {
            get { return _codBeneficiaria; }
            set { _codBeneficiaria = value; }
        }
        public string ObservacionesFG
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
    }
}
