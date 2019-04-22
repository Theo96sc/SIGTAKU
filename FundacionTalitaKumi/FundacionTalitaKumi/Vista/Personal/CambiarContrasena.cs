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

namespace FundacionTalitaKumi.Vista.Personal
{
    public partial class CambiarContrasena : Form
    {
        String identificacion;
        public CambiarContrasena(String identificacion, String tipo)
        {
            InitializeComponent();
            this.identificacion = identificacion;
            label3.Hide();
            if(tipo != "AU")
            {
                textBox_identificacion.ReadOnly = true;
                textBox_identificacion.Text = identificacion;
            }
            else
            {
                label3.Show();
            }
            
        }

        private void button_verConstrasena_MouseDown(object sender, MouseEventArgs e)
        {
            textBox_contrasena.PasswordChar = '\0';
            textBox_confirmarContrasena.PasswordChar = '\0';
        }

        private void button_verConstrasena_MouseUp(object sender, MouseEventArgs e)
        {
            textBox_contrasena.PasswordChar = '*';
            textBox_confirmarContrasena.PasswordChar = '*';
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            Validar validar = new Validar();
            PersonalBD pbd = new PersonalBD();
            if (validar.validarContrasena(textBox_contrasena.Text))
            {
                if(textBox_contrasena.Text == textBox_confirmarContrasena.Text)
                {
                    try
                    {
                        identificacion = textBox_identificacion.Text;
                        pbd.actualizarContrasena(identificacion, validar.obtenerMD5(textBox_contrasena.Text));
                        MessageBox.Show("Contraseña actualizada con éxito");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo actualizar la contraseña");
                    }
                }
                else
                {
                    MessageBox.Show("Las Contraseñas ingresadas no coinciden");
                }              

            }
            else
            {
                MessageBox.Show("La contraseña debe como mínimo: 8 caracteres, 1 Mayúscula, 1 Minúscula y 1 Número");
            }
        }
    }
}
