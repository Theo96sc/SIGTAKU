using FundacionTalitaKumi.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundacionTalitaKumi.Vista.Beneficiaria
{
    public partial class DatosPersonalesBeneficiarias : Form
    {
        Boolean vieneDeActualizar = false;
        BeneficiariaBD bbd = new BeneficiariaBD();
        FundacionTalitaKumi.Modelo.Personal personal = new Modelo.Personal();
        FundacionTalitaKumi.Modelo.DatosFamiliares daFamiliares = new Modelo.DatosFamiliares();
        FundacionTalitaKumi.Modelo.Beneficiaria beneficiariaRegistrada = new Modelo.Beneficiaria();
        FundacionTalitaKumi.Modelo.Beneficiaria beneficiaria = new Modelo.Beneficiaria();
        FundacionTalitaKumi.Modelo.DatosEducativos datosEducativos = new Modelo.DatosEducativos();

        public DatosPersonalesBeneficiarias(String tipo, FundacionTalitaKumi.Modelo.Personal personal, FundacionTalitaKumi.Modelo.Beneficiaria beneficiaria)
        {
            InitializeComponent();
            this.TopLevel= false;
            this.personal = personal;
            this.beneficiaria = beneficiaria;
            button_actualizar.Visible = false;
            buttonCancelar.Visible = false;
            button_regresar.Visible = false;
            comboBox_cedula.SelectedIndex = 0;
            comboBox_cedula.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_identificacionCF.SelectedIndex = 0;
            comboBox_identificacionCF.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_estadoCivil.SelectedIndex = 0;
            comboBox_estadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_discapacidad.SelectedIndex = 1;
            comboBox_discapacidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_estado.SelectedIndex = 0;
            comboBox_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Jornada.SelectedIndex = 0;
            comboBox_Jornada.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_estado.Enabled = false;
            comboBox_etnia.SelectedIndex = 0;
            comboBox_etnia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_nivelEstudio.SelectedIndex = 0;
            comboBox_nivelEstudio.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_situacionLaboralCF.SelectedIndex = 0;
            comboBox_situacionLaboralCF.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_parentezco.SelectedIndex = 0;
            comboBox_parentezco.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_anoEnCurso.SelectedIndex = 0;
            comboBox_anoEnCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            label_darDeBaja.Hide();
            dateTimePicker_fechaNac.MaxDate = DateTime.Now;
            dateTimePicker_fechaEntrada.MaxDate = DateTime.Now;
            dateTimePicker_fechaNacCF.MaxDate = DateTime.Now.AddYears(-18);

            //radioButton_mujer.Select();

            ponerEnMayus();

            if (tipo == "C")
            {
                datosParaConsulta();
                setearDatos();
            }else if(tipo == "R")
            {
                button_guardar.Visible = true;
                button_limpiar.Visible = true;
                button_regresar.Visible = true;
                button_actualizar.Visible = false;
                buttonCancelar.Visible = false;
            }

            //solo para la consulta de datos
            if(tipo=="" && personal.Tipo == "ADMINISTRADOR/A")//administradora
            {                
                button_actualizar.Visible = true;
                button_guardar.Visible = false;
                button_limpiar.Visible = false;
                buttonCancelar.Visible = false;
            }else if(tipo == "" && personal.Tipo != "ADMINISTRADOR/A")
            {
                button_actualizar.Visible = false;
                button_guardar.Visible = false;
                button_limpiar.Visible = false;
                buttonCancelar.Visible = false;
            }

        }

        Validar validar = new Validar();
        Boolean estaLleno = false;
        Boolean esCorrecto = false;
        Boolean esPasaporte = false;
        Boolean tieneCorreo = false;
        private void button_guardar_Click(object sender, EventArgs e)
        {
            Boolean sexo = false;
            Boolean discapacidad = false;
            if (radioButton_mujer.Checked)
            {
                sexo = true;
            }
           
            if(comboBox_discapacidad.SelectedIndex == 0)
            {
                discapacidad = true;
            }      
            if(textBox_correo.Text != "")
            {
                tieneCorreo = true;
            }                

            //llena una lista de los campos para verificar si estan vacios
            List<String> campos = new List<string>();
            campos.Add(textBox_codigo.Text);
            campos.Add(textBox_nombres.Text);
            campos.Add(textBox_apellidos.Text);
            campos.Add(textBox_lugarNac.Text);
            campos.Add(textBox_numCausa.Text);
            campos.Add(dateTimePicker_fechaNac.Text);
            campos.Add(dateTimePicker_fechaEntrada.Text);
            campos.Add(textBox_nacionalidad.Text);

            campos.Add(textBox_identificacionCF.Text);
            campos.Add(textBox_nombresCF.Text);
            campos.Add(textBox_apellidosCF.Text);
            campos.Add(dateTimePicker_fechaNacCF.Text);
            campos.Add(textBox_telefonosContacto.Text);
            campos.Add(textBox_direccionContacto.Text);


            campos.Add(textBox_institucionEducativa.Text);
            campos.Add(textBox_direccionIE.Text);
            campos.Add(textBox_telefonoIE.Text);

            if (validar.camposVacios(campos) != 0)
            {
                MessageBox.Show("Campos Obligatorios(*) Vacíos");
                if (vieneDeActualizar)
                {
                    button_regresar.Visible = true;
                }
            }
            else
            {
                if(comboBox_identificacionCF.SelectedIndex == 1)
                {
                    esPasaporte = true;
                }
                if (vieneDeActualizar)
                {
                    datosParaConsulta();
                    button_guardar.Visible = false;
                    button_guardar.Visible = false;
                    button_limpiar.Visible = false;                   
                    button_actualizar.Visible = true;
                }

                DialogResult dr = MessageBox.Show("¿Está seguro que desea guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if ((tieneCorreo && validar.validarCorreo(textBox_correo.Text)) || tieneCorreo==false)
                    {
                        if (comboBox_identificacionCF.SelectedIndex == 0)
                        {
                            if (validar.verificarCedula(textBox_identificacionCF.Text)==true)
                            {
                                if (comboBox_identificacionCF.SelectedIndex == 0)
                                {
                                    if (textBox_cedula.Text != "")
                                    {
                                        estaLleno = true;
                                        if(comboBox_cedula.SelectedIndex == 0)
                                        {
                                            if (validar.verificarCedula(textBox_cedula.Text))
                                            {
                                                esCorrecto = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Cédula de Beneficiaria es Incorrecta");
                                            }
                                        }                                        
                                    }
                                }
                               
                            }
                            else
                            {
                                MessageBox.Show("Cédula del Contacto Familiar es Incorrecta");
                            }
                        }
                        if ((estaLleno && esCorrecto) || (estaLleno == false && esCorrecto == false) || esPasaporte)
                        {
                            beneficiariaRegistrada = new Modelo.Beneficiaria(Int16.Parse(textBox_codigo.Text), int.Parse(textBox_numCausa.Text),
                                        textBox_nombres.Text, textBox_apellidos.Text, comboBox_etnia.Text, textBox_nacionalidad.Text, textBox_cedula.Text, DateTime.Parse(dateTimePicker_fechaNac.Value.ToString()),
                                        textBox_lugarNac.Text, sexo, textBox_correo.Text, comboBox_estadoCivil.Text, DateTime.Parse(dateTimePicker_fechaEntrada.Value.ToString()),
                                        textBox_identificacionCF.Text, textBox_institucionEducativa.Text, comboBox_anoEnCurso.Text, discapacidad, textBox_observacones.Text);

                            daFamiliares = new Modelo.DatosFamiliares(Convert.ToInt32(textBox_codigo.Text), textBox_identificacionCF.Text, textBox_nombresCF.Text, textBox_apellidosCF.Text, Convert.ToDateTime(dateTimePicker_fechaNacCF.Value), comboBox_nivelEstudio.Text,
                                textBox_profesion.Text, textBox_direccionContacto.Text, comboBox_parentezco.Text, Convert.ToInt32(textBox_telefonosContacto.Text), comboBox_situacionLaboralCF.Text, textBox_horarioTrabajo.Text, float.Parse(numericUpDown_IngresoMensual.Value.ToString()), discapacidad, textBox_observacionesCF.Text);

                            datosEducativos = new Modelo.DatosEducativos(Convert.ToInt32(textBox_codigo.Text), textBox_institucionEducativa.Text, Convert.ToInt32(textBox_telefonoIE.Text), comboBox_anoEnCurso.Text, comboBox_Jornada.Text, textBox_direccionIE.Text);

                            if (!vieneDeActualizar)
                            {
                                //verifica si existe el ID del personal
                                if (bbd.verificarId(textBox_codigo.Text))
                                {
                                    //guardar en la BD                                               
                                    try
                                    {
                                        bbd.insertarBeneficiaria(beneficiariaRegistrada);
                                        bbd.insertarDatosFamiliares(daFamiliares);
                                        bbd.insertarDatosEducativos(datosEducativos);
                                        MessageBox.Show("Registro guardado con éxito");
                                        limpiarCampos();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Error al guardar los datos");
                                    }

                                }
                            }
                            else
                            {
                                try
                                {
                                    bbd.actualizarBeneficiaria(beneficiariaRegistrada);
                                    MessageBox.Show("Los datos han sido actualizados con éxito");
                                    datosParaConsulta();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error al actualizar los datos");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Correo ingresado es Incorrecto");
                    }
                }  
            }            
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();                   
        }

        private void button_regresar_Click(object sender, EventArgs e)
        {            
            if (vieneDeActualizar)
            {
                datosParaConsulta();
                button_guardar.Visible = false;
                button_limpiar.Visible = false;
                button_regresar.Visible = false;
                button_actualizar.Visible = true;
            }
            else
            {
                this.Close();
            }
        }


        private void button_actualizar_Click(object sender, EventArgs e)
        {
            button_actualizar.Visible = false;
            buttonCancelar.Visible = true;
            button_regresar.Visible = false;
            button_guardar.Visible = true;
            button_limpiar.Visible = true;

            comboBox_estado.Enabled = false;

            textBox_codigo.ReadOnly = true;
            textBox_nombres.ReadOnly = false;
            textBox_apellidos.ReadOnly = false;
            
            textBox_cedula.ReadOnly = true;
            textBox_lugarNac.ReadOnly = false;
            radioButton_mujer.Enabled = false;
            radioButton_hombre.Enabled = false;
            textBox_correo.ReadOnly = false;
            comboBox_estadoCivil.Enabled = true;
            textBox_numCausa.ReadOnly = true;
            textBox_observacones.ReadOnly = false;
            dateTimePicker_fechaNac.Enabled = false;
            dateTimePicker_fechaEntrada.Enabled = false;
            textBox_nacionalidad.ReadOnly = false;
            textBox_horarioTrabajo.ReadOnly = false;
            comboBox_cedula.Enabled = false;
            comboBox_identificacionCF.Enabled = false;

            vieneDeActualizar = true;
            label_darDeBaja.Show();
            if(comboBox_estado.SelectedIndex == 0)
            {
                label_darDeBaja.Text = "Dar de Baja a la Beneficiaria";
            }
            else
            {
                label_darDeBaja.Text = "Reingresar a la Beneficiaria";
            }
        }

 

        //VALIDACIONES

        private void textBox_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposNumericos(e);
        }

        private void textBox_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }

        private void textBox_apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }

        private void textBox_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox_cedula.SelectedIndex == 0)
            {
                validar.validarCamposNumericos(e);
            }
        }

        private void textBox_lugarNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }

        private void textBox_numCausa_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposNumericos(e);
        }

        private void textBox_identificacionCF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox_cedula.SelectedIndex == 0)
            {
                validar.validarCamposNumericos(e);
            }
        }

        private void textBox_nombresCF_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }

        private void textBox_apellidosCF_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }

        private void textBox_telefonosContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposNumericos(e);
        }

        private void textBox_telefonoIE_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposNumericos(e);
        }
 

        private void textBox_nacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            datosParaConsulta();
            buttonCancelar.Visible = false;
            button_actualizar.Visible = true;
            button_guardar.Visible = false;
            button_limpiar.Visible = false;
        }


        /**/

        public void ponerEnMayus()
        {
            textBox_nombres.CharacterCasing = CharacterCasing.Upper;
            textBox_apellidos.CharacterCasing = CharacterCasing.Upper;
            textBox_lugarNac.CharacterCasing = CharacterCasing.Upper;
            textBox_observacones.CharacterCasing = CharacterCasing.Upper;
            textBox_nacionalidad.CharacterCasing = CharacterCasing.Upper;

            textBox_nombresCF.CharacterCasing = CharacterCasing.Upper;
            textBox_apellidosCF.CharacterCasing = CharacterCasing.Upper;
            textBox_direccionContacto.CharacterCasing = CharacterCasing.Upper;
            textBox_observacionesCF.CharacterCasing = CharacterCasing.Upper;
            textBox_profesion.CharacterCasing = CharacterCasing.Upper;
            textBox_horarioTrabajo.CharacterCasing = CharacterCasing.Upper;

            textBox_institucionEducativa.CharacterCasing = CharacterCasing.Upper;
            textBox_direccionIE.CharacterCasing = CharacterCasing.Upper;
        }


        private void setearDatos()
        {
            if (bbd.verificarFechaSalida(beneficiaria.CodBeneficiaria.ToString())) //no tiene fecha de salida
            {
                comboBox_estado.SelectedIndex = 0;
            }
            else
            {
                comboBox_estado.SelectedIndex = 1;
            }
            textBox_codigo.Text = beneficiaria.CodBeneficiaria.ToString();
            textBox_nombres.Text = beneficiaria.NombresBeneficiaria;
            textBox_apellidos.Text = beneficiaria.ApellidosBeneficiaria;
            textBox_cedula.Text = beneficiaria.IdentificacionBe;
            textBox_lugarNac.Text = beneficiaria.LugarDeNacimientoBe;
            if(beneficiaria.SexoBe == true)
            {
                radioButton_mujer.Select();
            }
            else
            {
                radioButton_hombre.Select();
            }
            textBox_correo.Text = beneficiaria.CorreoElectronicoBe;
            comboBox_estadoCivil.Text = beneficiaria.EstadoCivilBe;
            textBox_numCausa.Text = beneficiaria.NumCausa.ToString();
            textBox_observacones.Text = beneficiaria.ObservacioneBe;
            dateTimePicker_fechaNac.Text = beneficiaria.FechaDeNacimientoBe.ToString();
            dateTimePicker_fechaEntrada.Text = beneficiaria.FechaDeEntradaBe.ToString();
            textBox_nacionalidad.Text = beneficiaria.NacionalidadBe;

            /*obtener objeto datos familiares*/
            daFamiliares = bbd.retornarObjetoDatosFamiliares(beneficiaria.CodBeneficiaria);
            textBox_identificacionCF.Text = beneficiaria.IdentificacionBe;
            textBox_nombresCF.Text = daFamiliares.NombresFamiliar;
            textBox_apellidosCF.Text = daFamiliares.ApellidosFamiliar;
            dateTimePicker_fechaNacCF.Text = daFamiliares.FechDeNacimientoFa.ToString();
            textBox_telefonosContacto.Text = daFamiliares.Telefono.ToString();
            textBox_direccionContacto.Text = daFamiliares.DireccionDomicilio;
            comboBox_situacionLaboralCF.Text = daFamiliares.SituacionLaboral;
            comboBox_parentezco.Text = daFamiliares.Prentezco;
            textBox_observacionesCF.Text = daFamiliares.Observaciones;
            textBox_profesion.Text = daFamiliares.Profesion;
            textBox_horarioTrabajo.Text = daFamiliares.HorarioDeTrabajo;

            /*obtener objeto datos educativos*/
            datosEducativos = bbd.retornarObjetoDatosEducativos(beneficiaria.CodBeneficiaria.ToString());
            textBox_institucionEducativa.Text = beneficiaria.InstitucionEducativaActual;
            textBox_direccionIE.Text = datosEducativos.Direccion;
            textBox_telefonoIE.Text = datosEducativos.TelefonoInstitucion.ToString();
            comboBox_anoEnCurso.Text = datosEducativos.AñosCursados;
            comboBox_Jornada.Text = datosEducativos.Jornada;
        }

        private void label_darDeBaja_Click(object sender, EventArgs e)
        {
            if (comboBox_estado.SelectedIndex == 0)
            {
                label_darDeBaja.Text = "Dar de Baja a la Beneficiaria";
                DialogResult dr = MessageBox.Show("¿Está seguro que desea dar de baja a la beneficiaria?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DateTime fechaActual = new DateTime();
                    fechaActual = DateTime.Now;
                    try
                    {
                        bbd.darDeBajaBeneficiaria(Convert.ToInt32(textBox_codigo.Text), fechaActual);
                        MessageBox.Show("Fecha de Salida de la fundación registrada correctamente");
                        comboBox_estado.SelectedIndex = 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo dar de baja a la beneficiaria");
                    }
                }
            }
            else if (comboBox_estado.SelectedIndex == 1)
            {
                label_darDeBaja.Text = "Reingresar a la Beneficiaria";
                DialogResult dr = MessageBox.Show("¿Está seguro que desea reingresar a la beneficiaria?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DateTime fechaActual = new DateTime();
                    fechaActual = DateTime.Now;
                    try
                    {
                        bbd.reingresarBeneficiaria(Convert.ToInt32(textBox_codigo.Text), fechaActual);
                        MessageBox.Show("Fecha de Salida de la fundación registrada correctamente");
                        comboBox_estado.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo reingresar a la beneficiaria");
                    }

                }
            }
           
        }


        private void datosParaConsulta()
        {
            buttonCancelar.Visible = false;
            button_actualizar.Visible = true;
            button_guardar.Visible = false;
            button_limpiar.Visible = false;
            button_regresar.Visible = true;
            textBox_codigo.ReadOnly = true;
            textBox_nombres.ReadOnly = true;
            textBox_apellidos.ReadOnly = true;
            textBox_cedula.ReadOnly = true;
            textBox_lugarNac.ReadOnly = true;
            radioButton_mujer.Enabled = false;
            radioButton_hombre.Enabled = false;
            textBox_correo.ReadOnly = true;
            comboBox_estadoCivil.Enabled = false;
            textBox_numCausa.ReadOnly = true;
            textBox_observacones.ReadOnly = true;
            dateTimePicker_fechaNac.Enabled = false;
            dateTimePicker_fechaEntrada.Enabled = false;
            textBox_nacionalidad.ReadOnly = true;
            comboBox_etnia.Enabled = false;
            comboBox_nivelEstudio.Enabled = false;
            comboBox_Jornada.Enabled = false;
            numericUpDown_IngresoMensual.ReadOnly = true;

            textBox_identificacionCF.Enabled = false;
            textBox_nombresCF.ReadOnly = true;
            textBox_apellidosCF.ReadOnly = true;
            dateTimePicker_fechaNacCF.Enabled = false;
            textBox_telefonosContacto.ReadOnly = true;
            textBox_direccionContacto.ReadOnly = true;
            comboBox_situacionLaboralCF.Enabled = false;
            comboBox_parentezco.Enabled = false;
            textBox_observacionesCF.ReadOnly = true;
            textBox_profesion.ReadOnly = true;
            textBox_horarioTrabajo.ReadOnly = true;

            textBox_institucionEducativa.ReadOnly = true;
            textBox_direccionIE.ReadOnly = true;
            textBox_telefonoIE.ReadOnly = true;
            comboBox_anoEnCurso.Enabled = false;
            comboBox_cedula.Enabled = false;
            comboBox_discapacidad.Enabled = false;
            comboBox_identificacionCF.Enabled = false;
        }

        private void limpiarCampos()
        {
            textBox_codigo.Text = "";
            textBox_nombres.Text = "";
            textBox_apellidos.Text = "";
            textBox_cedula.Text = "";
            textBox_lugarNac.Text = "";
            textBox_correo.Text = "";
            textBox_numCausa.Text = "";
            textBox_observacones.Text = "";
            dateTimePicker_fechaNac.Text = "";
            dateTimePicker_fechaEntrada.Text = "";
            textBox_nacionalidad.Text = "";


            textBox_identificacionCF.Text = "";
            textBox_nombresCF.Text = "";
            textBox_apellidosCF.Text = "";
            dateTimePicker_fechaNacCF.Text = "";
            comboBox_situacionLaboralCF.SelectedIndex = 0;
            textBox_telefonosContacto.Text = "";
            textBox_direccionContacto.Text = "";
            comboBox_parentezco.SelectedIndex = 0;
            textBox_observacionesCF.Text = "";
            textBox_horarioTrabajo.Text = "";
            numericUpDown_IngresoMensual.Value = 0;
            comboBox_discapacidad.SelectedIndex = 1;
            comboBox_nivelEstudio.SelectedIndex = 0;
            comboBox_Jornada.SelectedIndex = 0;

            textBox_institucionEducativa.Text = "";
            textBox_direccionIE.Text = "";
            textBox_telefonoIE.Text = "";
            comboBox_anoEnCurso.Text = "";
        }

        private void comboBox_situacionLaboralCF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_situacionLaboralCF.SelectedIndex == 1)
            {
                label33.Hide();
                label34.Hide();
                textBox_horarioTrabajo.Hide();
                numericUpDown_IngresoMensual.Hide();
                textBox_horarioTrabajo.Text = "N.A";
                numericUpDown_IngresoMensual.Value = 0;
            }
            else if (comboBox_situacionLaboralCF.SelectedIndex == 0)
            {
                label33.Show();
                label34.Show();
                textBox_horarioTrabajo.Show();
                numericUpDown_IngresoMensual.Show();
            }
        }

        private void comboBox_cedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_cedula.Text = "";
        }
    }
}
