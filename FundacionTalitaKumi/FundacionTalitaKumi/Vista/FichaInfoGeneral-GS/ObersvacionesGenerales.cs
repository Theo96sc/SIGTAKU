using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundacionTalitaKumi.Vista.FichaInfoGeneral_GS
{
    public partial class ObersvacionesGenerales : Form
    {
        public ObersvacionesGenerales()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha guardado con éxito");
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_observaciones.Text = "";
        }
    }
}
