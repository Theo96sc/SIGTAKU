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
    public partial class InformacionEducativa : Form
    {
        Validar validar = new Validar();
        public InformacionEducativa()
        {
            InitializeComponent();
            ponerEnMayus();
            comboBox_jornada.SelectedIndex = 0;
            comboBox_jornada.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            //llena una lista de los campos para verificar si estan vacios
            List<String> campos = new List<string>();            
            campos.Add(textBox_institucionEducativa.Text);
            campos.Add(textBox_direccionIE.Text);
            campos.Add(textBox_telefonoIE.Text);
            campos.Add(textBox_añoEnCurso.Text);

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

        private void limpiarCampos()
        {
            textBox_institucionEducativa.Text = "";
            textBox_direccionIE.Text = "";
            textBox_telefonoIE.Text = "";
            textBox_añoEnCurso.Text = "";
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void textBox_telefonoIE_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposNumericos(e);
        }

        private void textBox_añoEnCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposTexto(e);
        }
        public void ponerEnMayus()
        {            
            textBox_institucionEducativa.CharacterCasing = CharacterCasing.Upper;
            textBox_direccionIE.CharacterCasing = CharacterCasing.Upper;
            textBox_añoEnCurso.CharacterCasing = CharacterCasing.Upper;
            textBox_observaciones.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
