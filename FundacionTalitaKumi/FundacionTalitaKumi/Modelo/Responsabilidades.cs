using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    class Responsabilidades
    {
        private int _codigoBeneficiaria;
        private string _nombresInstitucionTrabajo;
        private string _responsabilidad;
        public int CodigoBeneficiariaRes
        {
            get { return _codigoBeneficiaria; }
            set { _codigoBeneficiaria = value; }
        }
        public string NombresInstitucionTrabajo
        {
            get { return _nombresInstitucionTrabajo; }
            set { _nombresInstitucionTrabajo = value; }
        }
        public string Responsabilidad
        {
            get { return _responsabilidad; }
            set { _responsabilidad = value; }
        }
    }
}
