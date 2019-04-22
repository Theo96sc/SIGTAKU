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
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
            comboBox_cedula.SelectedIndex = 0;
            comboBox_cedula.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            Validar validar = new Validar();
            PersonalBD pbd = new PersonalBD();           
            if (validar.validarContrasena(textBox_contrasena.Text))
            {
                if (textBox_contrasena.Text == textBox_confirmarContrasena.Text)
                {
                    try
                    {
                        if (comboBox_cedula.SelectedIndex == 0)
                        {
                            if (validar.verificarCedula(textBox_usuario.Text))
                            {
                                pbd.crearUsuario(textBox_usuario.Text, validar.obtenerMD5(textBox_contrasena.Text));
                                MessageBox.Show("Usuario creado con éxito");
                                this.Close();
                            }
                        }
                        else
                        {
                            pbd.crearUsuario(textBox_usuario.Text, validar.obtenerMD5(textBox_contrasena.Text));
                            MessageBox.Show("Usuario creado con éxito");
                            this.Close();
                        }
                        
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo crear al usuario");
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

        private void comboBox_cedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_usuario.Text = "";
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
    }
}
