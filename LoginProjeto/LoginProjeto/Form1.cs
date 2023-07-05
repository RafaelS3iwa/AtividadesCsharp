using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }                

        public void MostrarPanelUsuario()
        {
            panelLoginUsuario.Visible = true;
            panelLoginEmpresa.Visible = false;
        }

        public void MostrarPanelEmpresa()
        {
            panelLoginUsuario.Visible = false;
            panelLoginEmpresa.Visible = true;
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtEmail_Click(object sender, EventArgs e)
        {
            TxtEmail.SelectAll();
        }

        private void TxtSenha_Click(object sender, EventArgs e)
        {
            TxtSenha.SelectAll();
        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSenha.Text))
            {
                TxtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                TxtSenha.UseSystemPasswordChar = true;
                TxtSenha.PasswordChar = '•';
            }
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            List<string> email = new List<string>();
            email.Add("dan.rafinha@hotmail.com");
            List<string> senha = new List<string>();
            senha.Add("na0ki01");
            List<long> cpf = new List<long>();
            cpf.Add(12345678909);
            string cpfString = string.Concat(cpf);

            if (senha.Contains(TxtSenha.Text) && email.Contains(TxtEmail.Text))
            {
                MessageBox.Show("Bem vindo!");
            }
            else if(senha.Contains(TxtSenha.Text) && cpfString.Contains(TxtEmail.Text))
            {
                MessageBox.Show("Bem vindo!");
            }
            else
            {
                MessageBox.Show("Email ou senha errados");
            }
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            FormTelaInicial formTelaInicial = new FormTelaInicial();
            formTelaInicial.Show();
            this.Hide();
        }
    }
}
