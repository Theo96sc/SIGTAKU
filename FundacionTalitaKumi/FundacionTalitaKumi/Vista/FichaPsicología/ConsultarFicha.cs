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
    public partial class ConsultarFicha : Form
    {
        ResumenClinicoBD rcbd = new ResumenClinicoBD();
        public ConsultarFicha(FundacionTalitaKumi.Modelo.Beneficiaria beneficiaria)
        {
            InitializeComponent();
            this.TopLevel = false;
            rcbd.consultarResumenClinico(dataGridView_datos, beneficiaria.CodBeneficiaria);
        }

        private void button_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
