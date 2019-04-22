using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    class DerechosVulnerados
    {
        private int _codInforme;
        private int _codBeneficiaria;
        private int _codDerecho;
        private string _tipo;
        private string _riesgos;
        private string _accionesRealizadas;
        private string _accionesFuturas;

        public int CodInformeDV
        {
            get { return _codInforme; }
            set { _codInforme = value; }
        }
        public int CodBeneficiariaDV
        {
            get { return _codBeneficiaria; }
            set { _codBeneficiaria = value; }
        }
        public int CodDerecho
        {
            get { return _codDerecho; }
            set { _codDerecho = value; }
        }
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public string Riesgos
        {
            get { return _riesgos; }
            set { _riesgos = value; }
        }
        public string AccionesRealizadas
        {
            get { return _accionesRealizadas; }
            set { _accionesRealizadas = value; }
        }
        public string AccionesFuturas
        {
            get { return _accionesFuturas; }
            set { _accionesFuturas = value; }
        }
    }
}
