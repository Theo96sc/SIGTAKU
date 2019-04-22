using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundacionTalitaKumi
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        private static string idPersonal;
        private static int idBeneficiaria;
        public static string IdPersonal { get => idPersonal; set => idPersonal = value; }
        public static int IdBeneficiaria { get => idBeneficiaria; set => idBeneficiaria = value; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InicioSesion());
        }
    }
}
