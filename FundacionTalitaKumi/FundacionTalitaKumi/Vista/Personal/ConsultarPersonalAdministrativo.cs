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
    public partial class ConsultarPersonalAdministrativo : Form
    {
        Validar validar = new Validar();
        FundacionTalitaKumi.Modelo.Personal personal = new Modelo.Personal();
        PersonalBD pbd = new PersonalBD();

        public ConsultarPersonalAdministrativo(FundacionTalitaKumi.Modelo.Personal personal)
        {
            InitializeComponent();
            this.personal = personal;
            this.TopLevel = false;
            comboBox_buscarPor.SelectedIndex = 0;
            comboBox_buscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_datoConsulta.CharacterCasing = CharacterCasing.Upper;

        }

        private void button_buscar_Click(object sender, EventArgs e)
        {            
            if(comboBox_buscarPor.SelectedIndex == 0)
            {
                pbd.consultarPersonal(dataGridView_Personal, 0, textBox_datoConsulta.Text);
            }
            else
            {
                pbd.consultarPersonal(dataGridView_Personal, 1, textBox_datoConsulta.Text);
            }
            
        }

        private void panel_datos_ControlRemoved(object sender, ControlEventArgs e)
        {
            textBox_datoConsulta.Text = "";
            dataGridView_Personal.DataSource = null;
            dataGridView_Personal.Refresh();
            tableLayoutPanel1.Controls.Add(button_regresar, 1, 0);
        }

        private void comboBox_buscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_datoConsulta.Text = "";
        }

        private void dataGridView_Personal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //panel de datos
            String idPersonalConsulta = dataGridView_Personal.CurrentRow.Cells[0].Value.ToString();
            dataGridView_Personal.DataSource = null;
            dataGridView_Personal.Refresh();
            panel_datos.Controls.Clear();
            DatosPersonalAdministrativo dpa = new DatosPersonalAdministrativo("C", pbd.retornarObjetoPersonal(idPersonalConsulta));
            dpa.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(dpa);
            dpa.Show();
            //setear valores desde BD
        }

        private void button_regresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_datoConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox_buscarPor.SelectedIndex != 0)
            {
                validar.validarCamposTexto(e);
            }

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                button_buscar_Click(null, null);
            }
        }

        private void panel_datos_ControlAdded(object sender, ControlEventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(button_regresar);
        }
    }
}
