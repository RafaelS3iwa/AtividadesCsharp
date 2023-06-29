using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorValidadorCpf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValidarCpf_Click(object sender, EventArgs e)
        {
            string digitarCpf = "";

            int[] cpfInt = digitarCpf.Select(digito => Convert.ToInt32(digito.ToString())).ToArray();

            int soma1 = 0, soma2 = 0;
            int resto1 = 0, resto2 = 0;

            for (int i = 0; i < 9; i++)
            {
                soma1 += cpfInt[i] * (10 - i);
                resto1 = (soma1 * 10) % 11;
            }

            for (int i = 0; i < 10; i++)
            {
                soma2 += cpfInt[i] * (11 - i);
                resto2 = (soma2 * 10) % 11;
            }

            resto1 = (resto1 == 10 || resto1 == 11) ? 0 : resto1;
            resto2 = (resto2 == 10 || resto2 == 11) ? 0 : resto2;

            if (resto1 != cpfInt[9] || resto2 != cpfInt[10])
            {
                TxtdigitarCpf.Clear();

                TxtdigitarCpf.Text = "Inválido";
            }
            else
            {
                TxtdigitarCpf.Text = "Válido";
            }
        }
    }
}
