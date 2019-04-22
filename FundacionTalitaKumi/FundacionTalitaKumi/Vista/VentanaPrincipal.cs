using FundacionTalitaKumi.Vista.Beneficiaria;
using FundacionTalitaKumi.Vista.FichaInfoGeneral_GS;
using FundacionTalitaKumi.Vista.FichaPsicología;
using FundacionTalitaKumi.Vista.PAINA;
using FundacionTalitaKumi.Vista.Personal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundacionTalitaKumi.Vista
{
    public partial class VentanaPrincipal : Form
    {
        FundacionTalitaKumi.Modelo.Personal personal = new FundacionTalitaKumi.Modelo.Personal();
        public VentanaPrincipal(FundacionTalitaKumi.Modelo.Personal personal)
        {
            InitializeComponent();
            this.personal = personal;
            label_subtitulo.Hide();
            regresarToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            //panel titulo
            Titulo t = new Titulo();
            t.Dock = DockStyle.Fill;
            panel_titulo.Controls.Add(t);
            t.Show();
            //panel usuario
            Panel_Usuario pu = new Panel_Usuario(personal.Tipo, personal.Nombres + " " + personal.Apellidos);
            pu.Dock = DockStyle.Fill;
            panel_usuario.Controls.Add(pu);
            pu.Show();

            /*OJO*/
            fichaDeSeguimientoLaboralDeToolStripMenuItem.Visible = false;
            avanceDeTrabajoDelÁreaDeGestiónSocialToolStripMenuItem.Visible = false;
            listarFichasPsicoloiaToolStripMenuItem2.Visible = false;
            informeSocial_toolStripMenuItem1.Visible = false;
            PGF_toolStripMenuItem9.Visible = false;
            informeDelNNAInstitucionalizadoToolStripMenuItem.Visible = false;
            listarPAINA_toolStripMenuItem8.Visible = false;
            consultarToolStripMenuItem.Visible = false;
            listarToolStripMenuItem.Visible = false;


            if (personal.Tipo != "ADMINISTRADOR/A")
            {
                gestiónAdministrativaToolStripMenuItem.Visible = false;
                registrarBeneficiariaToolStripMenuItem.Visible = false;
                administraciónDelSistemaToolStripMenuItem.Visible = false;
                if (personal.Tipo == "GESTOR/A SOCIAL")
                {
                    nuevaFichaPS1.Visible = false;
                    nuevoInformeTS1.Visible = false;
                    nuevoInformeTS2.Visible = false;
                    nuevoInformeTS3.Visible = false;
                    nuevoInformeTS4.Visible = false;
                    nuevoFichaGS1.Visible = true;
                    nuevaFichaGS22.Visible = true;
                    nuevaFichaGS3.Visible = true;
                }

                if (personal.Tipo == "PSICÓLOGO/A")
                {
                    nuevoFichaGS1.Visible = false;
                    nuevaFichaGS22.Visible = false;
                    nuevaFichaGS3.Visible = false;
                    nuevoInformeTS1.Visible = false;
                    nuevoInformeTS2.Visible = false;
                    nuevoInformeTS3.Visible = false;
                    nuevoInformeTS4.Visible = false;
                    nuevaFichaPS1.Visible = true;
                }

                if (personal.Tipo == "TRABAJADOR/A SOCIAL")
                {
                    nuevoFichaGS1.Visible = false;
                    nuevaFichaGS22.Visible = false;
                    nuevaFichaGS3.Visible = false;
                    nuevaFichaPS1.Visible = false;
                    nuevoInformeTS1.Visible = true;
                    nuevoInformeTS2.Visible = true;
                    nuevoInformeTS3.Visible = true;
                    nuevoInformeTS4.Visible = true;
                }
            }
            else
            {
                nuevoFichaGS1.Visible = false;
                nuevaFichaGS22.Visible = false;
                nuevaFichaGS3.Visible = false;
                nuevaFichaPS1.Visible = false;
                nuevoInformeTS1.Visible = false;
                nuevoInformeTS2.Visible = false;
                nuevoInformeTS3.Visible = false;
                nuevoInformeTS4.Visible = false;
            }
            
           
            

        }

        private void VentanaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioSesion iso = new InicioSesion();
            iso.Visible = true;
        }

        private void ayudaEnLíneaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Registrar Personal";
            DatosPersonalAdministrativo dpa = new DatosPersonalAdministrativo("R", personal);
            dpa.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(dpa);
            dpa.Show();
        }

        private void consultarPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Consultar Datos del Personal";
            ConsultarPersonalAdministrativo cpa = new ConsultarPersonalAdministrativo(personal);
            cpa.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(cpa);
            cpa.Show();
        }

        private void listarPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Listar Personal";
            ListarPersonalAdministrativo lpa = new ListarPersonalAdministrativo();
            lpa.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(lpa);
            lpa.Show();
        }

        private void registrarVacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Registrar Vacaciones";
            RegistrarVacaciones rv = new RegistrarVacaciones(personal);
            rv.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(rv);
            rv.Show();
        }

        private void consultarVacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Consultar Vacaciones del Personal";
            ConsultarVacacionPersonal cvp = new ConsultarVacacionPersonal(personal);
            cvp.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(cvp);
            cvp.Show();
        }

        private void listarVacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Listar Vacaciones del Personal";
            ListarVacaciones lv = new ListarVacaciones();
            lv.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(lv);
            lv.Show();
        }

        private void registrarBeneficiariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosPersonalesBeneficiarias db = new DatosPersonalesBeneficiarias("R", personal, null);
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Registro de Beneficiarias";
            db.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(db);
            db.Visible = true;
        }

        private void consultarBeneficiariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Consultar Datos de Beneficiaria";
            ConsultarDatosBeneficiarias cdb = new ConsultarDatosBeneficiarias(personal);
            cdb.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(cdb);
            cdb.Visible = true;
        }

        private void listarBeneficiariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Listar Datos de Beneficiaria";
            ListarBeneficiarias lb = new ListarBeneficiarias();
            lb.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(lb);
            lb.Visible = true;
        }

        private void nuevoFichaGS1_Click(object sender, EventArgs e)
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Ficha de Información General de las Jóvenes y Adolescentes";
            DatosFichas df = new DatosFichas(personal);
            df.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(df);
            df.Show();
        }

        private void panel_datos_ControlRemoved(object sender, ControlEventArgs e)
        {
            label_subtitulo.Text = "";
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevaFichaPS1_Click(object sender, EventArgs e)
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Resumen Clínico de las Sesiones de Psicoterapia";
            crearFichaPS cf = new crearFichaPS("R");
            cf.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(cf);
            cf.Show();
        }

        private void crearUsuarioItem_Click(object sender, EventArgs e)
        {
            CrearUsuario cu = new CrearUsuario();
            cu.Show();
        }

        private void actualizarContraseñaDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarContrasena cc = new CambiarContrasena("", "AU");
            cc.Show();
        }

        private void nuevoInformeTS2_Click(object sender, EventArgs e)
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Proyecto Integral de Atención a la Niña, Niño y Adolescente - PAINA";
            InformePAINA ipaina = new InformePAINA();
            ipaina.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(ipaina);
            ipaina.Show();
        }

        private void consultarPorBeneficiariaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Resumen Clínico de las Sesiones de Psicoterapia";
            crearFichaPS cf = new crearFichaPS("C");
            cf.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(cf);
            cf.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            panel_datos.Controls.Clear();
            label_subtitulo.Visible = true;
            label_subtitulo.Text = "Proyecto Integral de Atención a la Niña, Niño y Adolescente - PAINA";
            ConsultarFichaPAINA ipaina = new ConsultarFichaPAINA();
            ipaina.Dock = DockStyle.Fill;
            panel_datos.Controls.Add(ipaina);
            ipaina.Show();
        }
    }
}
