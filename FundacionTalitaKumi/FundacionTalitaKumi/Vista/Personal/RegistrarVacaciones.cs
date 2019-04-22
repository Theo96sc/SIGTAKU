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
    public partial class RegistrarVacaciones : Form
    {
        FundacionTalitaKumi.Modelo.Personal personal = new FundacionTalitaKumi.Modelo.Personal();
        Validar validar = new Validar();
        PersonalBD pbd = new PersonalBD();

        public RegistrarVacaciones(FundacionTalitaKumi.Modelo.Personal personal)
        {
            InitializeComponent();
            this.personal = personal;
            this.TopLevel = false;
            textBox_datoConsulta.CharacterCasing = CharacterCasing.Upper;
            comboBox_buscarPor.SelectedIndex = 0;
            comboBox_buscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            if (comboBox_buscarPor.SelectedIndex == 0)
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

        private void button_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_Personal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String idPersonalConsulta = dataGridView_Personal.CurrentRow.Cells[0].Value.ToString();
            dataGridView_Personal.DataSource = null;
            dataGridView_Personal.Refresh();
            panel_datos.Controls.Clear();
            VacacionesPersonal vp = new VacacionesPersonal(null, pbd.retornarObjetoPersonal(idPersonalConsulta), false);
            vp.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(vp);
            vp.Show();
            //setear datos personales
        }

        private void comboBox_buscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_datoConsulta.Text = "";
        }

        private void textBox_datoConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox_buscarPor.SelectedIndex != 0)
            {
                validar.validarCamposTexto(e);
            }
        }

        private void panel_datos_ControlAdded(object sender, ControlEventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(button_regresar);
        }
    }
}
