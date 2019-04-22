using FundacionTalitaKumi.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundacionTalitaKumi.Vista
{
    public partial class ListarBeneficiarias : Form
    {
        Validar validar = new Validar();

        public ListarBeneficiarias()
        {
            InitializeComponent();
            this.TopLevel = false;
            comboBox_buscarPor.SelectedIndex = 0;
            comboBox_buscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button_listar_Click_1(object sender, EventArgs e)
        {
            BeneficiariaBD bbd = new BeneficiariaBD();
            bbd.listarBeneficiarias(dataGridView_llenarBeneficiarias, comboBox_buscarPor.SelectedIndex, textBox_datoConsulta.Text);
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_datoConsulta.Text = "";
            dataGridView_llenarBeneficiarias.DataSource = null;
            dataGridView_llenarBeneficiarias.Refresh();
        }

        private void comboBox_buscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_buscarPor.SelectedIndex == 0)
            {
                textBox_datoConsulta.Hide();
            }
            else
            {
                textBox_datoConsulta.Show();
            }
            textBox_datoConsulta.Text = "";
        }

        private void button_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_datoConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox_buscarPor.SelectedIndex == 3)
            {
                validar.validarCamposNumericos(e);
            }

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                button_listar_Click_1(null, null);
            }
        }
    }
}
