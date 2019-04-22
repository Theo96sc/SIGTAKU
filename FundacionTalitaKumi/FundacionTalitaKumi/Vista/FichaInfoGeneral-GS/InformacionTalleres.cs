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
   
    public partial class InformacionTalleres : Form
    {
        Validar validar = new Validar();
        public InformacionTalleres()
        {
            InitializeComponent();
            comboBox_certificado.SelectedIndex = 0;
            comboBox_certificado.DropDownStyle = ComboBoxStyle.DropDownList;
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
            campos.Add(textBox_nombre.Text);
            campos.Add(textBox_nombresPersona.Text);
            campos.Add(textBox1_apellidosPersona.Text);

            if (validar.camposVacios(campos) != 0)
            {
                MessageBox.Show("Campos Obligatorios(*) Vacíos");
            }
            else
            {
                if(dateTimePicker_fechaFin.Value.Date > dateTimePicker_fechaInicio.Value.Date)
                {
                    //guardar en la bd
                    MessageBox.Show("Registro guardado con éxito");
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("La fecha de finalización del curso o taller debe ser mayor a la fecha de inicio");
                }
                
            }
        }

        private void limpiarCampos()
        {
            textBox_nombre.Text = "";
            textBox_nombresPersona.Text = "";
            textBox1_apellidosPersona.Text = "";
            dateTimePicker_fechaInicio.Value = DateTime.Now;
            dateTimePicker_fechaFin.Value = DateTime.Now;
            comboBox_certificado.SelectedIndex = 0;
        }

        public void ponerEnMayus()
        {
            textBox_nombre.CharacterCasing = CharacterCasing.Upper;
            textBox_nombresPersona.CharacterCasing = CharacterCasing.Upper;
            textBox1_apellidosPersona.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox_nombre_KeyPress(object sender, KeyPressEventArgs e)
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
