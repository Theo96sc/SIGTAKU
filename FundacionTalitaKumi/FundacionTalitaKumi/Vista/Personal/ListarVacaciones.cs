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

namespace FundacionTalitaKumi.Vista.Personal
{
    public partial class ListarVacaciones : Form
    {
        Validar validar = new Validar();
        public ListarVacaciones()
        {
            InitializeComponent();
            this.TopLevel = false;
            comboBox_buscarPor.SelectedIndex = 0;
            comboBox_buscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_datoConsulta.Visible = false;
            textBox_datoConsulta.Minimum = 1;
            textBox_datoConsulta.Maximum = 12;
        }

        private void button_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_buscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_buscarPor.SelectedIndex != 0)
            {
                textBox_datoConsulta.Visible = true;
                textBox_datoConsulta.Text = "";
                dataGridView_llenarVacaciones.DataSource = null;
                dataGridView_llenarVacaciones.Refresh();
            }
            else
            {
                textBox_datoConsulta.Visible = false;
            }
        }

        private void button_listar_Click(object sender, EventArgs e)
        {
            VacacionBD vbd = new VacacionBD();
            vbd.listarVacaciones(dataGridView_llenarVacaciones, comboBox_buscarPor.SelectedIndex, textBox_datoConsulta.Text);

        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_datoConsulta.Text = "";
            dataGridView_llenarVacaciones.DataSource = null;
            dataGridView_llenarVacaciones.Refresh();
        }

        private void textBox_datoConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposNumericos(e);
        }

        private void textBox_datoConsulta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                button_listar_Click(null, null);
            }
        }
    }
}
