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

namespace FundacionTalitaKumi.Vista.PAINA
{
    public partial class ConsultarFichaPAINA : Form
    {
        public ConsultarFichaPAINA()
        {
            InitializeComponent();
            this.TopLevel = false;
            comboBox_buscarPor.SelectedIndex = 0;
            comboBox_buscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        Validar validar = new Validar();
        BeneficiariaBD bbd = new BeneficiariaBD();
        InformePAINABD ipainabd = new InformePAINABD();

        private void comboBox_buscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_datoConsulta.Text = "";
        }

        private void textBox_datoConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox_buscarPor.SelectedIndex == 0)
            {
                validar.validarCamposNumericos(e);
            }
            else if (comboBox_buscarPor.SelectedIndex == 1)
            {
                validar.validarCamposTexto(e);
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                button_buscar_Click(null, null);
            }
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            bbd.consultarBeneficiaria(dataGridView_Beneficiaria, comboBox_buscarPor.SelectedIndex, textBox_datoConsulta.Text);
        }

        private void dataGridView_Beneficiaria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String codBeneficiaria = dataGridView_Beneficiaria.Rows[dataGridView_Beneficiaria.CurrentRow.Index].Cells[0].Value.ToString();
                ipainabd.consultarInformePAINA(dataGridView_datos, int.Parse(codBeneficiaria));
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha seleccionado una fial");
            }            
            
        }

        private void button_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
