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
    public partial class Boletim : Form
    {
        string codigo_aluno;
        string codigo_func;
        public Boletim()
        {
            InitializeComponent();
        }

        private void Boletim_Load(object sender, EventArgs e)
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
                dgvAlunos.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlCommand comando1 = new SqlCommand();
            comando1.CommandType = CommandType.Text;
            comando1.Connection = conexao;
            comando1.CommandText = "SELECT NOME_TURMA FROM TB_TURMA;";
            SqlDataReader DR = comando1.ExecuteReader();
            while (DR.Read())
            {
                cmbNome_Turma.Items.Add(DR["NOME_TURMA"].ToString());
            }
            conexao.Close();
        }

        private void txtNom_Aluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_Aluno_MouseClick(object sender, MouseEventArgs e)
        {
            txtNom_Aluno.Clear();
        }

        private void cmbNome_Turma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAlunos.Rows[e.RowIndex];
                txtNom_Aluno.Text = row.Cells["Nome"].Value.ToString();
                codigo_aluno = row.Cells["Código"].Value.ToString();
            }
                
            }
            catch(Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            conexao.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = "SELECT COD_FUNC FROM TB_TURMA WHERE NOME_TURMA = \'" + cmbNome_Turma.Text + "\';";
            cmd.CommandType = CommandType.Text;
            SqlDataReader DR;
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                codigo_func = DR.GetValue(0).ToString();
            }
            conexao.Close();
            try
            {
                conexao.Open();
                using (SqlCommand comando = new SqlCommand("INSERT INTO TB_BOLETIM (COD_ALUNO, COD_FUNC, NOTA_PROVA_ESCRITA_1, NOTA_PROVA_ESCRITA_2, NOTA_PROVA_ESCRITA_3, NOTA_PROVA_ESCRITA_4, NOTA_PROVA_ORAL_1, NOTA_PROVA_ORAL_2, NOTA_PROVA_ORAL_3, NOTA_PROVA_ORAL_4, NOTA_PARTICIPACAO_1, NOTA_PARTICIPACAO_2) VALUES (" + codigo_aluno + ", " + codigo_func + ", " + txtEscrita1_Nota.Text + ", " + txtEscrita2_Nota.Text + ", " + txtEscrita3_Nota.Text + ", " + txtEscrita4_Nota.Text + ", " + txtOral1_Nota.Text + ", " + txtOral2_Nota.Text + ", " + txtOral4_Nota.Text + ", " + txtOral4_Nota.Text + ", " + txtParticipacao1_Nota.Text + ", " + txtParticipacao2_Nota.Text + ");", conexao))
                {
                    comando.ExecuteReader();
                    conexao.Close();
                    MessageBox.Show("Boletim registrado com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                    ClearScreen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void ClearScreen()
        {
            txtEscrita1_Nota.Clear();
            txtEscrita2_Nota.Clear();
            txtEscrita3_Nota.Clear();
            txtEscrita4_Nota.Clear();
            txtOral1_Nota.Clear();
            txtOral2_Nota.Clear();
            txtOral3_Nota.Clear();
            txtOral4_Nota.Clear();
            txtParticipacao1_Nota.Clear();
            txtParticipacao2_Nota.Clear();
        }
    }
}
