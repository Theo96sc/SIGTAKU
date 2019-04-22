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

namespace FundacionTalitaKumi.Vista
{
    public partial class ListarPersonalAdministrativo : Form
    {
        public ListarPersonalAdministrativo()
        {
            InitializeComponent();
            this.TopLevel = false;
            textBox_datoConsulta.CharacterCasing = CharacterCasing.Upper;
            comboBox_buscarPor.SelectedIndex = 0;
            comboBox_buscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_datoConsulta.Visible = false;
        }

        PersonalBD pbd = new PersonalBD();
        Validar validar = new Validar();

        private void button_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_listar_Click(object sender, EventArgs e)
        {
            pbd.listarPersonal(dataGridView_llenarPersonal, comboBox_buscarPor.SelectedIndex, textBox_datoConsulta.Text);
        }

        private void comboBox_buscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_buscarPor.SelectedIndex == 0)
            {
                textBox_datoConsulta.Hide();
            }
            else
            {
                textBox_datoConsulta.Show();
            }
            textBox_datoConsulta.Text = "";            
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_datoConsulta.Text = "";
            dataGridView_llenarPersonal.DataSource = null;
            dataGridView_llenarPersonal.Refresh();
        }

        private void textBox_datoConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarCamposNumericos(e);
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                button_listar_Click(null, null);
            }
        }
        
    }
}
