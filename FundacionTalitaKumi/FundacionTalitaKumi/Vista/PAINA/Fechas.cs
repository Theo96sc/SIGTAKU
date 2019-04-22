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
    public partial class Fechas : Form
    {
        public Fechas()
        {
            InitializeComponent();
            this.TopLevel = false;
            dateTimePicker_fechaElaboracion.Enabled = false;
            dateTimePicker_fechaElaboracion.Value = DateTime.Now;
            dateTimePicker_fechaProxEval.MinDate = DateTime.Now;
        }

        public List<Object> retornarValores()
        {
            List<Object> lista = new List<object>();
            lista.Add(dateTimePicker_fechaElaboracion.Text);
            lista.Add(dateTimePicker_fechaProxEval.Text);
            lista.Add(textBox_prof.Text);
            return lista;
        }
    }
}
