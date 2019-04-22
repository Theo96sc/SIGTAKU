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
    public partial class NuevaArea : Form
    {
        String codigoBeneficiaria = "";
        public NuevaArea(String codigoBeneficiaria)
        {
            this.codigoBeneficiaria = codigoBeneficiaria;
            InitializeComponent();
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }
        AreaBD areabd = new AreaBD();

        private void limpiarDatos()
        {
            textBox_diagnostico.Text = "";
            textBox_objetivoArea.Text = "";
            textBox_solicita.Text = "";
            textBox_responsables.Text = "";
            textBox_tiempo.Text = "";
            textBox_evaluacion.Text = "";
            textBox_observaciones.Text = "";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            FundacionTalitaKumi.Modelo.Area area = new Modelo.Area(int.Parse(codigoBeneficiaria), textBox_diagnostico.Text, textBox_objetivoArea.Text, textBox_solicita.Text, textBox_responsables.Text, textBox_tiempo.Text, textBox_evaluacion.Text, textBox_observaciones.Text, textBox_nombre.Text);
            
            DialogResult dr = MessageBox.Show("¿Está seguro que desea guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {                
                try
                {
                    areabd.insertarArea(area);
                    MessageBox.Show("Los datos han sido guardados con éxito");
                    limpiarDatos();
                    buttonCancelar_Click(null, null);
                }
                catch(Exception ex){
                    MessageBox.Show("Error al guardar los datos");
                }
                
            }

        }
    }
}
