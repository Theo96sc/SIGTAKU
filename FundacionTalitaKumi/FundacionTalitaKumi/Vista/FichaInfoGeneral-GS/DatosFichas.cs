using FundacionTalitaKumi.Controlador;
using FundacionTalitaKumi.Vista.Beneficiaria;
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
    public partial class DatosFichas : Form
    {
        int i = 0; //para avanzar de un panel de información a otro. 
        int j = 0; //para retroceder de un panel de inforamacion a otro.
        BeneficiariaBD bbd = new BeneficiariaBD();
        Validar validar = new Validar();
        FundacionTalitaKumi.Modelo.Personal personal = new Modelo.Personal();
        FundacionTalitaKumi.Modelo.Beneficiaria beneficiaria = new Modelo.Beneficiaria();
        String tipo = "";

        public DatosFichas(FundacionTalitaKumi.Modelo.Personal personal)
        {
            InitializeComponent();
            this.TopLevel = false;
            comboBox_buscarPor.SelectedIndex = 0;
            comboBox_buscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
            tableLayoutPanel_siguiente.Hide();
            buttonAnterior.Visible = false;
            label_subtitulo.Visible = false;
            button_nuevo.Visible = false;
            button_regresar.Show();
            button_pdf.Hide();
            button_guardar.Hide();
        }

        private void comboBox_buscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_datoConsulta.Text = "";
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            bbd.consultarBeneficiaria(dataGridView_Beneficiaria, comboBox_buscarPor.SelectedIndex, textBox_datoConsulta.Text);
        }

        private void dataGridView_Beneficiaria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //primer panel  
            try
            {
                beneficiaria = bbd.retornarObjetoBeneficiariaPrincipal(dataGridView_Beneficiaria.CurrentRow.Cells[0].Value.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha seleccionado una fila");
            }            
            agregarDatosPersonales();
            i++;
            j++;
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (j == 1)
            {
                tableLayoutPanel4.Show();
                button_siguiente.Show();
                buttonAnterior.Visible = false;
                button_regresar.Show();
                agregarDatosPersonales();
                i--;
            }
            else if (j == 2)
            {
                tableLayoutPanel4.Show();
                button_siguiente.Show();
                buttonAnterior.Visible = true;
                button_regresar.Show();
                agregarDatosFamiliares();
                i--;
                j--;
            }
            else if (j == 3)
            {
                tableLayoutPanel4.Show();
                buttonAnterior.Visible = true;
                button_regresar.Show();
                agregarDatosEducativos();
                i--;
                j--;
            }
            else if (j == 4)
            {
                tableLayoutPanel4.Show();
                button_siguiente.Show();
                buttonAnterior.Visible = true;
                button_regresar.Show();
                agregarDatosTalleres();
                i--;
                j--;
            }
            else if (j == 5)
            {
                tableLayoutPanel4.Show();
                button_siguiente.Show();
                buttonAnterior.Visible = true;
                button_regresar.Show();
                agregarDatosLaborales();
                i--;
                j--;
            }
            else if (j == 6)
            {
                tableLayoutPanel4.Hide();
                button_regresar.Show();
                button_siguiente.Show();
                agregarDatosCausasIngreso();
                i--;
                j--;
            }
            else if (j == 7)
            {
                tableLayoutPanel4.Hide();
                button_regresar.Show();
                button_siguiente.Show();
                agregarDatosVivienda();
                j--;
            }
        }

        private void button_siguiente_Click(object sender, EventArgs e)
        {
            buttonAnterior.Visible = true;
            if (i == 1)
            {
                tableLayoutPanel4.Show();
                button_nuevo.Visible = true;
                button_regresar.Show();
                agregarDatosFamiliares();
                i++;
            }
            else if (i == 2)
            {
                tableLayoutPanel4.Show();
                button_nuevo.Visible = true;
                button_regresar.Show();
                agregarDatosEducativos();
                i++;
                j++;
            }
            else if (i == 3)
            {
                tableLayoutPanel4.Show();
                button_nuevo.Visible = true;
                button_regresar.Show();
                agregarDatosTalleres();
                i++;
                j++;
            }
            else if (i == 4)
            {
                tableLayoutPanel4.Show();
                button_nuevo.Visible = true;
                button_regresar.Show();
                agregarDatosLaborales();
                i++;
                j++;
            }
            else if (i == 5)
            {
                tableLayoutPanel4.Hide();
                button_regresar.Show();
                agregarDatosCausasIngreso();
                i++;
                j++;
            }
            else if (i == 6)
            {
                tableLayoutPanel4.Hide();
                agregarDatosVivienda();
                i++;
                j++;
                button_regresar.Show();
            }
            else if (i == 7)
            {
                tableLayoutPanel4.Show();
                agregarObservaciones();
                button_regresar.Show();
                button_nuevo.Hide();
                button_siguiente.Visible = false;
                j++;
            }
        }


        private void agregarDatosPersonales()
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "1. Información General";
            InformacionPersonal ipb = new InformacionPersonal(beneficiaria);
            button_regresar.Visible = false;
            tableLayoutPanel_siguiente.Show();
            button_siguiente.Visible = true;
            ipb.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(ipb);
            ipb.Show();
            button_nuevo.Visible = false;
        }

        OtrosDatosBeneficiarias odb;

        private void agregarDatosFamiliares()
        {
            tipo = "F";
            panel_datos.Controls.Clear();
            button_nuevo.Visible = true;
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "2. Información Familiar";
            String codBeneficiaria = "";
            try
            {
                codBeneficiaria = dataGridView_Beneficiaria.Rows[dataGridView_Beneficiaria.CurrentRow.Index].Cells[0].Value.ToString();
            }
            catch (Exception ex)
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
            tipo = "E";
            panel_datos.Controls.Clear();
            button_nuevo.Visible = true;
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "3. Datos Educativos";
            String codBeneficiaria = dataGridView_Beneficiaria.Rows[dataGridView_Beneficiaria.CurrentRow.Index].Cells[0].Value.ToString();
            odb = new OtrosDatosBeneficiarias(codBeneficiaria, "E");
            odb.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(odb);
            odb.Show();
        }

        private void agregarDatosCausasIngreso()
        {
            tipo = "CI";
            panel_datos.Controls.Clear();
            button_nuevo.Visible = true;
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "5. Causas de Ingreso a la Fundación";
            String codBeneficiaria = dataGridView_Beneficiaria.Rows[dataGridView_Beneficiaria.CurrentRow.Index].Cells[0].Value.ToString();
            CausasIngreso ci = new CausasIngreso();
            ci.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(ci);
            ci.Show();
        }

        private void agregarDatosLaborales()
        {
            tipo = "L";
            panel_datos.Controls.Clear();
            button_nuevo.Visible = true;
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "4. Información Laboral";
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
            label_subtitulo.Text = "6. Información de la Vivienda";
            String codBeneficiaria = dataGridView_Beneficiaria.Rows[dataGridView_Beneficiaria.CurrentRow.Index].Cells[0].Value.ToString();
            DatosVivienda_Beneficiaria dvb = new DatosVivienda_Beneficiaria("C", personal);
            dvb.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(dvb);
            dvb.Show();
        }

        private void agregarDatosHistorialCronologico()
        {
            tipo = "HC";
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
            tipo = "T";
            panel_datos.Controls.Clear();
            button_nuevo.Visible = true;
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "3.1. Talleres Tomados";
            String codBeneficiaria = dataGridView_Beneficiaria.Rows[dataGridView_Beneficiaria.CurrentRow.Index].Cells[0].Value.ToString();
            odb = new OtrosDatosBeneficiarias(codBeneficiaria, "T");
            odb.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(odb);
            odb.Show();
        }

        private void agregarObservaciones()
        {
            panel_datos.Controls.Clear();
            button_nuevo.Visible = true;
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "7. Observaciones del Área de Gestión Social";
            button_guardar.Show();
            String codBeneficiaria = dataGridView_Beneficiaria.Rows[dataGridView_Beneficiaria.CurrentRow.Index].Cells[0].Value.ToString();
            ObersvacionesGenerales og = new ObersvacionesGenerales();
            og.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(og);
            og.Show();
        }

        private void textBox_datoConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox_buscarPor.SelectedIndex == 0)
            {
                validar.validarCamposNumericos(e);
            }
            else if (comboBox_buscarPor.SelectedIndex == 1)
            {
                validar.validarCamposTexto(e);
            }
        }

        private void panel_general_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            if(tipo == "F")
            {
                InformacionFamiliar ifa = new InformacionFamiliar();
                ifa.Show();
            }else if(tipo == "E")
            {
                InformacionEducativa ie = new InformacionEducativa();
                ie.Show();
            }else if(tipo == "T")
            {
                InformacionTalleres it = new InformacionTalleres();
                it.Show();
            }
            else if (tipo == "L")
            {
                InformacionLaboral il = new InformacionLaboral();
                il.Show();
            }

        }

        private void button_pdf_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea generar un PDF del informe?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //generar pdf
                MessageBox.Show("Informe Generado con éxito");
            }
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea guardar los datos del informe?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    //guardar en la BD
                    MessageBox.Show("Informe Guardado con éxito");
                    button_pdf.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido guardar el informe");
                }
            }
        }
    }
}
