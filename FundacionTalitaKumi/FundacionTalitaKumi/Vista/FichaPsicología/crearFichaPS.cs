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

namespace FundacionTalitaKumi.Vista.FichaPsicología
{
    public partial class crearFichaPS : Form
    {
        BeneficiariaBD bbd = new BeneficiariaBD();
        FundacionTalitaKumi.Modelo.Beneficiaria beneficiaria = new Modelo.Beneficiaria();
        String tipo;
        public crearFichaPS(String tipo)
        {
            this.tipo = tipo;
            InitializeComponent();
            this.TopLevel = false;
            comboBox_buscarPor.SelectedIndex = 0;
            comboBox_buscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox_buscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_datoConsulta.Text = "";
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            bbd.consultarBeneficiaria(dataGridView_Beneficiaria, comboBox_buscarPor.SelectedIndex, textBox_datoConsulta.Text);
        }

        private void dataGridView_Beneficiaria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            beneficiaria = bbd.retornarObjetoBeneficiariaPrincipal(dataGridView_Beneficiaria.CurrentRow.Cells[0].Value.ToString());
            panel_general.Controls.Clear();
            if (tipo == "R")
            {
                DatosFichas_PS dfp = new DatosFichas_PS(beneficiaria);
                dfp.Dock = DockStyle.Fill;
                panel_general.Controls.Add(dfp);
                dfp.Show();
            }else if(tipo == "C")
            {
                ConsultarFicha cf = new ConsultarFicha(beneficiaria);
                cf.Dock = DockStyle.Fill;
                panel_general.Controls.Add(cf);
                cf.Show();
            }
           
        }
    }
}
