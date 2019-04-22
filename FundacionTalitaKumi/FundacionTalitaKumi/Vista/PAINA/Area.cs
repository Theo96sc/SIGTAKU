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
    public partial class Area : Form
    {
        public Area(String codBeneficiaria)
        {
            InitializeComponent();
            this.TopLevel = false;
            AreaBD areabd = new AreaBD();
            areabd.consultarArea(dataGridView_datos,int.Parse(codBeneficiaria));
        }
    }
}
