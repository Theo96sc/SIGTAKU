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
    public partial class VacacionesPersonal : Form
    {
        FundacionTalitaKumi.Modelo.Personal personal = new FundacionTalitaKumi.Modelo.Personal();
        VacacionBD vbd = new VacacionBD();
        Boolean vieneDeActualizar;
        FundacionTalitaKumi.Modelo.Vacacion vacacionInicial = new Modelo.Vacacion();
        public VacacionesPersonal(FundacionTalitaKumi.Modelo.Vacacion vacacionInicial, FundacionTalitaKumi.Modelo.Personal personal, Boolean vieneDeActualizar)
        {
            InitializeComponent();
            this.personal = personal;
            this.vacacionInicial = vacacionInicial;
            this.vieneDeActualizar = vieneDeActualizar;
            
            if (vieneDeActualizar == false)
            {
                this.TopLevel = false;
                //fechas
                dateTimePicker_fechaInicio.MinDate = DateTime.Now;
                dateTimePicker_fechaFin.MinDate = DateTime.Now;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                dateTimePicker_fechaInicio.Value = vacacionInicial.FechaInicioVacaciones;
                dateTimePicker_fechaFin.Value = vacacionInicial.FechaFinVacaciones;
            }            
            comboBox_cedula.Enabled = false;
            comboBox_tipo.Enabled = false;
            textBox_nombres.ReadOnly = true;
            textBox_apellidos.ReadOnly = true;
            textBox_identificacion.ReadOnly = true;
            
            setearDatos();
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void button_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            FundacionTalitaKumi.Modelo.Vacacion vacacion = new FundacionTalitaKumi.Modelo.Vacacion(textBox_identificacion.Text, dateTimePicker_fechaInicio.Value, dateTimePicker_fechaFin.Value);

            if (dateTimePicker_fechaFin.Value > dateTimePicker_fechaInicio.Value)
            {
                DialogResult dr = MessageBox.Show("¿Está seguro que desea guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (vieneDeActualizar)
                    {
                        try
                        {
                            vbd.eliminarVacacion(vacacionInicial);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al actualizar");
                        }
                    }
                    //guardar en la BD
                    if (vbd.verificarFechaParaVacacion(vacacion) == 0)
                    {
                        if (vbd.insertarVacacion(vacacion) == 1)
                        {
                            if (vieneDeActualizar)
                            {
                                MessageBox.Show("Registro de Vacaciones actualizado con éxito");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Registro de Vacaciones guardado con éxito");
                                limpiarCampos();
                            }                            
                        }
                    }                                                      
                }
            }
            else
            {
                MessageBox.Show("La fecha final debe ser mayor que la fecha de inicio");
            }
            
        }

        private void limpiarCampos()
        {
            dateTimePicker_fechaInicio.Text = "";
            dateTimePicker_fechaFin.Text = "";
        }

        private void setearDatos()
        {
            textBox_identificacion.Text = personal.IdentificacionPersonal;
            comboBox_tipo.Text = personal.Tipo;
            textBox_nombres.Text = personal.Nombres;
            textBox_apellidos.Text = personal.Apellidos;
        }

        private void dateTimePicker_fechaFin_ValueChanged(object sender, EventArgs e)
        {
            monthCalendar_calendario.AddBoldedDate(dateTimePicker_fechaInicio.Value);
            monthCalendar_calendario.AddBoldedDate(dateTimePicker_fechaFin.Value);
        }
    }
}
