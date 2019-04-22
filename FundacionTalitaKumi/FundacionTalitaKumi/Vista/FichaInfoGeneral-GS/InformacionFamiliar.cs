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

namespace FundacionTalitaKumi.Vista.FichaInfoGeneral_GS
{
    public partial class InformacionFamiliar : Form
    {
        Validar validar = new Validar();
        public InformacionFamiliar()
        {
            InitializeComponent();
            ponerEnMayus();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            //llena una lista de los campos para verificar si estan vacios
            List<String> campos = new List<string>();
            campos.Add(textBox_identificacionCF.Text);
            campos.Add(textBox_nombresCF.Text);
            campos.Add(textBox_apellidosCF.Text);
            campos.Add(dateTimePicker_fechaNacCF.Text);
            campos.Add(textBox_nivelEstudioCF.Text);
            campos.Add(textBox_situacionLaboralCF.Text);
            campos.Add(textBox_telefonosContacto.Text);
            campos.Add(textBox_direccionContacto.Text);
            campos.Add(textBox_parentesco.Text);
            campos.Add(textBox_observacionesCF.Text);

            if (validar.camposVacios(campos) != 0)
            {
                MessageBox.Show("Campos Obligatorios(*) Vacíos");
            }
            else
            {
                DialogResult dr = MessageBox.Show("¿Está seguro que desea guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (comboBox_identificacionCF.SelectedIndex == 0)
                    {
                        if (validar.verificarCedula(textBox_identificacionCF.Text) == true)
                        {
                            //guardar en la bd
                            MessageBox.Show("Registro guardado con éxito");
                            limpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Cédula del Contacto Familiar es Incorrecta");
                        }
                    }
                }
            }
        }

        public void limpiarCampos()
        {
            textBox_identificacionCF.Text = "";
            textBox_nombresCF.Text = "";
            textBox_apellidosCF.Text = "";
            dateTimePicker_fechaNacCF.Text = "";
            textBox_nivelEstudioCF.Text = "";
            textBox_situacionLaboralCF.Text = "";
            textBox_telefonosContacto.Text = "";
            textBox_direccionContacto.Text = "";
            textBox_parentesco.Text = "";
            textBox_observacionesCF.Text = "";
        }

        //validaciones
        private void textBox_nombresCF_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }

        private void textBox_apellidosCF_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }

        private void textBox_nivelEstudioCF_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }

        private void textBox_situacionLaboralCF_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }

        private void textBox_telefonosContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposNumericos(e);
        }

        private void textBox_parentesco_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }

        public void ponerEnMayus()
        {
            textBox_nombresCF.CharacterCasing = CharacterCasing.Upper;
            textBox_apellidosCF.CharacterCasing = CharacterCasing.Upper;
            textBox_nivelEstudioCF.CharacterCasing = CharacterCasing.Upper;
            textBox_situacionLaboralCF.CharacterCasing = CharacterCasing.Upper;
            textBox_direccionContacto.CharacterCasing = CharacterCasing.Upper;
            textBox_parentesco.CharacterCasing = CharacterCasing.Upper;
            textBox_observacionesCF.CharacterCasing = CharacterCasing.Upper;

        }
    }
}
    