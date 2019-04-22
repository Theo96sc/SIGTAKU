using FundacionTalitaKumi.Controlador;
using FundacionTalitaKumi.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundacionTalitaKumi
{
    public partial class InicioSesion : Form
    {
        PersonalBD pbd = new PersonalBD();
        Validar validar = new Validar();

        public InicioSesion()
        {
            InitializeComponent();
            //panel titulo
            Titulo t = new Titulo();
            t.Dock = DockStyle.Fill;           
            panel_titulo.Controls.Add(t);
            t.Show();
            textBox_usuario.ForeColor = Color.DimGray;
            textBox_contrasena.PasswordChar = '\0';
            textBox_contrasena.Text = "Ingrese su Contraseña";
            textBox_contrasena.ForeColor = Color.DimGray;
        }
       

        private void InicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            //verifica BD
            if (pbd.iniciarSesion(textBox_usuario.Text, validar.obtenerMD5(textBox_contrasena.Text)))
            {
                VentanaPrincipal vp = new VentanaPrincipal(pbd.retornarObjetoPersonal(textBox_usuario.Text));
                vp.Visible = true;
                Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
                textBox_usuario.Text = "Ingrese su Identificación";
                textBox_usuario.ForeColor = Color.DimGray;
                textBox_contrasena.Text = "Ingrese su Contraseña";
                textBox_contrasena.PasswordChar = '\0';
                textBox_contrasena.ForeColor = Color.DimGray;
            }
            
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_contrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                buttonIngresar_Click(null, null);
            }
        }

        private void textBox_usuario_Enter(object sender, EventArgs e)
        {
            if(textBox_usuario.Text == "Ingrese su Identificación")
            {
                textBox_usuario.Text = "";
                textBox_usuario.ForeColor = Color.Black;
            }            
        }

        private void textBox_usuario_Leave(object sender, EventArgs e)
        {
            if (textBox_usuario.Text == "")
            {
                textBox_usuario.Text = "Ingrese su Identificación";
                textBox_usuario.ForeColor = Color.LightGray;
            }
        }


        private void button_verConstrasena_MouseDown_1(object sender, MouseEventArgs e)
        {
            textBox_contrasena.PasswordChar = '\0';
        }

        private void button_verConstrasena_MouseUp_1(object sender, MouseEventArgs e)
        {
            textBox_contrasena.PasswordChar = '*';
        }

        private void textBox_contrasena_Enter(object sender, EventArgs e)
        {
            if (textBox_contrasena.Text == "Ingrese su Contraseña")
            {
                textBox_contrasena.Text = "";
                textBox_contrasena.PasswordChar = '*';
                textBox_contrasena.ForeColor = Color.Black;
            }
        }

        private void textBox_contrasena_Leave(object sender, EventArgs e)
        {
            if (textBox_contrasena.Text == "")
            {
                textBox_contrasena.Text = "Ingrese su Contraseña";
                textBox_contrasena.PasswordChar = '\0';
                textBox_contrasena.ForeColor = Color.Black;
            }
        }
    }
}
