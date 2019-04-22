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
    public partial class DatosFichas_PS : Form
    {
        FundacionTalitaKumi.Modelo.Beneficiaria beneficiaria = new Modelo.Beneficiaria();
        public DatosFichas_PS(FundacionTalitaKumi.Modelo.Beneficiaria beneficiaria)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.beneficiaria = beneficiaria;
            dateTimePicker_fechaRealizacion.Enabled = false;
            dateTimePicker_proximaSesion.MinDate = DateTime.Now;
            button_generarPDF.Hide();
        }

      
        private void button_limpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void limpiarDatos()
        {
            dateTimePicker_fechaRealizacion.Text = "";
            textBox_resumen1.Text = "";
            textBox_resumen2.Text = "";
            textBox_intervecion.Text = "";
            textBox_indicaciones.Text = "";
            dateTimePicker_proximaSesion.Text = "";
        }

        private void button_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        private void button_generarPDF_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea generar el PDF?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("PDF generado con éxito");

            }
            limpiarDatos();
        }

        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            ResumenClinicoBD rcbd = new ResumenClinicoBD();
            FundacionTalitaKumi.Modelo.ResumenClinico rc = new Modelo.ResumenClinico(beneficiaria.CodBeneficiaria, dateTimePicker_fechaRealizacion.Value, textBox_resumen1.Text, textBox_resumen2.Text, textBox_intervecion.Text, textBox_indicaciones.Text, dateTimePicker_proximaSesion.Value);
            DialogResult dr = MessageBox.Show("¿Está seguro que desea guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    rcbd.insertarResumenClinico(rc);
                    MessageBox.Show("Los datos han sido guardados con éxito");
                    button_generarPDF.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos");
                }

            }
        }
    }
}
