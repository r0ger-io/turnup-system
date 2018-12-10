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
using System.IO;

namespace TCM_4_FUN
{
    public partial class Controle_Livro : Form
    {
        string filtroLivro;
        string filtroAluno;
        string cod_aluno;
        string cod_livro;
        public Controle_Livro()
        {
            InitializeComponent();
        }

        private void txtbox_codlivro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_rm_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpbox_alunolivro_Enter(object sender, EventArgs e)
        {

        }

        private void txtbox_nomelivro_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtbox_autor_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtbox_editora_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lbl_assunto_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtbox_idioma_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtbox_nomealun_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtbox_rm_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Controle_Livro_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexao;
            comando.CommandText = "SELECT COD_LIVRO AS Código, NOME_LIVRO AS Nome, AUTOR_LIVRO AS 'Autor(es)', EDITORA_LIVRO AS Editora, ASSUNTO_LIVRO AS ASSUNTO, IDIOMA_LIVRO AS Idioma, CAMINHO_IMG AS Capa FROM TB_LIVRO;";
            try
            {
                conexao.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = comando;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dgvLivro.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conexao.Close();
            SqlCommand comando1 = new SqlCommand();
            comando1.CommandType = CommandType.Text;
            comando1.Connection = conexao;
            comando1.CommandText = "SELECT COD_ALUNO AS Código, NOME_ALUNO AS Nome, NASC_ALUNO AS 'Data de Nascimento', SEXO_ALUNO AS Sexo, PLANO_SAUDE AS 'Plano de Saúde', OBSERVACAO_MEDICA AS 'Observação Médica', TELEFONE1 AS 'Telefone(1)', TELEFONE2 AS 'Telefone(2)', CELULAR AS 'Celular', RG, CPF, ORGAO_EMISSOR AS 'Órgão Emissor', LOGRADOURO AS 'Endereço', NUMERO_LOGRA AS Número, COMPLEMENTO AS Complemento, CEP, CIDADE AS Cidade, UF FROM TB_ALUNO;";
            try
            {
                conexao.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = comando1;
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

        private void bt_salvar_Click(object sender, EventArgs e)
        {

        }

        private void dgvLivro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow coluna = this.dgvLivro.Rows[e.RowIndex];
            cod_livro = coluna.Cells["Código"].Value.ToString();
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_TCM_OutturnConnectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT IMG FROM TB_LIVRO WHERE COD_LIVRO = " + cod_livro.ToString() + "", con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        try
                        {
                            reader.Read();
                            picCapa.Image = ByteArrayToImage((byte[])(reader.GetValue(0)));
                        }
                        catch
                        {
                            picCapa.Image = null;
                            MessageBox.Show("Capa do Livro não registrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                ms.Seek(0, SeekOrigin.Begin);
                Bitmap bmp = new Bitmap(ms);
                return bmp;
            }
        }


        private void dgvAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSelect_Livro_Click(object sender, EventArgs e)
        {
            if (cmbFiltro_Livro.Text.Equals("Código"))
            {
                filtroLivro = "COD_LIVRO";
            }
            else if (cmbFiltro_Livro.Text.Equals("Nome"))
            {
                filtroLivro = "NOME_LIVRO";
            }
            else if (cmbFiltro_Livro.Text.Equals("Autor"))
            {
                filtroLivro = "AUTOR_LIVRO";
            }
            else
            {
                filtroLivro = "NOME_LIVRO";
            }
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexao;
            comando.CommandText = "SELECT COD_LIVRO AS Código, NOME_LIVRO AS Nome, AUTOR_LIVRO AS 'Autor(es)', EDITORA_LIVRO AS Editora, ASSUNTO_LIVRO AS ASSUNTO, IDIOMA_LIVRO AS Idioma, CAMINHO_IMG AS Capa FROM TB_LIVRO WHERE " + filtroLivro + " LIKE \'%" + txtSelect_Livro.Text + "%\';";
            try
            {
                conexao.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = comando;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dgvLivro.DataSource = bSource;
                sda.Update(dbdataset);
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelect_Aluno_Click(object sender, EventArgs e)
        {
            if (cmbFiltro_Aluno.Text.Equals("Código"))
            {
                filtroAluno = "COD_ALUNO";
            }
            else if (cmbFiltro_Aluno.Text.Equals("Nome"))
            {
                filtroAluno= "NOME_ALUNO";
            }
            else
            {
                filtroAluno = "NOME_ALUNO";
            }
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexao;
            comando.CommandText = "SELECT COD_ALUNO AS Código, NOME_ALUNO AS Nome, NASC_ALUNO AS 'Data de Nascimento', SEXO_ALUNO AS Sexo, PLANO_SAUDE AS 'Plano de Saúde', OBSERVACAO_MEDICA AS 'Observação Médica', TELEFONE1 AS 'Telefone(1)', TELEFONE2 AS 'Telefone(2)', CELULAR AS 'Celular', RG, CPF, ORGAO_EMISSOR AS 'Órgão Emissor', LOGRADOURO AS 'Endereço', NUMERO_LOGRA AS Número, COMPLEMENTO AS Complemento, CEP, CIDADE AS Cidade, UF FROM TB_ALUNO WHERE " + filtroAluno + " LIKE \'%" + txtSelect_Aluno.Text + "%\';";
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
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow coluna = this.dgvAluno.Rows[e.RowIndex];
            cod_aluno = coluna.Cells["Código"].Value.ToString();
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_TCM_OutturnConnectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT IMG FROM TB_ALUNO WHERE COD_ALUNO = " + cod_aluno.ToString() + ";", con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        try
                        {
                            reader.Read();
                            picAluno.Image = ByteArrayToImage((byte[])(reader.GetValue(0)));
                        }
                        catch
                        {
                            picAluno.Image = null;
                            MessageBox.Show("Imagem do Aluno não existente", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string aluguel = Convert.ToString(dtpAluguel.Value.Date);
            string devolucao = Convert.ToString(dtpDevolucao.Value.Date);
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexao;
            comando.CommandText = "INSERT INTO TB_ALUGUEL(DATA_ALUGUEL, DATA_DEVOLUCAO, COD_ALUNO) VALUES (\'" + aluguel + "\',\'" + devolucao + "\', " + cod_aluno + "); INSERT INTO TB_ALUGUEL_LIVRO(COD_ALUGUEL, COD_LIVRO) SELECT (SELECT TOP(1) COD_ALUGUEL FROM TB_ALUGUEL ORDER BY 1 DESC),(SELECT " + cod_livro + ");";
            conexao.Open();
            SqlDataReader DR;
            DR = comando.ExecuteReader();
            DR.Read();
            conexao.Close();
            MessageBox.Show("Aluguel registrado com sucesso!", "Sucesso!", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void ClearScreen()
        {
            cod_aluno = null;
            cod_livro = null;
            txtSelect_Aluno.Clear();
            txtSelect_Livro.Clear();
            cmbFiltro_Aluno.Text = "Filtrar";
            cmbFiltro_Livro.Text = "Filtrar";
            txtSelect_Aluno.Clear();
            txtSelect_Livro.Clear();
            dtpAluguel.Value = DateTime.Now;
            dtpDevolucao.Value = DateTime.Now;
            picAluno.Image = null;
            picCapa.Image = null;
        }
    }
}
