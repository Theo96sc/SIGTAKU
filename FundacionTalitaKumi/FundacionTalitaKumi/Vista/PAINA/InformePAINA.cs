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
    public partial class InformePAINA : Form
    {
        public InformePAINA()
        {
            InitializeComponent();
            this.TopLevel = false;
            button_nuevo.Hide();
            button_pdf.Hide();
            panel.Hide();
            buttonAnterior.Hide();
            button_siguiente.Hide();
            button_guardar.Hide();
            comboBox_buscarPor.SelectedIndex = 0;
            comboBox_buscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        Validar validar = new Validar();
        BeneficiariaBD bbd = new BeneficiariaBD();
        FundacionTalitaKumi.Modelo.Beneficiaria beneficiaria = new FundacionTalitaKumi.Modelo.Beneficiaria();
        int i = 0;
        int j = 0;
        String codBeneficiaria = "";
        String tipo = "";

        Fechas fe = new Fechas();
        Objetivos ob = new Objetivos();
        Responsables r = new Responsables();
        List<Object> listaFechas;
        List<Object> listaObjetivo;
        
        private void comboBox_buscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_datoConsulta.Text = "";
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
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                button_buscar_Click(null, null);
            }
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            bbd.consultarBeneficiaria(dataGridView_Beneficiaria, comboBox_buscarPor.SelectedIndex, textBox_datoConsulta.Text);
        }

        private void dataGridView_Beneficiaria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                beneficiaria = bbd.retornarObjetoBeneficiariaPrincipal(dataGridView_Beneficiaria.CurrentRow.Cells[0].Value.ToString());
                codBeneficiaria = dataGridView_Beneficiaria.Rows[dataGridView_Beneficiaria.CurrentRow.Index].Cells[0].Value.ToString();
                Program.IdBeneficiaria = int.Parse(codBeneficiaria);
                Console.WriteLine(Program.IdBeneficiaria);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha seleccionado una fila");
            }
            panel.Show();
            setearDatos();
            agregaFechas();
            i++;
            j++;
        }

        private void button_siguiente_Click(object sender, EventArgs e)
        {
            buttonAnterior.Visible = true;
            if (i == 1)
            {
                listaFechas = fe.retornarValores();
                tableLayoutPanel4.Show();
                button_nuevo.Visible = true;
                button_regresar.Show();
                agregaObjetivos();               
                i++;
                
            }else if (i == 2)
            {
                listaObjetivo = ob.retornarValores();
                tableLayoutPanel4.Show();
                button_nuevo.Visible = true;
                button_regresar.Show();
                agregarArea();
                i++;
                j++;
            }else if (i == 3)
            {
                tableLayoutPanel4.Show();
                button_nuevo.Visible = true;
                button_regresar.Show();
                agregarResponsables();
                j++;
            }
        }


        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (j == 1)
            {
                tableLayoutPanel4.Show();
                buttonAnterior.Visible = false;
                button_regresar.Show();
                agregaFechas();
                i--;
            }else if (j == 2)
            {
                tableLayoutPanel4.Show();
                buttonAnterior.Visible = false;
                button_regresar.Show();
                agregaObjetivos();
                i--;
                j--;
            }else if (j == 3)
            {
                tableLayoutPanel4.Show();
                buttonAnterior.Visible = false;
                button_regresar.Show();
                agregarArea();
                j--;
            }            
        }

        private void agregaFechas()
        {
            panel_cambio.Controls.Clear();
            button_siguiente.Show();
            button_nuevo.Hide();
            button_pdf.Hide();
            buttonAnterior.Hide();
            fe.Dock = DockStyle.Fill;
            panel_cambio.Controls.Add(fe);
            fe.Show();
        }

        private void agregaObjetivos()
        {
            panel_cambio.Controls.Clear();
            buttonAnterior.Show();
            button_siguiente.Show();
            button_nuevo.Hide();
            button_pdf.Hide();
            ob.Dock = DockStyle.Fill;
            panel_cambio.Controls.Add(ob);
            ob.Show();
        }

        public void agregarArea()
        {
            tipo = "A";
            panel_cambio.Controls.Clear();
            buttonAnterior.Show();
            button_siguiente.Show();
            button_nuevo.Show();
            button_pdf.Visible = false;
            Area area = new Area(codBeneficiaria);
            area.Dock = DockStyle.Fill;
            panel_cambio.Controls.Add(area);
            area.Show();
        }

        private void agregarResponsables()
        {
            panel_cambio.Controls.Clear();
            buttonAnterior.Show();
            button_nuevo.Visible = false;
            button_guardar.Show();
            button_siguiente.Hide();      
            r.Dock = DockStyle.Fill;
            panel_cambio.Controls.Add(r);
            r.Show();
        }

        private void setearDatos()
        {
            //
            textBox_nombres.ReadOnly = true;
            textBox_apellidos.ReadOnly = true;
            comboBox_etnia.Enabled = false;
            textBox_edad.ReadOnly = true;
            textBox_nombresRF.ReadOnly = true;
            textBox_apellidosRF.ReadOnly = true;
            textBox_causas.ReadOnly = true;

            DateTime fechaActual = DateTime.Now;
            FundacionTalitaKumi.Modelo.DatosFamiliares df = bbd.retornarObjetoDatosFamiliares(int.Parse(codBeneficiaria));
            textBox_nombres.Text = beneficiaria.NombresBeneficiaria;
            textBox_apellidos.Text = beneficiaria.ApellidosBeneficiaria;
            comboBox_etnia.Text = beneficiaria.EtniaBe;
            textBox_edad.Text =  fechaActual.Year -  beneficiaria.FechaDeNacimientoBe.Year +"";
            textBox_nombresRF.Text = df.NombresFamiliar;
            textBox_apellidosRF.Text = df.ApellidosFamiliar;
            textBox_causas.Text = beneficiaria.MotivoDeIngreso;

        }

        private void button_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button_nuevo_Click(object sender, EventArgs e)
        {
            if(tipo == "A")
            {
                NuevaArea na = new NuevaArea(codBeneficiaria);
                na.Show();
            }
        }

        private void button_pdf_Click(object sender, EventArgs e)
        {

            GeneraPDF genera = new GeneraPDF();
            AreaBD area = new AreaBD();
            InformePAINABD pabd = new InformePAINABD();
            PersonalBD perBD = new PersonalBD();
            BeneficiariaBD benBD = new BeneficiariaBD();
            
            Modelo.Area areaPDF = area.retornarArea(Program.IdBeneficiaria);
            Modelo.InformePAINA painaPDF = pabd.retornarPAINA(Program.IdBeneficiaria);
            Modelo.Personal perPDF = perBD.retornarObjetoPersonal(Program.IdPersonal);
            Modelo.DatosFamiliares famPDF = benBD.retornarObjetoDatosFamiliares(Program.IdBeneficiaria);
            
            DialogResult dr = MessageBox.Show("¿Está seguro que desea generar el PDF del informe?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (guardarPDF.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        MessageBox.Show("Espere mientras se genera el PDF");
                        genera.GenerarPDF(guardarPDF.FileName, beneficiaria, painaPDF, areaPDF, perPDF, famPDF);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se ha podido generar el PDF");

                    }
                }
                
            }
        }

        private void button_nuevo_Leave(object sender, EventArgs e)
        {
            agregarArea();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            FundacionTalitaKumi.Modelo.InformePAINA paina = new Modelo.InformePAINA(int.Parse(codBeneficiaria), Convert.ToDateTime(listaFechas[0]), Convert.ToDateTime(listaFechas[1]), Convert.ToString(listaObjetivo[0]), Convert.ToString(listaObjetivo[1]), Convert.ToString(listaObjetivo[2]), Convert.ToString(listaFechas[2]));
            InformePAINABD painabd = new InformePAINABD();
            DialogResult dr = MessageBox.Show("¿Está seguro que desea guardar los datos del informe?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    painabd.insertarPAINA(paina);
                    MessageBox.Show("Informe Guardado con éxito");
                    button_pdf.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido guardar el informe");
                }
            }
        }

        private void panel_cambio_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
