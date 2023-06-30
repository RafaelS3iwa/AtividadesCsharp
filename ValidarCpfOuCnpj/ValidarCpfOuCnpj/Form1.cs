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
                MessageBox.Show("Por favor, escolha uma opção.", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }


            if (RdCpf.Checked)
            {
                string cpf = TxtNumero.Text;
                string cpfSemCaracteres = cpf.Replace(".", "").Replace("/", "").Replace("-", "");

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
                    MessageBox.Show($"O CPF: {cpf} está válido", "Resultado:", MessageBoxButtons.OK) ;
                }
                else
                {
                    MessageBox.Show($"O CPF: {cpf} está inválido", "Resultado:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation) ;
                }
            }
            else if (RdCnpj.Checked)
            {
                string cnpj = TxtNumero.Text;
                string cnpjSemCaracteres = cnpj.Replace(".", "").Replace("/", "").Replace("-", "");

                int[] cnpjInt = cnpjSemCaracteres.Select(digito => Convert.ToInt32(digito.ToString())).ToArray();

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

                for (int i = 0; i < 13; i++)
                {
                    soma2 += cnpjInt[i] * peso2[i];
                    resto2 = soma2 % 11;
                }
                resto2 = (resto2 < 2) ? 0 : 11 - resto2;

                if (cnpjInt[12] == resto1 && cnpjInt[13] == resto2)
                {
                    MessageBox.Show($"O CNPJ: {cnpj} está válido", "Resultado:", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"O CNPJ: {cnpj} está inválido", "Resultado:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
                        MessageBox.Show("O limite de caracteres foi excedido!", "Erro!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    TxtNumero.SelectionStart = TxtNumero.Text.Length;
                }
            }
            else if (RdCnpj.Checked)
            {
                string cnpj = TxtNumero.Text.Replace(".", "").Replace("/", "").Replace("-", "").Trim();
                if (cnpj.Length > 0)
                {
                    if (cnpj.Length <= 2)
                    {
                        TxtNumero.Text = cnpj;
                    }
                    else if (cnpj.Length <= 5)
                    {
                        TxtNumero.Text = cnpj.Substring(0, 2) + "." + cnpj.Substring(2);
                    }
                    else if (cnpj.Length <= 8)
                    {
                        TxtNumero.Text = cnpj.Substring(0, 2) + "." + cnpj.Substring(2, 3) + "." + cnpj.Substring(5);
                    }
                    else if (cnpj.Length <= 12)
                    {
                        TxtNumero.Text = cnpj.Substring(0, 2) + "." + cnpj.Substring(2, 3) + "." + cnpj.Substring(5, 3) + "/" + cnpj.Substring(8);
                    }
                    else if (cnpj.Length <= 14)
                    {
                        TxtNumero.Text = cnpj.Substring(0, 2) + "." + cnpj.Substring(2, 3) + "." + cnpj.Substring(5, 3) + "/" + cnpj.Substring(8, 4) + "-" + cnpj.Substring(12);
                    }
                    else
                    {
                        MessageBox.Show("Limite máximo de caracteres excedido", "Erro!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                    TxtNumero.SelectionStart = TxtNumero.Text.Length;
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
                TxtNumero.SelectionStart = TxtNumero.Text.Length; // Mantém o cursor no final do texto
                e.Handled = true; // Impede que o caractere seja digitado
                MessageBox.Show("O limite de caracteres foi excedido!", "Erro!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);         
                return;
            }
        }

        private void MsValidar_Click(object sender, EventArgs e)
        {
                panel1.Visible = true;
                panel2.Visible = true;        
        }

        private void MsGerar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void BtGerar_Click(object sender, EventArgs e)
        {
            if(!RdGerarCpf.Checked && !RdGerarCnpj.Checked)
            {
                MessageBox.Show("Erro, por favor, selecione uma opção.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (RdGerarCpf.Checked)
            {
                int soma1 = 0, soma2 = 0;
                int resto1 = 0, resto2 = 0;

                Random random = new Random();
                int[] cpfInt = new int[11];

                for (int i = 0; i < cpfInt.Length; i++)
                {
                    int randomNumber = random.Next(10);
                    cpfInt[i] = randomNumber;
                }

                for (int i = 0; i < 9; i++)
                {
                    soma1 += cpfInt[i] * (10 - i);
                    resto1 = (soma1 * 10) % 11;
                }

                resto1 = (resto1 == 10 || resto1 == 11) ? 0 : resto1;
                cpfInt[9] = resto1;

                for (int i = 0; i < 10; i++)
                {
                    soma2 += cpfInt[i] * (11 - i);
                    resto2 = (soma2 * 10) % 11;
                }
                resto2 = (resto2 == 10 || resto2 == 11) ? 0 : resto2;

                cpfInt[10] = resto2;

                string cpf = string.Concat(cpfInt);
                string cpfFormatado = $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";

                if (cpfInt[9] == resto1 && cpfInt[10] == resto2)
                {
                    TxtNumeroGerado.Text = cpfFormatado.ToString(); 
                }
                else
                {
                    return;
                }
            }
            else if (RdGerarCnpj.Checked)
            {
                int[] peso1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] peso2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma1 = 0, soma2 = 0;
                int resto1 = 0, resto2 = 0;

                Random random = new Random();
                int[] cnpjInt = new int[14];

                for (int i = 0; i < cnpjInt.Length; i++)
                {
                    int randomNumber = random.Next(10);
                    cnpjInt[i] = randomNumber;
                }

                for (int i = 0; i < 12; i++)
                {
                    soma1 += cnpjInt[i] * peso1[i];
                    resto1 = soma1 % 11;
                }

                resto1 = (resto1 < 2) ? 0 : 11 - resto1;
                cnpjInt[12] = resto1;

                for (int i = 0; i < 13; i++)
                {
                    soma2 += cnpjInt[i] * peso2[i];
                    resto2 = soma2 % 11;
                }
                resto2 = (resto2 < 2) ? 0 : 11 - resto2;

                cnpjInt[13] = resto2;


                string cnpj = string.Concat(cnpjInt);
                string cnpjFormatado = $"{cnpj.Substring(0, 2)}.{cnpj.Substring(2, 3)}.{cnpj.Substring(5, 3)}/{cnpj.Substring(8, 4)}-{cnpj.Substring(12, 2)}";

                if (cnpjInt[12] == resto1 && cnpjInt[13] == resto2)
                {
                    TxtNumeroGerado.Text = cnpjFormatado.ToString();
                }
                else
                {
                    return;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
