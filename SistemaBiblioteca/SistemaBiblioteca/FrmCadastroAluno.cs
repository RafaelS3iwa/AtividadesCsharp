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
    public partial class FrmCadastroAluno : Form
    {
        public string conexaoString;
        private SqlConnection conexaoDB;
        DataGridViewRow linhaSelecionada;

        public FrmCadastroAluno()
        {
            InitializeComponent();

            //String de conexão
            conexaoString = "Data Source=MAR0625641W10-1;Initial Catalog=Biblioteca;Integrated Security=True";

            //Inicializando a conexão com o Banco de Dados
            conexaoDB = new SqlConnection(conexaoString);
        }

        private void FrmCadastroAluno_Load(object sender, EventArgs e)
        {
            CarregarDadosAlunos(); 
        }
        
        private void CarregarDadosAlunos(int id = 0)
        {
            try
            {
                conexaoDB.Open();

                string sql;

                if(id == 0)
                {
                    sql = "SELECT * FROM Alunos";
                }
                else
                {
                    sql = $"SELECT * FROM Alunos WHERE id_aluno = {id}";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexaoDB);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataTable.Columns["id_aluno"].ColumnName = "ID Aluno";
                dataTable.Columns["nome"].ColumnName = "Nome";
                dataTable.Columns["cpf"].ColumnName = "CPF";
                dataTable.Columns["email"].ColumnName = "E-mail";
                dataTable.Columns["telefone"].ColumnName = "Telefone";
                dataTable.Columns["celular"].ColumnName = "Celular";
                dataTable.Columns["data_nascimento"].ColumnName = "Data de Nascimento";

                DgvAlunos.DataSource = dataTable;

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
                string sql = "INSERT INTO Alunos (nome, cpf, email, telefone, celular, data_nascimento) VALUES(@nome, @cpf, @email, @telefone, @celular, @data_nascimento)";
                conexaoDB.Open();

                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                sqlCmd.Parameters.AddWithValue("@nome",TxtNome.Text);
                sqlCmd.Parameters.AddWithValue("@cpf", TxtCpf.Text);
                sqlCmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                sqlCmd.Parameters.AddWithValue("@telefone", TxtTelefone.Text);
                sqlCmd.Parameters.AddWithValue("@celular", TxtCelular.Text);

                DateTime dataNascimento;
                DateTime.TryParse(TxtDataNascimento.Text, out dataNascimento);

                sqlCmd.Parameters.AddWithValue("@data_nascimento", dataNascimento);

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro Realizado com Sucesso!!!");

                conexaoDB.Close();

                CarregarDadosAlunos();

            }
            catch (SqlException ex) 
            {
                MessageBox.Show($"Erro ao Inserir os Dados: {ex}");
            }
        }

        private void DgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                linhaSelecionada = DgvAlunos.Rows[e.RowIndex];

                TxtNome.Text = linhaSelecionada.Cells["Nome"].Value.ToString();
                TxtCpf.Text = linhaSelecionada.Cells["CPF"].Value.ToString();
                TxtEmail.Text = linhaSelecionada.Cells["E-mail"].Value.ToString();
                TxtTelefone.Text = linhaSelecionada.Cells["Telefone"].Value.ToString();
                TxtCelular.Text = linhaSelecionada.Cells["Celular"].Value.ToString();
                TxtDataNascimento.Text = linhaSelecionada.Cells["Data de Nascimento"].Value.ToString();
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(linhaSelecionada.Cells["ID Aluno"].Value.ToString());

                string sql = "UPDATE Alunos SET " +
                    "nome=@nome, " +
                    "cpf=@cpf, " +
                    "email=@email, " +
                    "telefone=@telefone, " +
                    "celular=@celular, " +
                    "data_nascimento=@data_nascimento " +
                    "WHERE id_aluno=@id_aluno";

                conexaoDB.Open();

                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                sqlCmd.Parameters.AddWithValue("@id_aluno", id);
                sqlCmd.Parameters.AddWithValue("@nome", TxtNome.Text);
                sqlCmd.Parameters.AddWithValue("@cpf", TxtCpf.Text);
                sqlCmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                sqlCmd.Parameters.AddWithValue("@telefone", TxtTelefone.Text);
                sqlCmd.Parameters.AddWithValue("@celular", TxtCelular.Text);

                DateTime dataNascimento; 
                DateTime.TryParse(TxtDataNascimento.Text , out dataNascimento);

                sqlCmd.Parameters.AddWithValue("@data_nascimento", dataNascimento);

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Atualização Realizada com Sucesso!");

                conexaoDB.Close();

                CarregarDadosAlunos();

            }
            catch(SqlException ex)
            {
                MessageBox.Show($"Erro ao Atulizar os Dados: {ex}");
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (linhaSelecionada != null)
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o aluno?", "Atençao!", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(linhaSelecionada.Cells["ID Aluno"].Value.ToString());

                        string sql = "DELETE FROM Alunos " +
                                    "WHERE id_aluno=@id_aluno";

                        conexaoDB.Open();

                        SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                        sqlCmd.Parameters.AddWithValue("@id_aluno", id);
                        sqlCmd.ExecuteNonQuery();

                        MessageBox.Show("O Aluno foi deletado com sucesso!");

                        conexaoDB.Close();

                        CarregarDadosAlunos();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Erro ao Excluir os Dados: {ex}");
                    }  
                }

            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            int id; 

            if(int.TryParse(TxtPesquisar.Text, out id))
            {
                CarregarDadosAlunos(id);
            }
            else
            {
                MessageBox.Show("Erro, id inválido!");
            }
        }
    }
}