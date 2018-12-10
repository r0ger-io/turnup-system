using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCM_4_FUN
{
    public partial class Excluir_Aluno : Form
    {
        string delete;
        public Excluir_Aluno()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void Excluir_Aluno_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja deletar?", "Aviso", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlConnection conexao = new SqlConnection();
                    conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
                    conexao.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.CommandText = "DELETE FROM TB_ALUNO WHERE COD_ALUNO = " + delete.ToString() + ";";
                    comando.CommandType = CommandType.Text;
                    comando.Connection = conexao;
                    comando.ExecuteNonQuery();
                    conexao.Close();
                    AtualizaGrid();
                }
                catch
                {
                    SqlConnection conexao = new SqlConnection();
                    conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
                    conexao.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.CommandText = "DELETE FROM TB_ALUGUEL_LIVRO SELECT COD_ALUNO FROM TB_ALUGUEL WHERE COD_ALUNO = " + delete.ToString() + ";";
                    comando.CommandType = CommandType.Text;
                    comando.Connection = conexao;
                    SqlDataReader DR;
                    DR = comando.ExecuteReader();
                    DR.Read();
                    conexao.Close();

                    AtualizaGrid();

                    conexao.Open();
                    SqlCommand comando1 = new SqlCommand();
                    comando1.CommandText = "DELETE FROM TB_ALUGUEL WHERE COD_ALUNO = " + delete.ToString() + "; DELETE FROM TB_ALUNO_TURMA WHERE COD_ALUNO = " + delete.ToString() + "; DELETE FROM TB_BOLETIM WHERE COD_ALUNO = " + delete.ToString() + "; DELETE FROM TB_ALUNO WHERE COD_ALUNO = " + delete.ToString() + ";";
                    comando1.CommandType = CommandType.Text;
                    comando1.Connection = conexao;
                    comando1.ExecuteReader();
                    conexao.Close();
                    AtualizaGrid();
                }
            }
        }

        private void AtualizaGrid()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexao;
            comando.CommandText = "SELECT COD_ALUNO AS Código, NOME_ALUNO AS Nome, NASC_ALUNO AS 'Data de Nascimento', TELEFONE1 AS 'Telefone(1)', TELEFONE2 AS 'Telefone(2)', CELULAR AS 'Celular' FROM TB_ALUNO;";
            try
            {
                conexao.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = comando;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dgvAluno.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvAluno.Rows[e.RowIndex];
            delete = row.Cells["Código"].Value.ToString();
            textBox1.Text = delete.ToString();
        }

        private void dgvAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
