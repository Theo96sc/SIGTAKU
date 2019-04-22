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
    public partial class Panel_Usuario : Form
    {
        public Panel_Usuario(String cargo, String nombresApellidos)
        {
            InitializeComponent();
            this.TopLevel = false;
            label_hora.Text = DateTime.Now.ToString("f");
            label_cargo.Text = cargo;
            label_NyA.Text = nombresApellidos;
        }
    }
}
