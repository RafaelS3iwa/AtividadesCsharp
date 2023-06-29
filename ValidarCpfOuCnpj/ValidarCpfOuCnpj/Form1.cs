using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidarCpfOuCnpj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtNumero.Text == "" || RdCpf.Text == "" || RdCnpj.Text == "")
            {
                //mensagem de alerta
                MessageBox.Show("Aew escolhe um baguio antes po", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }


            if (RdCpf.Checked)
            {
                string cpf = TxtNumero.Text;
                string cpfSemCaracteres = cpf.Replace(".", "").Replace("/", "").Replace("-", "");
                int numero;

                int[] cpfInt = cpfSemCaracteres.Select(digito => Convert.ToInt32(digito.ToString())).ToArray();
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

                if (resto1 == cpfInt[9] && resto2 == cpfInt[10])
                {
                    MessageBox.Show($"O CPF: {cpf} está válido");
                }
                else
                {
                    MessageBox.Show($"O CPF: {cpf} está inválido");
                }
            }
            else if (RdCnpj.Checked)
            {
                string cnpj = TxtNumero.Text;
                string cnpjSemCaracteres = cnpj.Replace(".", "").Replace("/", "").Replace("-", "");

                int[] cnpjInt = cnpj.Select(digito => Convert.ToInt32(digito.ToString())).ToArray();

                int[] peso1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] peso2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma1 = 0, soma2 = 0;
                int resto1 = 0, resto2 = 0;

                for (int i = 0; i < 12; i++)
                {
                    soma1 += cnpjInt[i] * peso1[i];
                    resto1 = soma1 % 11;
                }
                resto1 = (resto1 < 2) ? 0 : 11 - resto1; 

                if (cnpj[12] == resto1)
                {
                    for (int i = 0; i < 13; i++)
                    {
                        soma2 += cnpjInt[i] * peso2[i];
                        resto2 = soma2 % 11;
                    }
                    resto2 = (resto2 < 2) ? 0 : 11 - resto2;
                }

                if (resto1 == cnpjInt[12] || resto2 == cnpjInt[13])
                {
                    MessageBox.Show($"O CNPJ: {cnpj} está válido");
                }
                else
                {
                    MessageBox.Show($"O CNPJ: {cnpj} está inválido");
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

   

        private void RdCpf_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

            if (RdCpf.Checked)
            {
                string cpf = TxtNumero.Text.Replace(".", "").Replace("/", "").Replace("-", "").Trim();
                if (cpf.Length > 0)
                {
                    if (cpf.Length <= 3)
                    {
                        TxtNumero.Text = cpf;
                    }
                    else if (cpf.Length <= 6)
                    {
                        TxtNumero.Text = cpf.Substring(0, 3) + "." + cpf.Substring(3);
                    }
                    else if (cpf.Length <= 9)
                    {
                        TxtNumero.Text = cpf.Substring(0, 3) + "." + cpf.Substring(3, 3) + "." + cpf.Substring(6);
                    }
                    else if (cpf.Length <= 11)
                    {
                        TxtNumero.Text = cpf.Substring(0, 3) + "." + cpf.Substring(3, 3) + "." + cpf.Substring(6, 3) + "-" + cpf.Substring(9);
                    }
                    else
                    {
                        MessageBox.Show("Aew limite máximo de caracteres excedido");
                    }

                    TxtNumero.SelectionStart = TxtNumero.Text.Length;
                }
            else if (RdCnpj.Checked)
                {
                    string cnpj = TxtNumero.Text.Replace(".", "").Replace("/", "").Replace("-", "").Trim();
                    if (cnpj.Length == 0)
                    {
                        if (cnpj.Length <= 2)
                        {
                            TxtNumero.Text = cnpj;
                        }
                        else if (cnpj.Length <= 5)
                        {
                            TxtNumero.Text = cnpj;
                        }
                    }
                }
            }
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impede a digitação de caracteres não numéricos
            }

            int maxLength = 0;

            if (RdCpf.Checked)
            {
                maxLength = 14;
            }
            else if (RdCnpj.Checked)
            {
                maxLength = 18;
            }
            else
            {
                return; // Nenhum RadioButton está marcado, não faz nada
            }

            if (TxtNumero.Text.Length >= maxLength && e.KeyChar != '\b') // Verifica se atingiu o limite e a tecla pressionada não é "Backspace"
            {
                e.Handled = true; // Impede que o caractere seja digitado
                MessageBox.Show("Aew o limite foi atingido");                 
                return;
            }

            if (TxtNumero.Text.Length == maxLength && e.KeyChar != '\b') // Verifica se atingiu o limite exato de caracteres e a tecla pressionada não é "Backspace"
            {
                TxtNumero.Text = TxtNumero.Text.Substring(0, TxtNumero.Text.Length - 1); // Remove o último caractere digitado
                TxtNumero.SelectionStart = TxtNumero.Text.Length; // Mantém o cursor no final do texto
                e.Handled = true; // Impede que o caractere seja digitado
            }
        }
    }
}
