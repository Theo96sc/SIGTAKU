using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundacionTalitaKumi.Modelo
{
    public class Beneficiaria
    {

        private int _codBeneficiaria;
        private int _numCausa;
        private string _nombresBeneficiaria;
        private string _apellidosBe;
        private string _identificacionBe;
        private string _etniaBe;
        private string _nacionalidadBe;
        private DateTime _fechaDeNacimientoBe;
        private string _lugarDeNacimientoBe;
        private bool _sexoBe;
        private string _correoElectronicoBe;
        private string _estadoCiviliBe;
        private DateTime _fechaEntradaBe;
        private DateTime _fechaSalidaBe;
        private string _reinsercionFamiliar;
        private string _autonomia;
        private string _idContactoFamiliarPrincipal;
        private string _instituconEducativaActual;
        private string _añoEscolar;
        private string _observacionesBe;
        private bool _ordenJudicial;
        private string _motivoDeIngreso;
        private bool _consumeDrogas;
        private bool _perteneceAPandillas;
        private string _evasion;
        private bool _callejizacion;
        private bool _discapacidad;
        private bool _tipoDiscapacidad;
        private int _numCarnetConadis;
        private bool _tieneEnfermedad;
        private bool _tieneTratamiento;
        private string _nombresYApellidosDoctor;
        private string _nombreHospital;
        private string _direccionHospital;
        private bool _tomaMedicacion;
        private string _nombreMedicacion;
        private DateTime _horarioModificacion;
        private bool _tomaAnticonceptivos;
        private string _nombreAnticonceptivos;
        private DateTime _fechaInicioAnticonceptivo;
        private int _duracionTomaAnticonceptivos;

        public Beneficiaria(int codBeneficiaria, int numCausa, string nombresBeneficiaria, string apellidosBe, string etniaBe, string nacionalidadBe, string identificacionBe, DateTime fechaDeNacimientoBe, string lugarDeNacimientoBe, bool sexoBe, string correoElectronicoBe, string estadoCiviliBe, DateTime fechaEntradaBe, string idContactoFamiliarPrincipal, string instituconEducativaActual, string añoEscolar, bool discapacidad, string observacionesBe)
        {
            _codBeneficiaria = codBeneficiaria;
            _numCausa = numCausa;
            _nombresBeneficiaria = nombresBeneficiaria;
            _apellidosBe = apellidosBe;
            _identificacionBe = identificacionBe;
            _etniaBe = etniaBe;
            _nacionalidadBe = nacionalidadBe;
            _fechaDeNacimientoBe = fechaDeNacimientoBe;
            _lugarDeNacimientoBe = lugarDeNacimientoBe;
            _sexoBe = sexoBe;
            _correoElectronicoBe = correoElectronicoBe;
            _estadoCiviliBe = estadoCiviliBe;
            _fechaEntradaBe = fechaEntradaBe;
            _idContactoFamiliarPrincipal = idContactoFamiliarPrincipal;
            _instituconEducativaActual = instituconEducativaActual;
            _añoEscolar = añoEscolar;
            _observacionesBe = observacionesBe;
            _discapacidad = discapacidad;
        }

        public Beneficiaria(int codBeneficiaria, int numCausa, string nombresBeneficiaria, string apellidosBe, string etniaBe, string nacionalidadBe, string identificacionBe, DateTime fechaDeNacimientoBe, string lugarDeNacimientoBe, bool sexoBe, string correoElectronicoBe, string estadoCiviliBe, DateTime fechaEntradaBe, string idContactoFamiliarPrincipal, string instituconEducativaActual, string añoEscolar, bool discapacidad, string observacionesBe, string causasIngreso)
        {
            _codBeneficiaria = codBeneficiaria;
            _numCausa = numCausa;
            _nombresBeneficiaria = nombresBeneficiaria;
            _apellidosBe = apellidosBe;
            _identificacionBe = identificacionBe;
            _etniaBe = etniaBe;
            _nacionalidadBe = nacionalidadBe;
            _fechaDeNacimientoBe = fechaDeNacimientoBe;
            _lugarDeNacimientoBe = lugarDeNacimientoBe;
            _sexoBe = sexoBe;
            _correoElectronicoBe = correoElectronicoBe;
            _estadoCiviliBe = estadoCiviliBe;
            _fechaEntradaBe = fechaEntradaBe;
            _idContactoFamiliarPrincipal = idContactoFamiliarPrincipal;
            _instituconEducativaActual = instituconEducativaActual;
            _añoEscolar = añoEscolar;
            _observacionesBe = observacionesBe;
            _discapacidad = discapacidad;
            _motivoDeIngreso = causasIngreso;
        }


        public Beneficiaria(int codBeneficiaria, int numCausa, string nombresBeneficiaria, string apellidosBe, string etniaBe, string nacionalidadBe, string identificacionBe, DateTime fechaDeNacimientoBe, string lugarDeNacimientoBe, bool sexoBe, string correoElectronicoBe, string estadoCiviliBe, DateTime fechaEntradaBe, DateTime fechaSalidaBe, string reinsercionFamiliar, string autonomia, string idContactoFamiliarPrincipal, string instituconEducativaActual, string añoEscolar, bool ordenJudicial, string motivoDeIngreso, bool consumeDrogas, bool perteneceAPandillas, string evasion, bool callejizacion, bool discapacidad, string observacionesBe, bool tipoDiscapacidad, int numCarnetConadis, bool tieneEnfermedad, bool tieneTratamiento, string nombresYApellidosDoctor, string nombreHospital, string direccionHospital, bool tomaMedicacion, string nombreMedicacion, DateTime horarioModificacion, bool tomaAnticonceptivos, string nombreAnticonceptivos, DateTime fechaInicioAnticonceptivo, int duracionTomaAnticonceptivos)
        {
            _codBeneficiaria = codBeneficiaria;
            _numCausa = numCausa;
            _nombresBeneficiaria = nombresBeneficiaria;
            _apellidosBe = apellidosBe;
            _etniaBe = etniaBe;
            _nacionalidadBe = nacionalidadBe;
            _identificacionBe = identificacionBe;
            _fechaDeNacimientoBe = fechaDeNacimientoBe;
            _lugarDeNacimientoBe = lugarDeNacimientoBe;
            _sexoBe = sexoBe;
            _correoElectronicoBe = correoElectronicoBe;
            _estadoCiviliBe = estadoCiviliBe;
            _fechaEntradaBe = fechaEntradaBe;
            _fechaSalidaBe = fechaSalidaBe;
            _reinsercionFamiliar = reinsercionFamiliar;
            _autonomia = autonomia;
            _idContactoFamiliarPrincipal = idContactoFamiliarPrincipal;
            _instituconEducativaActual = instituconEducativaActual;
            _añoEscolar = añoEscolar;
            _ordenJudicial = ordenJudicial;
            _motivoDeIngreso = motivoDeIngreso;
            _consumeDrogas = consumeDrogas;
            _perteneceAPandillas = perteneceAPandillas;
            _evasion = evasion;
            _callejizacion = callejizacion;
            _discapacidad = discapacidad;
            _observacionesBe = observacionesBe;
            _tipoDiscapacidad = tipoDiscapacidad;
            _numCarnetConadis = numCarnetConadis;
            _tieneEnfermedad = tieneEnfermedad;
            _tieneTratamiento = tieneTratamiento;
            _nombresYApellidosDoctor = nombresYApellidosDoctor;
            _nombreHospital = nombreHospital;
            _direccionHospital = direccionHospital;
            _tomaMedicacion = tomaMedicacion;
            _nombreMedicacion = nombreMedicacion;
            _horarioModificacion = horarioModificacion;
            _tomaAnticonceptivos = tomaAnticonceptivos;
            _nombreAnticonceptivos = nombreAnticonceptivos;
            _fechaInicioAnticonceptivo = fechaInicioAnticonceptivo;
            _duracionTomaAnticonceptivos = duracionTomaAnticonceptivos;
        }

        public Beneficiaria()
        {
        }

        public int CodBeneficiaria
        {
            get { return _codBeneficiaria; }
            set { _codBeneficiaria = value; }
        }
        public int NumCausa
        {
            get { return _numCausa; }
            set { _numCausa = value; }
        }

        public string NombresBeneficiaria
        {
            get { return _nombresBeneficiaria; }
            set { _nombresBeneficiaria = value; }
        }
        public string ApellidosBeneficiaria
        {
            get { return _apellidosBe; }
            set { _apellidosBe = value; }
        }

        public string IdentificacionBe
        {
            get { return _identificacionBe; }
            set { _identificacionBe = value; }
        }
        public string EtniaBe
        {
            get { return _etniaBe; }
            set { _etniaBe = value; }
        }
        public string NacionalidadBe
        {
            get { return _nacionalidadBe; }
            set { _nacionalidadBe = value; }
        }

        public DateTime FechaDeNacimientoBe
        {
            get { return _fechaDeNacimientoBe; }
            set { _fechaDeNacimientoBe = value; }
        }

        public string LugarDeNacimientoBe
        {
            get { return _lugarDeNacimientoBe; }
            set { _lugarDeNacimientoBe = value; }

        }

        public bool SexoBe
        {
            get { return _sexoBe; }
            set { _sexoBe = value; }
        }


        public string CorreoElectronicoBe
        {
            get { return _correoElectronicoBe; }
            set { _correoElectronicoBe = value; }
        }

        public string EstadoCivilBe
        {
            get { return _estadoCiviliBe; }
            set { _estadoCiviliBe = value; }
        }

        public DateTime FechaDeEntradaBe
        {
            get { return _fechaEntradaBe; }
            set { _fechaEntradaBe = value; }
        }

        public DateTime FechaDeSalidaBe
        {
            get { return _fechaSalidaBe; }
            set { _fechaSalidaBe = value; }
        }
        public string ReinsercionFamiliar
        {
            get { return _reinsercionFamiliar; }
            set { _reinsercionFamiliar = value; }
        }
        public string AutonomiaBe
        {
            get { return _autonomia; }
            set { _autonomia = value; }
        }
        public string IdContactoFamiliarPrincipal
        {
            get { return _idContactoFamiliarPrincipal; }
            set { _idContactoFamiliarPrincipal = value; }
        }
        public string InstitucionEducativaActual
        {
            get { return _instituconEducativaActual; }
            set { _instituconEducativaActual = value; }
        }
        public string AñoEscolar
        {
            get { return _añoEscolar; }
            set { _añoEscolar = value; }
        }
        public string ObservacioneBe
        {
            get { return _observacionesBe; }
            set { _observacionesBe = value; }  
        }
    
        public bool OrdenJudicial
        {
            get { return _ordenJudicial; }
            set { _ordenJudicial = value; }
        }
        
        public string MotivoDeIngreso
        {
            get { return _motivoDeIngreso; }
            set { _motivoDeIngreso = value; }
        }

        public bool ConsumeDrogas
        {
            get { return _consumeDrogas; }
            set { _consumeDrogas = value; }
        }

        public bool PerteneceAPandillas
        {
            get { return _perteneceAPandillas; }
            set { _perteneceAPandillas = value; }
        }
        public string Evasion
        {
            get { return _evasion; }
            set { _evasion = value; }
        }
        public bool Callejizacion
        {
            get { return _callejizacion; }
            set { _callejizacion = value; }
        }
        public bool Discapacidad
        {
            get { return _discapacidad; }
            set { _discapacidad = value; }
        }
        public bool TipoDeDiscapacidad
        {
            get { return _tipoDiscapacidad; }
            set { _tipoDiscapacidad = value; }
        }
        public int NumCarnetConadis
        {
            get { return _numCarnetConadis; }
            set { _numCarnetConadis = value; }
        }
        public bool TieneEnfermedad
        {
            get { return _tieneEnfermedad; }
            set { _tieneEnfermedad = value; }
        }

        public bool TieneTratamiento
        {
            get { return _tieneTratamiento; }
            set { _tieneTratamiento = value; }
        }

        public string NombresYApellidosDoctor
        {
            get { return _nombresYApellidosDoctor; }
            set { _nombresYApellidosDoctor = value; }
        }
        public string NombreHospital
        {
            get { return _nombreHospital; }
            set { _nombreHospital = value; }
        }

        public string DireccionHospital
        {
            get { return _direccionHospital; }
            set { _direccionHospital = value; }
        }

        public bool TomaMedicacion
        {
            get { return _tomaMedicacion; }
            set { _tomaMedicacion = value; }
        }

        public string NombreMedicacion
        {
            get { return _nombreMedicacion; }
            set { _nombreMedicacion = value; }
        }

        public DateTime HorarioMedicacion
        {
            get { return _horarioModificacion; }
            set { _horarioModificacion = value; }
        }

        public bool TomaAnticonceptivos
        {
            get { return _tomaAnticonceptivos; }
            set { _tomaAnticonceptivos = value; }
        }

        public string NombreAnticonceptivos
        {
            get { return _nombreAnticonceptivos; }
            set { _nombreAnticonceptivos = value; }
        }
        public DateTime FechaInicioAnticonceptivo
        {
            get { return _fechaInicioAnticonceptivo; }
            set { _fechaInicioAnticonceptivo = value; }
        }
        public int DuracionTomaAnticonveptivos
        {
            get { return _duracionTomaAnticonceptivos; }
            set { _duracionTomaAnticonceptivos = value; }
        }



    }
}
