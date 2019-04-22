using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    class Area
    {
        private int _codArea;
        private int _codBeneficiaria;
        private int _codinformePaina;
        private int _infcodigoBeneficiaria;
        private int _codinformePgf;
        private string _diagnostico;
        private string _objetivo;
        private string _solicita;
        private string _descripcionActividades;
        private string _responsablesActividades;
        private string _tiempoActividades;
        private string _evaluacion;
        private string _observaciones;
        private string _nombre;

        public Area(string nombre, string diagnostico, string objetivo, string solicita, string responsablesActividades, string tiempoActividades, string evaluacion, string observaciones)
        {
            _diagnostico = diagnostico;
            _objetivo = objetivo;
            _solicita = solicita;
            _responsablesActividades = responsablesActividades;
            _tiempoActividades = tiempoActividades;
            _evaluacion = evaluacion;
            _observaciones = observaciones;
            _nombre = nombre;
        }
        public Area(int codBeneficiaria, string diagnostico, string objetivo, string solicita, string responsablesActividades, string tiempoActividades, string evaluacion, string observaciones, string nombre)
        {
            _codBeneficiaria = codBeneficiaria;
            _diagnostico = diagnostico;
            _objetivo = objetivo;
            _solicita = solicita;
            _responsablesActividades = responsablesActividades;
            _tiempoActividades = tiempoActividades;
            _evaluacion = evaluacion;
            _observaciones = observaciones;
            _nombre = nombre;
        }


        public Area()
        {
            
        }

        public int CodArea
        {
            get { return _codArea; }
            set { _codArea = value; }
        }
        public int CodigoBeneficiaria
        {
            get { return _codBeneficiaria; }
            set { _codBeneficiaria = value; }
        }
        public int CodInformePaina
        {
            get { return _codinformePaina; }
            set { _codinformePaina = value; }
        }
        public int InfCodigoBeneficiaria
        {
            get { return _infcodigoBeneficiaria; }
            set { _infcodigoBeneficiaria = value; }
        }
        public int CodInformePgf
        {
            get { return _codinformePgf; }
            set { _codinformePgf = value; }
        }
        public string Diagnostico
        {
            get { return _diagnostico; }
            set { _diagnostico = value; }
        }
        public string Objetivo
        {
            get { return _objetivo; }
            set { _objetivo = value; }
        }
        public string Solicita
        {
            get { return _solicita; }
            set { _solicita = value; }
        }
        public string DescripcionActividades
        {
            get { return _descripcionActividades; }
            set { _descripcionActividades = value; }
        }
        public string ResponsablesActividades
        {
            get { return _responsablesActividades; }
            set { _responsablesActividades = value; }
        }
        public string TiempoActividades
        {
            get { return _tiempoActividades; }
            set { _tiempoActividades = value; }
        }
        public string Evaluacion
        {
            get { return _evaluacion; }
            set { _evaluacion = value; }
        }
        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
