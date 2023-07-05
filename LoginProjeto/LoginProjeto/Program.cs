using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProjeto
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormTelaInicial formTelaInicial = new FormTelaInicial();

            Form1 form1 = new Form1();
            form1.Hide();

            FormCadastro form2 = new FormCadastro();
            form2.Hide();

            Application.Run(formTelaInicial);
        }
    }
}
