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
    public partial class Responsables : Form
    {

        public Responsables()
        {
            InitializeComponent();
            this.TopLevel = false;
        }
        FundacionTalitaKumi.Modelo.Personal personal = new Modelo.Personal();
        PersonalBD pbd = new PersonalBD();

        private void cargarALista(FundacionTalitaKumi.Modelo.Personal personal)
        {
            ListViewItem lista = new ListViewItem(personal.IdentificacionPersonal);
            lista.SubItems.Add(personal.Nombres + " " + personal.Apellidos);
            lista.SubItems.Add(personal.Tipo);
            listView1.Items.Add(lista);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            personal = pbd.retornarObjetoPersonal(textBox_id.Text);
            Program.IdPersonal = textBox_id.Text;
            cargarALista(personal);
        }        

    }
}
