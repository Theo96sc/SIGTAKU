using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    class DatosEducativos
    {
        private int _codigoBeneficiaria;
        private string _nombreInstitucion;
        private int _telefonoInstitucion;
        private string _añosCursados;
        private string _jornada;
        private string _direccion;

        public DatosEducativos()
        {
        }

        public DatosEducativos(int codigoBeneficiaria, string nombreInstitucion, int telefonoInstitucion, string añosCursados, string jornada, string direccion)
        {
            _codigoBeneficiaria = codigoBeneficiaria;
            _nombreInstitucion = nombreInstitucion;
            _telefonoInstitucion = telefonoInstitucion;
            _añosCursados = añosCursados;
            _jornada = jornada;
            _direccion = direccion;
        }

        public int CodigoBeneficiaria
        {
            get { return _codigoBeneficiaria; }
            set { _codigoBeneficiaria = value; }
        }
        public string NombresInstitucion
        {
            get { return _nombreInstitucion; }
            set { _nombreInstitucion = value; }
        }
       
        public int TelefonoInstitucion
        {
            get { return _telefonoInstitucion; }
            set { _telefonoInstitucion = value; }
        }
        public string AñosCursados
        {
            get { return _añosCursados; }
            set { _añosCursados = value; }
        }
        public string Jornada
        {
            get { return _jornada; }
            set { _jornada = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
    }
}
