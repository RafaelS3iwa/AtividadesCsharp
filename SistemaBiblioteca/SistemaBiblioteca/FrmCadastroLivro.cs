using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class FrmCadastroLivro : Form
    {
        public string conexaoString;
        private SqlConnection conexaoDB;

        public FrmCadastroLivro()
        {
            InitializeComponent();

            //String de conexão
            conexaoString = "Data Source=MAR0625641W10-1;Initial Catalog=Biblioteca;Integrated Security=True";

            //Inicializando a conexão com o Banco de Dados
            conexaoDB = new SqlConnection(conexaoString);
        }

        private void FrmCadastroLivro_Load(object sender, EventArgs e)
        {
            CarregarDadosLivros();
        }

        private void CarregarDadosLivros()
        {
            try
            {
                conexaoDB.Open();
                string sql = "SELECT * FROM Livros";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexaoDB);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                DgvLivro.DataSource = dataTable;

                conexaoDB.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao carregar os dados: {ex}");
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO Livros (titulo, autor, numero_pagina, preco, ano_publicacao, isbn) VALUES(@titulo, @autor, @numero_pagina, @preco, @ano_publicacao, @isbn)";
                conexaoDB.Open();

                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);
                sqlCmd.Parameters.AddWithValue("@titulo", TxtTitulo.Text);
                sqlCmd.Parameters.AddWithValue("@autor", TxtAutor.Text);
                sqlCmd.Parameters.AddWithValue("@numero_pagina", TxtNumeroPaginas.Text);
                sqlCmd.Parameters.AddWithValue("@preco", TxtPreco.Text);

                DateTime anoPublicacao;
                DateTime.TryParse(TxtAnoPublicacao.Text, out anoPublicacao);

                sqlCmd.Parameters.AddWithValue("@ano_publicacao", anoPublicacao);
                sqlCmd.Parameters.AddWithValue("@isbn", TxtIsbn.Text);

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro Realizado com Sucesso!!!");

                conexaoDB.Close();

                CarregarDadosLivros();
            }
            catch(SqlException ex)
            {
                MessageBox.Show($"Erro ao Inserir os Dados: {ex}");
            }
        }
    }
}
