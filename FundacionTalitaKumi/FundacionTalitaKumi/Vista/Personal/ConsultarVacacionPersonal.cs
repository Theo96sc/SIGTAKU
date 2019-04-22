using FundacionTalitaKumi.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundacionTalitaKumi.Vista.Personal
{
    public partial class ConsultarVacacionPersonal : Form
    {
        Validar validar = new Validar();
        FundacionTalitaKumi.Modelo.Personal personal = new Modelo.Personal();
        String identificacion = "";
        VacacionBD vbd = new VacacionBD();
        PersonalBD pbd = new PersonalBD();

        public ConsultarVacacionPersonal(FundacionTalitaKumi.Modelo.Personal personal)
        {
            InitializeComponent();
            this.personal = personal;
            this.TopLevel = false;
            textBox_datoConsulta.CharacterCasing = CharacterCasing.Upper;
            comboBox_buscarPor.SelectedIndex = 0;
            comboBox_buscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_numRegistros.SelectedIndex = 0;
            comboBox_numRegistros.DropDownStyle = ComboBoxStyle.DropDownList;
            //para que salga solo el un boton
            tableLayoutPanel5.Visible = false;
            dataGridView_vacaciones.Visible = false;
            panel_botones.BackColor = Color.FromArgb(225, 215, 223);
            button_limpiar.Visible = false;
            button_actualizar.Visible = false;
            button_regresar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            button_actualizar.Visible = false;
        }

        private void comboBox_buscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_datoConsulta.Text = "";
        }

        private void dataGridView_Personal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            identificacion = dataGridView_Personal.CurrentRow.Cells[0].Value.ToString();
            tableLayoutPanel5.Visible = true;
            dataGridView_vacaciones.DataSource = null;
            dataGridView_vacaciones.Refresh();
            dataGridView_vacaciones.Visible = true;
            dataGridView_Personal.DataSource = null;
            dataGridView_Personal.Refresh();
            panel_botones.BackColor = Color.FromArgb(211, 197, 208);
            button_regresar.Anchor = AnchorStyles.Bottom | AnchorStyles.Top;
            button_limpiar.Visible = true;
            
           
        }

        private void button_buscar2_Click(object sender, EventArgs e)
        {
            vbd.consultarVacaciones(dataGridView_vacaciones, comboBox_numRegistros.SelectedIndex, identificacion);
            panel_botones.Visible = true;
        }

        private void dataGridView_vacaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_actualizar.Visible = true;
        }

        
        private void button_actualizar_Click(object sender, EventArgs e)
        {            
            DateTime fechaActual = DateTime.Now.Date;
            DateTime fechaInicio = new DateTime();
            DateTime fechaFin = new DateTime();
            try
            {
                int indiceFilaSeleccionada = dataGridView_vacaciones.CurrentRow.Index;
                fechaInicio = Convert.ToDateTime(dataGridView_vacaciones.Rows[indiceFilaSeleccionada].Cells[3].Value);
                fechaFin = Convert.ToDateTime(dataGridView_vacaciones.Rows[indiceFilaSeleccionada].Cells[4].Value);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error, ha seleccionado una fila no existente");
            }            

            if (fechaActual < fechaInicio)
            {
                FundacionTalitaKumi.Modelo.Vacacion vacacion = new Modelo.Vacacion(identificacion, fechaInicio, fechaFin);
                VacacionesPersonal vp = new VacacionesPersonal(vacacion,pbd.retornarObjetoPersonal(identificacion), true);
                vp.Show();
                
            }
            else
            {
                MessageBox.Show("No puede modificar las fechas. Ya ha sobrepasado la fecha de Inicio");
            }
        }

        private void button_regresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_limpiar_Click_1(object sender, EventArgs e)
        {
            comboBox_numRegistros.SelectedIndex = 0;
            textBox_datoConsulta.Text = "";
            dataGridView_Personal.DataSource = null;
            dataGridView_Personal.Refresh();
            dataGridView_vacaciones.DataSource = null;
            dataGridView_vacaciones.Refresh();
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
    }
}
