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
        
        private void CarregarDadosAlunos()
        {
            try
            {
                conexaoDB.Open();
                string sql = "SELECT * FROM Alunos";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexaoDB);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

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
    }
}