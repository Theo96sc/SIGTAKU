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
    public partial class InformacionLaboral : Form
    {
        Validar validar = new Validar();
        public InformacionLaboral()
        {
            InitializeComponent();
            ponerEnMayus();
            comboBox_tipoTrabajo.SelectedIndex = 0;
            comboBox_tipoTrabajo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            textBox_lugar.Text = "";
            textBox_nombresPersona.Text = "";
            textBox1_apellidosPersona.Text = "";
            textBox_ciudad.Text = "";
            dateTimePicker_fechaInicio.Value = DateTime.Now;
            comboBox_tipoTrabajo.SelectedIndex = 0;
            textBox_observaciones.Text = "";
        }

        private void ponerEnMayus()
        {
            textBox_lugar.CharacterCasing = CharacterCasing.Upper;
            textBox_nombresPersona.CharacterCasing = CharacterCasing.Upper;
            textBox1_apellidosPersona.CharacterCasing = CharacterCasing.Upper;
            textBox_ciudad.CharacterCasing = CharacterCasing.Upper;
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            //llena una lista de los campos para verificar si estan vacios
            List<String> campos = new List<string>();
            campos.Add(textBox_lugar.Text);
            campos.Add(textBox_nombresPersona.Text);
            campos.Add(textBox1_apellidosPersona.Text);
            campos.Add(textBox_ciudad.Text);

            if (validar.camposVacios(campos) != 0)
            {
                MessageBox.Show("Campos Obligatorios(*) Vacíos");
            }
            else
            {
                //guardar en la bd
                MessageBox.Show("Registro guardado con éxito");
                limpiarCampos();
            }
        }

        private void textBox_ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }

        private void textBox_nombresPersona_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }

        private void textBox1_apellidosPersona_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }
    }
}
