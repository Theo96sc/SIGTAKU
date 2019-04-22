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

namespace FundacionTalitaKumi.Vista.Beneficiaria
{
    public partial class DatosVivienda_Beneficiaria : Form
    {
        FundacionTalitaKumi.Modelo.Personal personal = new Modelo.Personal();
        public DatosVivienda_Beneficiaria(String tipo, FundacionTalitaKumi.Modelo.Personal personal)
        {
            InitializeComponent();
            this.personal = personal;
            this.TopLevel = false;
            button_actualizar.Visible = false;
            if (tipo == "C")
            {
                datosConsulta();
            }

            //solo para la consulta de datos
            if (personal.Tipo == "ADMINISTRADOR/A")//administradora
            {
                panel_botones.Hide();
            }else if (personal.Tipo == "GESTOR/A SOCIAL")
            {
                panel_botones.Show();
            }
        }

        Validar validar = new Validar();

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_tipoBarrio.Text = "";
            textBox_equipamientoYServicios.Text = "";
            textBox_tejidoSocial.Text = "";
        }

        private void button_regresar_Click(object sender, EventArgs e)
        {
            button_guardar.Visible = false;
            button_limpiar.Visible = false;
            button_cancelar.Visible = false;
            button_actualizar.Visible = true;
            datosConsulta();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            List<String> campos = new List<String>();
            campos.Add(textBox_tipoBarrio.Text);
            campos.Add(textBox_equipamientoYServicios.Text);
            campos.Add(textBox_tejidoSocial.Text);

            if (validar.camposVacios(campos) != 0)
            {
                MessageBox.Show("Campos Obligatorios(*) Vacíos");               
            }
            else
            {
                DialogResult dr = MessageBox.Show("¿Está seguro que desea guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //guardar en la BD
                    MessageBox.Show("Registro guardado con éxito");
                }
            }
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            button_actualizar.Visible = false;
            button_guardar.Visible = true;
            button_limpiar.Visible = true;
            button_cancelar.Visible = true;

            comboBox_tipoVivienda.Enabled = true;
            comboBox_condicionesGeneralesVivienda.Enabled = true;
            comboBox_material.Enabled = true;
            comboBox_posesion.Enabled = true;
            comboBox_agua.Enabled = true;
            comboBox_luz.Enabled = true;
            comboBox_telefono.Enabled = true;
            comboBox_sshh.Enabled = true;
            comboBox_internet.Enabled = true;
            comboBox_recoleccionBasura.Enabled = true;
            comboBox_sala.Enabled = true;
            comboBox_comedor.Enabled = true;
            comboBox_cocina.Enabled = true;
            comboBox_bano.Enabled = true;
            comboBox_pozoSeptico.Enabled = true;
            numericUpDown_numDormitorios.ReadOnly = false;
            comboBox_estadoTecho.Enabled = true;
            comboBox_estadoPiso.Enabled = true;
            comboBox_estadoParedes.Enabled = true;
            comboBox_estadosPuertas.Enabled = true;
            comboBox_estadoVentanas.Enabled = true;
            textBox_tipoBarrio.ReadOnly = false;
            textBox_equipamientoYServicios.ReadOnly = false;
            textBox_tejidoSocial.ReadOnly = false;
        }

        private void datosConsulta()
        {
            button_actualizar.Visible = true;
            button_guardar.Visible = false;
            button_limpiar.Visible = false;
            button_cancelar.Visible = false;

            comboBox_tipoVivienda.Enabled = false;
            comboBox_condicionesGeneralesVivienda.Enabled = false;
            comboBox_material.Enabled = false;
            comboBox_posesion.Enabled = false;
            comboBox_agua.Enabled = false;
            comboBox_luz.Enabled = false;
            comboBox_telefono.Enabled = false;
            comboBox_sshh.Enabled = false;
            comboBox_internet.Enabled = false;
            comboBox_recoleccionBasura.Enabled = false;
            comboBox_sala.Enabled = false;
            comboBox_comedor.Enabled = false;
            comboBox_cocina.Enabled = false;
            comboBox_bano.Enabled = false;
            comboBox_pozoSeptico.Enabled = false;
            numericUpDown_numDormitorios.ReadOnly = true;
            comboBox_estadoTecho.Enabled = false;
            comboBox_estadoPiso.Enabled = false;
            comboBox_estadoParedes.Enabled = false;
            comboBox_estadosPuertas.Enabled = false;
            comboBox_estadoVentanas.Enabled = false;
            textBox_tipoBarrio.ReadOnly = true;
            textBox_equipamientoYServicios.ReadOnly = true;
            textBox_tejidoSocial.ReadOnly = true;
        }
    }
}
