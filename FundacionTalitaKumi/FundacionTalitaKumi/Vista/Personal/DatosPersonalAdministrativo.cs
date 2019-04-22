using FundacionTalitaKumi.Controlador;
using FundacionTalitaKumi.Vista.Personal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundacionTalitaKumi.Vista
{
    public partial class DatosPersonalAdministrativo : Form
    {
        Validar validar = new Validar();
        PersonalBD pbd = new PersonalBD();
        FundacionTalitaKumi.Modelo.Personal personal = new FundacionTalitaKumi.Modelo.Personal();
        Boolean vieneDeActualizar = false;
        Boolean idDiferente = false;

        public DatosPersonalAdministrativo(String tipo, FundacionTalitaKumi.Modelo.Personal personal)
        {
            InitializeComponent();
            this.personal = personal;
            this.TopLevel = false;
            button_actualizar.Visible = false;
            buttonCancelar.Hide();
            comboBox_cedula.SelectedIndex = 0;
            comboBox_cedula.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_enfermedad.SelectedIndex = 1;
            comboBox_enfermedad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_estadoCivil.SelectedIndex = 0;
            comboBox_estadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_identificacionCF.SelectedIndex = 0;
            comboBox_identificacionCF.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_tipo.SelectedIndex = 0;
            comboBox_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_tipoSangre.SelectedIndex = 0;
            comboBox_tipoSangre.DropDownStyle = ComboBoxStyle.DropDownList;
            label_cambiarContrasena.Hide();
            //fechas
            dateTimePicker_fechaNac.Value = DateTime.Now;
            dateTimePicker_fechaNac.MaxDate = DateTime.Now.AddYears(-18);
            dateTimePicker_fechaInicioContrato.MaxDate = DateTime.Now;

            pasarAMayusculas();

            if (tipo == "C")
            {
                datosConsulta();
                //setear datos
                setearDatos("C");
            }

        }

        public void limpiarCampos()
        {
            comboBox_tipo.SelectedIndex = 0;
            textBox_identificacion.Text = "";
            textBox_nombres.Text = "";
            textBox_apellidos.Text = "";
            textBox_lugarNac.Text = "";
            dateTimePicker_fechaNac.Text = "";
            textBox_direccion.Text = "";
            comboBox_estadoCivil.SelectedIndex = 0;
            textBox_telfFijo.Text = "";
            textBox_telfMovil.Text = "";
            textBox_correo.Text = "";
            numericUpDown_numHijos.Value = 0;
            textBox_estudiosRealizados.Text = "";
            dateTimePicker_fechaInicioContrato.Text = "";
            comboBox_enfermedad.SelectedIndex = 0;
            textBox_identificacionCF.Text = "";
            textBox_nombresApellidosCF.Text = "";
            textBox_telefonosContacto.Text = "";
            textBox_direccionCF.Text = "";
            textBox_contrasena.Text = "";
        }

        public void setearDatos(String tipo)
        {
            textBox_identificacion.Text = personal.IdentificacionPersonal;
            dateTimePicker_fechaNac.Text = personal.FechaNacimiento.ToString();
            textBox_identificacionCF.Text = personal.IdentificacionReferenteFamiliar;
            if (tipo == "C")
            {
                comboBox_tipo.Text = personal.Tipo;
                textBox_nombres.Text = personal.Nombres;
                textBox_apellidos.Text = personal.Apellidos;
                textBox_lugarNac.Text = personal.LugarNacimiento;
                textBox_direccion.Text = personal.Direccion;
                comboBox_estadoCivil.Text = personal.EstadoCivil;
                textBox_telfFijo.Text = personal.TelfFijo.ToString();
                textBox_telfMovil.Text = personal.TelfMovil.ToString();
                textBox_correo.Text = personal.CorreoElectronico;
                numericUpDown_numHijos.Text = personal.NumHijos.ToString();
                textBox_estudiosRealizados.Text = personal.EstudiosRealizados;
                dateTimePicker_fechaInicioContrato.Text = personal.FechaInicioContrato.ToString();
                comboBox_enfermedad.Text = personal.TieneEnfermedad.ToString();
                textBox_nombresApellidosCF.Text = personal.NombresApellidosReferenteFamiliar;
                textBox_telefonosContacto.Text = personal.TelefonoRefFamiliar.ToString();
                textBox_direccionCF.Text = personal.DireccionRefFamiliar;
                textBox_contrasena.Text = personal.Contrasena;
            }

        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            //generar contraseña con md5
            String contrasenaEncriptada = validar.obtenerMD5(textBox_contrasena.Text);
            Boolean tieneEnfermedad = false;
            if (comboBox_enfermedad.SelectedIndex == 0)
            {
                tieneEnfermedad = true;
            }

            FundacionTalitaKumi.Modelo.Personal personalRegistrado = new FundacionTalitaKumi.Modelo.Personal();
            List<String> campos = new List<string>();
            campos.Add(textBox_identificacion.Text);
            campos.Add(textBox_nombres.Text);
            campos.Add(textBox_apellidos.Text);
            campos.Add(textBox_lugarNac.Text);
            campos.Add(textBox_direccion.Text);
            campos.Add(textBox_correo.Text);
            campos.Add(textBox_estudiosRealizados.Text);
            campos.Add(textBox_identificacionCF.Text);
            campos.Add(textBox_nombresApellidosCF.Text);
            campos.Add(textBox_telefonosContacto.Text);
            campos.Add(textBox_direccionCF.Text);
            campos.Add(textBox_contrasena.Text);

            if (validar.camposVacios(campos) != 0)
            {
                MessageBox.Show("Campos Obligatorios(*) Vacíos");
            }
            else
            {
                //comprueba que las identificaciones del personal y su referente familiar sean diferentes
                if (textBox_identificacion.Text != textBox_identificacionCF.Text)
                {
                    idDiferente = true;
                }

                DialogResult dr = MessageBox.Show("¿Está seguro que desea guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    
                    if (comboBox_cedula.SelectedIndex == 0)//si selecciono cedula personal
                    {
                        if (validar.verificarCedula(textBox_identificacion.Text))
                        {
                            if (validar.validarCorreo(textBox_correo.Text))
                            {
                                if (comboBox_identificacionCF.SelectedIndex == 0)//cedula contacto
                                {
                                    if (validar.verificarCedula(textBox_identificacionCF.Text))
                                    {
                                        if (vieneDeActualizar == false)
                                        {
                                            if (validar.validarContrasena(textBox_contrasena.Text))//esta registrando
                                            {
                                                personalRegistrado = new FundacionTalitaKumi.Modelo.Personal(textBox_identificacion.Text, 0, textBox_nombres.Text,
                                                textBox_apellidos.Text, textBox_lugarNac.Text, dateTimePicker_fechaNac.Value, textBox_direccion.Text, comboBox_estadoCivil.Text, Convert.ToInt32(textBox_telfFijo.Text),
                                                Convert.ToInt32(textBox_telfMovil.Text), comboBox_tipoSangre.Text, textBox_correo.Text, Convert.ToInt16(numericUpDown_numHijos.Value), textBox_estudiosRealizados.Text,
                                                textBox_identificacionCF.Text, textBox_nombresApellidosCF.Text, Convert.ToInt32(textBox_telefonosContacto.Text), textBox_direccionCF.Text, dateTimePicker_fechaInicioContrato.Value, tieneEnfermedad,
                                                comboBox_tipo.Text, contrasenaEncriptada);

                                                //verifica si existe el ID del personal
                                                if (pbd.verificarId(textBox_identificacion.Text) && idDiferente)
                                                {
                                                    //guardar en la BD
                                                    try
                                                    {
                                                        pbd.insertarPersonal(personalRegistrado);
                                                        MessageBox.Show("Registro guardado con éxito");
                                                        limpiarCampos();
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        MessageBox.Show("Error al guardar los datos");
                                                    }
                                                }
                                                else
                                                {
                                                    if (idDiferente == false)
                                                    {
                                                        MessageBox.Show("La identificación del Personal debe ser diferente a la identificación del Referente Familiar");
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("La identificación ya existe en el Sistema");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("La contraseña debe tener mínimo 8 caracteres, tener una minúscula y una mayúscula");
                                            }
                                        }//va a actualizar
                                        else
                                        {
                                            try
                                            {
                                                FundacionTalitaKumi.Modelo.Personal personalActualizar = new FundacionTalitaKumi.Modelo.Personal(textBox_identificacion.Text, 0, textBox_nombres.Text,
                                                textBox_apellidos.Text, textBox_lugarNac.Text, dateTimePicker_fechaNac.Value, textBox_direccion.Text, comboBox_estadoCivil.Text, Convert.ToInt32(textBox_telfFijo.Text),
                                                Convert.ToInt32(textBox_telfMovil.Text), comboBox_tipoSangre.Text, textBox_correo.Text, Convert.ToInt16(numericUpDown_numHijos.Value), textBox_estudiosRealizados.Text,
                                                textBox_identificacionCF.Text, textBox_nombresApellidosCF.Text, Convert.ToInt32(textBox_telefonosContacto.Text), textBox_direccionCF.Text, dateTimePicker_fechaInicioContrato.Value, tieneEnfermedad,
                                                comboBox_tipo.Text, null);
                                                pbd.actualizarPersonal(personalActualizar);
                                                MessageBox.Show("Registro actualizado con éxito");
                                                buttonCancelar.Hide();
                                                datosConsulta();
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("Ha ocurrido un error");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Cédula del Referente Familiar es Incorrecta");
                                    }
                                }
                                else //pasaporte contacto familiar
                                {
                                    if (vieneDeActualizar == false)
                                    {
                                        if (validar.validarContrasena(textBox_contrasena.Text))//esta registrando
                                        {
                                            personalRegistrado = new FundacionTalitaKumi.Modelo.Personal(textBox_identificacion.Text, 0, textBox_nombres.Text,
                                            textBox_apellidos.Text, textBox_lugarNac.Text, dateTimePicker_fechaNac.Value, textBox_direccion.Text, comboBox_estadoCivil.Text, Convert.ToInt32(textBox_telfFijo.Text),
                                            Convert.ToInt32(textBox_telfMovil.Text), comboBox_tipoSangre.Text, textBox_correo.Text, Convert.ToInt16(numericUpDown_numHijos.Value), textBox_estudiosRealizados.Text,
                                            textBox_identificacionCF.Text, textBox_nombresApellidosCF.Text, Convert.ToInt32(textBox_telefonosContacto.Text), textBox_direccionCF.Text, dateTimePicker_fechaInicioContrato.Value, tieneEnfermedad,
                                            comboBox_tipo.Text, contrasenaEncriptada);

                                            //verifica si existe el ID del personal
                                            if (pbd.verificarId(textBox_identificacion.Text) && idDiferente == true)
                                            {
                                                //guardar en la BD
                                                try
                                                {
                                                    pbd.insertarPersonal(personalRegistrado);
                                                    MessageBox.Show("Registro guardado con éxito");
                                                    limpiarCampos();
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show("Error al guardar los datos");
                                                }
                                            }
                                            else
                                            {
                                                if (idDiferente == false)
                                                {
                                                    MessageBox.Show("La identificación del Personal debe ser diferente a la identificación del Referente Familiar");
                                                }
                                                else
                                                {
                                                    MessageBox.Show("La identificación ya existe en el Sistema");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("La contraseña debe tener mínimo 8 caracteres, tener una minúscula y una mayúscula");
                                        }
                                    }//va a actualizar
                                    else
                                    {
                                        try
                                        {
                                            FundacionTalitaKumi.Modelo.Personal personalActualizar = new FundacionTalitaKumi.Modelo.Personal(textBox_identificacion.Text, 0, textBox_nombres.Text,
                                            textBox_apellidos.Text, textBox_lugarNac.Text, dateTimePicker_fechaNac.Value, textBox_direccion.Text, comboBox_estadoCivil.Text, Convert.ToInt32(textBox_telfFijo.Text),
                                            Convert.ToInt32(textBox_telfMovil.Text), comboBox_tipoSangre.Text, textBox_correo.Text, Convert.ToInt16(numericUpDown_numHijos.Value), textBox_estudiosRealizados.Text,
                                            textBox_identificacionCF.Text, textBox_nombresApellidosCF.Text, Convert.ToInt32(textBox_telefonosContacto.Text), textBox_direccionCF.Text, dateTimePicker_fechaInicioContrato.Value, tieneEnfermedad,
                                            comboBox_tipo.Text, null);
                                            pbd.actualizarPersonal(personalActualizar);
                                            MessageBox.Show("Registro actualizado con éxito");
                                            buttonCancelar.Hide();
                                            datosConsulta();
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Ha ocurrido un error");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Correo ingresado es Incorrecto");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cédula del Personal es Incorrecta");
                        }
                    }
                    else //pasaporte personal
                    {
                        if (validar.validarCorreo(textBox_correo.Text))
                        {
                            if (comboBox_identificacionCF.SelectedIndex == 0)//cedula contacto
                            {
                                if (validar.verificarCedula(textBox_identificacionCF.Text))
                                {
                                    if (vieneDeActualizar == false)
                                    {
                                        if (validar.validarContrasena(textBox_contrasena.Text))//esta registrando
                                        {
                                            personalRegistrado = new FundacionTalitaKumi.Modelo.Personal(textBox_identificacion.Text, 0, textBox_nombres.Text,
                                            textBox_apellidos.Text, textBox_lugarNac.Text, dateTimePicker_fechaNac.Value, textBox_direccion.Text, comboBox_estadoCivil.Text, Convert.ToInt32(textBox_telfFijo.Text),
                                            Convert.ToInt32(textBox_telfMovil.Text), comboBox_tipoSangre.Text, textBox_correo.Text, Convert.ToInt16(numericUpDown_numHijos.Value), textBox_estudiosRealizados.Text,
                                            textBox_identificacionCF.Text, textBox_nombresApellidosCF.Text, Convert.ToInt32(textBox_telefonosContacto.Text), textBox_direccionCF.Text, dateTimePicker_fechaInicioContrato.Value, tieneEnfermedad,
                                            comboBox_tipo.Text, contrasenaEncriptada);

                                            //verifica si existe el ID del personal
                                            if (pbd.verificarId(textBox_identificacion.Text) && idDiferente == true)
                                            {
                                                //guardar en la BD
                                                try
                                                {
                                                    pbd.insertarPersonal(personalRegistrado);
                                                    MessageBox.Show("Registro guardado con éxito");
                                                    limpiarCampos();
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show("Error al guardar los datos");
                                                }
                                            }
                                            else
                                            {
                                                if (idDiferente == false)
                                                {
                                                    MessageBox.Show("La identificación del Personal debe ser diferente a la identificación del Referente Familiar");
                                                }
                                                else
                                                {
                                                    MessageBox.Show("La identificación ya existe en el Sistema");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("La contraseña debe tener mínimo 8 caracteres, tener una minúscula y una mayúscula");
                                        }
                                    }//va a actualizar
                                    else
                                    {
                                        try
                                        {
                                            FundacionTalitaKumi.Modelo.Personal personalActualizar = new FundacionTalitaKumi.Modelo.Personal(textBox_identificacion.Text, 0, textBox_nombres.Text,
                                            textBox_apellidos.Text, textBox_lugarNac.Text, dateTimePicker_fechaNac.Value, textBox_direccion.Text, comboBox_estadoCivil.Text, Convert.ToInt32(textBox_telfFijo.Text),
                                            Convert.ToInt32(textBox_telfMovil.Text), comboBox_tipoSangre.Text, textBox_correo.Text, Convert.ToInt16(numericUpDown_numHijos.Value), textBox_estudiosRealizados.Text,
                                            textBox_identificacionCF.Text, textBox_nombresApellidosCF.Text, Convert.ToInt32(textBox_telefonosContacto.Text), textBox_direccionCF.Text, dateTimePicker_fechaInicioContrato.Value, tieneEnfermedad,
                                            comboBox_tipo.Text, null);
                                            pbd.actualizarPersonal(personalActualizar);
                                            MessageBox.Show("Registro actualizado con éxito");
                                            buttonCancelar.Hide();
                                            datosConsulta();
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Ha ocurrido un error");
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Cédula del Referente Familiar es Incorrecta");
                                }
                            }
                            else //pasaporte contacto familiar
                            {
                                if (vieneDeActualizar == false)
                                {
                                    if (validar.validarContrasena(textBox_contrasena.Text))//esta registrando
                                    {
                                        personalRegistrado = new FundacionTalitaKumi.Modelo.Personal(textBox_identificacion.Text, 0, textBox_nombres.Text,
                                        textBox_apellidos.Text, textBox_lugarNac.Text, dateTimePicker_fechaNac.Value, textBox_direccion.Text, comboBox_estadoCivil.Text, Convert.ToInt32(textBox_telfFijo.Text),
                                        Convert.ToInt32(textBox_telfMovil.Text), comboBox_tipoSangre.Text, textBox_correo.Text, Convert.ToInt16(numericUpDown_numHijos.Value), textBox_estudiosRealizados.Text,
                                        textBox_identificacionCF.Text, textBox_nombresApellidosCF.Text, Convert.ToInt32(textBox_telefonosContacto.Text), textBox_direccionCF.Text, dateTimePicker_fechaInicioContrato.Value, tieneEnfermedad,
                                        comboBox_tipo.Text, contrasenaEncriptada);

                                        //verifica si existe el ID del personal
                                        if (pbd.verificarId(textBox_identificacion.Text) && idDiferente == true)
                                        {
                                            //guardar en la BD
                                            try
                                            {
                                                pbd.insertarPersonal(personalRegistrado);
                                                MessageBox.Show("Registro guardado con éxito");
                                                limpiarCampos();
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("Error al guardar los datos");
                                            }
                                        }
                                        else
                                        {
                                            if (idDiferente == false)
                                            {
                                                MessageBox.Show("La identificación del Personal debe ser diferente a la identificación del Referente Familiar");
                                            }
                                            else
                                            {
                                                MessageBox.Show("La identificación ya existe en el Sistema");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("La contraseña debe tener mínimo 8 caracteres, tener una minúscula y una mayúscula");
                                    }
                                }//va a actualizar
                                else
                                {
                                    try
                                    {
                                        FundacionTalitaKumi.Modelo.Personal personalActualizar = new FundacionTalitaKumi.Modelo.Personal(textBox_identificacion.Text, 0, textBox_nombres.Text,
                                        textBox_apellidos.Text, textBox_lugarNac.Text, dateTimePicker_fechaNac.Value, textBox_direccion.Text, comboBox_estadoCivil.Text, Convert.ToInt32(textBox_telfFijo.Text),
                                        Convert.ToInt32(textBox_telfMovil.Text), comboBox_tipoSangre.Text, textBox_correo.Text, Convert.ToInt16(numericUpDown_numHijos.Value), textBox_estudiosRealizados.Text,
                                        textBox_identificacionCF.Text, textBox_nombresApellidosCF.Text, Convert.ToInt32(textBox_telefonosContacto.Text), textBox_direccionCF.Text, dateTimePicker_fechaInicioContrato.Value, tieneEnfermedad,
                                        comboBox_tipo.Text, null);
                                        pbd.actualizarPersonal(personalActualizar);
                                        MessageBox.Show("Registro actualizado con éxito");
                                        buttonCancelar.Hide();
                                        datosConsulta();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Ha ocurrido un error");
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
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }


        private void button1_MouseDown_1(object sender, MouseEventArgs e)
        {
            textBox_contrasena.PasswordChar = '\0';
        }

        private void button1_MouseUp_1(object sender, MouseEventArgs e)
        {
            textBox_contrasena.PasswordChar = '*';
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            button_guardar.Visible = true;
            button_limpiar.Visible = true;
            button_actualizar.Hide();
            buttonCancelar.Show();
            button_verConstrasena.Hide();
            label_cambiarContrasena.Show();

            comboBox_tipo.Enabled = false;
            textBox_identificacion.ReadOnly = true;
            textBox_nombres.ReadOnly = false;
            textBox_apellidos.ReadOnly = false;
            textBox_lugarNac.ReadOnly = false;
            dateTimePicker_fechaNac.Enabled = false;
            textBox_direccion.ReadOnly = false;
            comboBox_estadoCivil.Enabled = true;
            textBox_telfFijo.ReadOnly = false;
            textBox_telfMovil.ReadOnly = false;
            textBox_correo.ReadOnly = false;
            numericUpDown_numHijos.ReadOnly = false;
            textBox_estudiosRealizados.ReadOnly = false;
            dateTimePicker_fechaInicioContrato.Enabled = true;
            comboBox_enfermedad.Enabled = true;
            textBox_identificacionCF.ReadOnly = true;
            textBox_nombresApellidosCF.ReadOnly = false;
            textBox_telefonosContacto.ReadOnly = false;
            textBox_direccionCF.ReadOnly = false;
            comboBox_cedula.Enabled = false;
            comboBox_identificacionCF.Enabled = false;

            //setear datos
            setearDatos("");
            vieneDeActualizar = true;
        }

        private void button_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //VALIDACIONES

        private void textBox_identificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox_cedula.SelectedIndex == 0)
            {
                validar.validarCamposNumericos(e);
            }

        }

        private void textBox_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }

        private void textBox_apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }

        private void textBox_lugarNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }

        private void textBox_telfFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposNumericos(e);
        }

        private void textBox_telfMovil_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_nombresApellidosCF_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }

        private void textBox_telefonosContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposNumericos(e);
        }


        private void comboBox_cedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_identificacion.Text = "";
        }

        public void pasarAMayusculas()
        {
            textBox_nombres.CharacterCasing = CharacterCasing.Upper;
            textBox_apellidos.CharacterCasing = CharacterCasing.Upper;
            textBox_lugarNac.CharacterCasing = CharacterCasing.Upper;
            textBox_direccion.CharacterCasing = CharacterCasing.Upper;
            textBox_estudiosRealizados.CharacterCasing = CharacterCasing.Upper;
            textBox_nombresApellidosCF.CharacterCasing = CharacterCasing.Upper;
            textBox_direccionCF.CharacterCasing = CharacterCasing.Upper;
        }

        public void datosConsulta()
        {
            button_guardar.Visible = false;
            buttonCancelar.Hide();
            button_limpiar.Visible = false;
            button_actualizar.Visible = true;
            label_cambiarContrasena.Hide();
            comboBox_tipo.Enabled = false; ;
            textBox_identificacion.ReadOnly = true;
            textBox_nombres.ReadOnly = true;
            textBox_apellidos.ReadOnly = true;
            textBox_lugarNac.ReadOnly = true;
            dateTimePicker_fechaNac.Enabled = false;
            textBox_direccion.ReadOnly = true;
            comboBox_estadoCivil.Enabled = false;
            textBox_telfFijo.ReadOnly = true;
            textBox_telfMovil.ReadOnly = true;
            textBox_correo.ReadOnly = true;
            numericUpDown_numHijos.ReadOnly = true;
            textBox_estudiosRealizados.ReadOnly = true;
            dateTimePicker_fechaInicioContrato.Enabled = false;
            comboBox_enfermedad.Enabled = false; ;
            textBox_identificacionCF.ReadOnly = true;
            textBox_nombresApellidosCF.ReadOnly = true;
            textBox_telefonosContacto.ReadOnly = true;
            textBox_direccionCF.ReadOnly = true;
            comboBox_cedula.Enabled = false;
            comboBox_identificacionCF.Enabled = false;

            label15.Hide();
            label16.Hide();
            label17.Hide();
            textBox_contrasena.Hide();
            button_verConstrasena.Visible = false;

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            datosConsulta();
            button_cancelar.Hide();
            button_guardar.Hide();
            buttonCancelar.Hide();
            button_actualizar.Show();
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            textBox_contrasena.ReadOnly = false;
            textBox_contrasena.Text = "";
        }

        private void label_cambiarContrasena_Click(object sender, EventArgs e)
        {
            CambiarContrasena cc = new CambiarContrasena(textBox_identificacion.Text, "");
            cc.Show();
        }
    }
}
