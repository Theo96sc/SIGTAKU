using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    class InformePAINA
    {
        private int _codigoInforme;
        private int _codigoBeneficiaria;
        private DateTime _fechaDeRealizacion;
        private DateTime _fechaProximaEvaluacion;
        private string _objetivoGeneral;
        private string _desarrolloPersonal;
        private string _desarrolloSocial;
        private string _profesion;

        public InformePAINA(int codigoBeneficiaria, DateTime fechaDeRealizacion, DateTime fechaProximaEvaluacion, string objetivoGeneral, string desarrolloPersonal, string desarrolloSocial, string profesion)
        {
            _codigoBeneficiaria = codigoBeneficiaria;
            _fechaDeRealizacion = fechaDeRealizacion;
            _fechaProximaEvaluacion = fechaProximaEvaluacion;
            _objetivoGeneral = objetivoGeneral;
            _desarrolloPersonal = desarrolloPersonal;
            _desarrolloSocial = desarrolloSocial;
            _profesion = profesion;
        }
        public InformePAINA()
        {

        }
        public int CodigoInformePAINA
        {
            get { return _codigoInforme; }
            set { _codigoInforme = value; }
        }
        public int CodigoBeneficiariaP
        {
            get { return _codigoBeneficiaria; }
            set { _codigoBeneficiaria = value; }
        }
        public DateTime FechaDeRealizacionP
        {
            get { return _fechaDeRealizacion; }
            set { _fechaDeRealizacion = value; }
        }

        public DateTime FechaProximaEvaluacion
        {
            get { return _fechaProximaEvaluacion; }
            set { _fechaProximaEvaluacion = value; }
        }

        public string ObjetivoGeneral
        {
            get { return _objetivoGeneral; }
            set { _objetivoGeneral = value; }
        }
        public string DesarrolloSocial
        {
            get { return _desarrolloSocial; }
            set { _desarrolloSocial = value; }
        }
        public string DesarrolloPersonal
        {
            get { return _desarrolloPersonal; }
            set { _desarrolloPersonal = value; }
        }

        public string Profesion
        {
            get { return _profesion; }
            set { _profesion = value; }
        }
    }
}
