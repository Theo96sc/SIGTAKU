using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    class InformePGF
    {
        private int _codigoInforme;
        private int _codigoBeneficiaria;
        private string _diagnosticoFamilia;
        private string _diagnosticoEquipo;
        private string _objetivoGeneralFamilia;
        private string _objetivoGeneralEquipo;
        private string _dinamicasInterfamiliares;
        private string _condicionesSocioculturales;
        public int CodigoInformePGF
        {
            get { return _codigoInforme; }
            set { _codigoInforme = value; }
        }
        public int CodigoBeneficiariaP
        {
            get { return _codigoBeneficiaria; }
            set { _codigoBeneficiaria = value; }
        }
        public string DiagnosticoFamilia
        {
            get { return _diagnosticoFamilia; }
            set { _diagnosticoFamilia = value; }
        }
        public string DiagnosticoEquipo
        {
            get { return _diagnosticoEquipo; }
            set { _diagnosticoEquipo = value; }
        }
        public string ObjetivoGeneralFamilia
        {
            get { return _objetivoGeneralFamilia; }
            set { _objetivoGeneralFamilia = value; }
        }
        public string ObjetivoGeneralEquipo
        {
            get { return _objetivoGeneralEquipo; }
            set { _objetivoGeneralEquipo = value; }
        }
        public string DinamicasInterfamiliares
        {
            get { return _dinamicasInterfamiliares; }
            set { _dinamicasInterfamiliares = value; }
        }
        public string CondicionesSocioculturales
        {
            get { return _condicionesSocioculturales; }
            set { _condicionesSocioculturales = value; }
        }


    }
}
