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
    public partial class InformacionPersonal : Form
    {
        FundacionTalitaKumi.Modelo.Beneficiaria beneficiara = new Modelo.Beneficiaria();
        public InformacionPersonal(FundacionTalitaKumi.Modelo.Beneficiaria beneficiara)
        {
            InitializeComponent();
            this.beneficiara = beneficiara;
            this.TopLevel = false;
        }

        private void button_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
