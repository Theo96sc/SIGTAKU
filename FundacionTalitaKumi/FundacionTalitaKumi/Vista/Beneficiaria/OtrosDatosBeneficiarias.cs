using FundacionTalitaKumi.Controlador;
using FundacionTalitaKumi.Vista.FichaInfoGeneral_GS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundacionTalitaKumi.Vista.Beneficiaria
{
    public partial class OtrosDatosBeneficiarias : Form
    {
        String tipo;
        public OtrosDatosBeneficiarias(String codBeneficiaria, String tipo)
        {
            InitializeComponent();
            this.TopLevel = false;
            BeneficiariaBD bbd = new BeneficiariaBD();
            int codBen = int.Parse(codBeneficiaria);
            if(tipo == "F")//datos familiares
            {
                bbd.consultarDatosFamiliares(dataGridView_datos, codBen);
            }else if(tipo == "E")//datos educativos
            {
                bbd.consultarDatosEducativos(dataGridView_datos, codBen);
            }else if(tipo == "L")//datos laborales
            {
                bbd.consultarDatosLaborales(dataGridView_datos, codBen);
            }else if(tipo == "HC")//datos historial cronologico
            {
                bbd.consultarHistorialCronologico(dataGridView_datos, codBen);
            }else if(tipo == "T")//datos para talleres
            {
                bbd.consultarTalleres(dataGridView_datos, codBen);
            }
            
        }
    }
}
