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
    public partial class CausasIngreso : Form
    {
        Validar validar = new Validar();
        public CausasIngreso()
        {
            InitializeComponent();
            this.TopLevel = false;
            textBox_motivo.ReadOnly = true;
            comboBox_ordenJudicial.Enabled = true;
            comboBox_ordenJudicial.SelectedIndex = 0;
            comboBox_ordenJudicial.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_motivo.CharacterCasing = CharacterCasing.Upper;
            buttonCancelar.Visible = false;
            button_guardar.Visible = false;
            button_limpiar.Visible = false;
        }


        private void button_actualizar_Click(object sender, EventArgs e)
        {
            textBox_motivo.ReadOnly = false;
            buttonCancelar.Visible = true;
            button_guardar.Visible = true;
            button_limpiar.Visible = true;
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            button_actualizar.Visible = true;
            buttonCancelar.Visible = false;
            button_guardar.Visible = false;
            button_limpiar.Visible = false;
            textBox_motivo.ReadOnly = true;
            comboBox_ordenJudicial.Enabled = false;
        }

        private void button_limpiar_Click_1(object sender, EventArgs e)
        {
            textBox_motivo.Text = "";
        }

        private void button_guardar_Click_1(object sender, EventArgs e)
        {

            //llena una lista de los campos para verificar si estan vacios
            List<String> campos = new List<string>();
            campos.Add(textBox_motivo.Text);

            if (validar.camposVacios(campos) != 0)
            {
                MessageBox.Show("Campos Obligatorios(*) Vacíos");
            }
            else
            {
                //guardar en la bd
                MessageBox.Show("Registro guardado con éxito");
                textBox_motivo.Text = "";
            }
        }
    }
}
