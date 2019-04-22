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
    public partial class Objetivos : Form
    {
        public Objetivos()
        {
            InitializeComponent();
            this.TopLevel = false;

        }

        public List<Object> retornarValores()
        {
            List<Object> lista = new List<object>();
            lista.Add(textBox_objetivoGeneral.Text);
            lista.Add(textBox_desarrolloPersonal.Text);
            lista.Add(textBox_desarrolloSocial.Text);
            return lista;
        }

    }
}
