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
        DataGridViewRow linhaSelecionada;

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

        private void CarregarDadosLivros(int id = 0)
        {
            try
            {
                conexaoDB.Open();
                string sql; 

                if(id == 0)
                {
                   sql = "SELECT * FROM Livros";
                }
                else
                {
                    sql = $"SELECT * FROM Livros WHERE id_livroint = {id}";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexaoDB);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataTable.Columns["id_livroint"].ColumnName = "ID Livro";
                dataTable.Columns["titulo"].ColumnName = "Título";
                dataTable.Columns["autor"].ColumnName = "Autor";
                dataTable.Columns["numero_pagina"].ColumnName = "Número de Páginas";
                dataTable.Columns["preco"].ColumnName = "Preço";
                dataTable.Columns["ano_publicacao"].ColumnName = "Ano de Publicação";
                dataTable.Columns["isbn"].ColumnName = "ISBN";

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

        private void DgvLivro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                linhaSelecionada = DgvLivro.Rows[e.RowIndex];

                TxtTitulo.Text = linhaSelecionada.Cells["Título"].Value.ToString();
                TxtAutor.Text = linhaSelecionada.Cells["Autor"].Value.ToString();
                TxtNumeroPaginas.Text = linhaSelecionada.Cells["Número de Páginas"].Value.ToString();
                TxtPreco.Text = linhaSelecionada.Cells["Preço"].Value.ToString();
                TxtAnoPublicacao.Text = linhaSelecionada.Cells["Ano de Publicação"].Value.ToString();
                TxtIsbn.Text = linhaSelecionada.Cells["ISBN"].Value.ToString();

                BtnAdicionar.Enabled = false;
                BtnAtualizar.Enabled = true;
                BtnExcluir.Enabled = true;
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(linhaSelecionada.Cells["ID Livro"].Value.ToString());

                string sql = "UPDATE Livros SET " +
                        "titulo=@titulo, " +
                        "autor=@autor, " +
                        "numero_pagina=@numero_pagina, " +
                        "preco=@preco, " +
                        "ano_publicacao=@ano_publicacao, " +
                        "isbn=isbn " +
                        "WHERE id_livroint=@id_livroint";

                conexaoDB.Open();

                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                sqlCmd.Parameters.AddWithValue("@id_livroint", id);
                sqlCmd.Parameters.AddWithValue("@titulo", TxtTitulo.Text);
                sqlCmd.Parameters.AddWithValue("@autor", TxtAutor.Text);
                sqlCmd.Parameters.AddWithValue("@numero_pagina", TxtNumeroPaginas.Text);
                sqlCmd.Parameters.AddWithValue("@preco", TxtPreco.Text);
                sqlCmd.Parameters.AddWithValue("@isbn", TxtIsbn.Text);
                sqlCmd.Parameters.AddWithValue("@ano_publicacao", TxtAnoPublicacao.Text);

                /*DateTime anoPublicacao;
                DateTime.TryParse(TxtAnoPublicacao.Text, out anoPublicacao);
                */

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Atualização Realizada com Sucesso!");

                conexaoDB.Close();

                CarregarDadosLivros();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao Atualizar os Dados: {ex}");   
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if(linhaSelecionada != null)
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o aluno?", "Atençao!", MessageBoxButtons.YesNo);

                if(resultado == DialogResult.Yes) 
                {
                    try
                    {
                        int id = Convert.ToInt32(linhaSelecionada.Cells["ID Livro"].Value.ToString());

                        string sql = "DELETE FROM Livros " +
                                    "WHERE id_livroint=@id_livroint";

                        conexaoDB.Open();

                        SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                        sqlCmd.Parameters.AddWithValue("@id_livroint", id);
                        sqlCmd.ExecuteNonQuery();

                        MessageBox.Show("O Livro foi deletado com sucesso!");

                        conexaoDB.Close();

                        CarregarDadosLivros();
                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show($"Erro ao Excluir os Dados: {ex}");
                    }                
                }
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            int id;

            if (int.TryParse(TxtPesquisar.Text, out id))
            {
                CarregarDadosLivros(id);
            }
            else
            {
                MessageBox.Show("Erro, id inválido!");
            }
        }

        private void TxtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAnoPublicacao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
