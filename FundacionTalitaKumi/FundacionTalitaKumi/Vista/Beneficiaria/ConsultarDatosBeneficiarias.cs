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

namespace FundacionTalitaKumi.Vista.Beneficiaria
{
    public partial class ConsultarDatosBeneficiarias : Form
    {
        int i = 0; //para avanzar de un panel de información a otro. 
        int j = 0; //para retroceder de un panel de inforamacion a otro.
        BeneficiariaBD bbd = new BeneficiariaBD();
        Validar validar = new Validar();
        FundacionTalitaKumi.Modelo.Personal personal = new Modelo.Personal();
        FundacionTalitaKumi.Modelo.Beneficiaria beneficiaria = new Modelo.Beneficiaria();

        public ConsultarDatosBeneficiarias(FundacionTalitaKumi.Modelo.Personal personal)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.personal = personal;
            button_siguiente.Visible = false;
            comboBox_buscarPor.SelectedIndex = 0;
            comboBox_buscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
            tableLayoutPanel_siguiente.Hide();
            buttonAnterior.Visible = false;
            label_subtitulo.Visible = false;
        }

        
        private void comboBox_buscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_datoConsulta.Text = "";
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {            
            bbd.consultarBeneficiaria(dataGridView_Beneficiaria, comboBox_buscarPor.SelectedIndex, textBox_datoConsulta.Text);
            
        }

        private void dataGridView_Personal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String identificacion = dataGridView_Beneficiaria.CurrentRow.Cells[0].Value.ToString();
            beneficiaria = bbd.retornarObjetoBeneficiariaPrincipal(identificacion);
            //primer panel           
            agregarDatosPersonales();
            i++;
            j++;
        }


        private void button_regresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_siguiente_Click(object sender, EventArgs e)
        {
            buttonAnterior.Visible = true;
            if (i == 1)
            {
                agregarDatosFamiliares();
                i++;                
            }else if (i == 2)
            {
                agregarDatosEducativos();
                i++;
                j++;
            }
            else if (i == 3)
            {
                agregarDatosLaborales();
                i++;
                j++;
            }
            else if (i == 4)
            {
                agregarDatosVivienda();
                i++;
                j++;
            }
            else if (i == 5)
            {
                agregarDatosHistorialCronologico();
                i++;
                j++;
            }
            else if (i == 6)
            {
                agregarDatosTalleres();
                i++;
                button_siguiente.Visible = false;
                button_regresar.Show();
            }
        }
        
        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (j == 1)
            {
                buttonAnterior.Visible = false;
                agregarDatosPersonales();
                i--;
            }
            else if (j == 2)
            {
                agregarDatosFamiliares();
                i--;
                j--;
            }
            else if (j == 3)
            {
                agregarDatosEducativos();
                i--;
                j--;
            }
            else if (j == 4)
            {
                agregarDatosLaborales();
                i--;
                j--;
            }
            else if (j == 4)
            {
                agregarDatosVivienda();
                i--;
                j--;
            }
            else if (j == 5)
            {
                agregarDatosHistorialCronologico();
                i--;
                j--;
            }
        }

        private void agregarDatosPersonales()
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Datos Personales";
            DatosPersonalesBeneficiarias dpb = new DatosPersonalesBeneficiarias("C", personal, beneficiaria);
            button_regresar.Visible = false;
            tableLayoutPanel_siguiente.Show();
            button_siguiente.Visible = true;
            dpb.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(dpb);
            dpb.Show();
        }

        OtrosDatosBeneficiarias odb;

        private void agregarDatosFamiliares()
        {            
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Datos Familiares";
            String codBeneficiaria = "";
            try
            {
                codBeneficiaria = dataGridView_Beneficiaria.Rows[dataGridView_Beneficiaria.CurrentRow.Index].Cells[0].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha seleccionado una fila");
            }
            
            odb = new OtrosDatosBeneficiarias(codBeneficiaria, "F");
            odb.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(odb);
            odb.Show();
        }

        private void agregarDatosEducativos()
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Datos Educativos";
            String codBeneficiaria = dataGridView_Beneficiaria.Rows[dataGridView_Beneficiaria.CurrentRow.Index].Cells[0].Value.ToString();
            odb = new OtrosDatosBeneficiarias(codBeneficiaria, "E");
            odb.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(odb);
            odb.Show();
        }

        private void agregarDatosLaborales()
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Datos Laborales";
            String codBeneficiaria = dataGridView_Beneficiaria.Rows[dataGridView_Beneficiaria.CurrentRow.Index].Cells[0].Value.ToString();
            odb = new OtrosDatosBeneficiarias(codBeneficiaria, "L");
            odb.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(odb);
            odb.Show();
        }

        private void agregarDatosVivienda()
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Datos de la Vivienda";
            String codBeneficiaria = dataGridView_Beneficiaria.Rows[dataGridView_Beneficiaria.CurrentRow.Index].Cells[0].Value.ToString();
            DatosVivienda_Beneficiaria dvb = new DatosVivienda_Beneficiaria("C", personal);
            dvb.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(dvb);
            dvb.Show();
        }

        private void agregarDatosHistorialCronologico()
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Datos del Historial Cronológico";
            String codBeneficiaria = dataGridView_Beneficiaria.Rows[dataGridView_Beneficiaria.CurrentRow.Index].Cells[0].Value.ToString();
            odb = new OtrosDatosBeneficiarias(codBeneficiaria, "HC");
            odb.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(odb);
            odb.Show();
        }

        private void agregarDatosTalleres()
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Datos de Talleres Tomados";
            String codBeneficiaria = dataGridView_Beneficiaria.Rows[dataGridView_Beneficiaria.CurrentRow.Index].Cells[0].Value.ToString();
            odb = new OtrosDatosBeneficiarias(codBeneficiaria, "T");
            odb.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(odb);
            odb.Show();
        }

        private void textBox_datoConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(comboBox_buscarPor.SelectedIndex == 0)
            {
                validar.validarCamposNumericos(e);
            }else if(comboBox_buscarPor.SelectedIndex == 1)
            {
                validar.validarCamposTexto(e);
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                button_buscar_Click(null, null);
            }
        }
    }
}
