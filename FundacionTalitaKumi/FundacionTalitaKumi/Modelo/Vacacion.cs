using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    public class Vacacion
    {
        private string _identificacionPersonal;
        private int _codVacacion;
        private DateTime _fechaInicioV;
        private DateTime _fechaFinV;

        public Vacacion(string identificacionPersonal, DateTime fechaInicioV, DateTime fechaFinV)
        {
            _identificacionPersonal = identificacionPersonal;
            _fechaInicioV = fechaInicioV;
            _fechaFinV = fechaFinV;
        }

        public Vacacion()
        {
        }

        public string IdentificacionPersonalV
        {
            get { return _identificacionPersonal; }
            set { _identificacionPersonal = value; }
        }
        public int CodVacacion
        {
            get { return _codVacacion; }
            set { _codVacacion = value; }
        }
        public DateTime FechaInicioVacaciones
        {
            get { return _fechaInicioV; }
            set { _fechaInicioV = value; }
        }
        public DateTime FechaFinVacaciones
        {
            get { return _fechaFinV; }
            set { _fechaFinV = value; }
        }
    }
}
