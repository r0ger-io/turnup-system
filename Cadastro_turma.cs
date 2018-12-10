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

namespace TCM_4_FUN
{
    public partial class Cadastro_turma : Form
    {
        int dia_semana = 1;
        string cod_func;
        public Cadastro_turma()
        {
            InitializeComponent();
        }

        private void cbox_periodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Calendario_turma_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void cbbox_dataturma_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Cadastro_turma_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexao;
            comando.CommandText = "SELECT COD_FUNC AS Código, NOME_FUNC AS Nome, NASC_FUNC AS 'Data de Nascimento', TELEFONE AS 'Telefone', CONTATO_EMERGENCIA AS 'Telefone de Emergência', CELULAR AS 'Celular', LOGRADOURO AS 'Endereço', NUMERO_LOGRA AS Número, COMPLEMENTO AS Complemento, CEP, CIDADE AS Cidade, UF FROM TB_FUNCIONARIO;";
            try
            {
                conexao.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = comando;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dgvTurma.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtb_vagas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_matriculados_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbox_tipocurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ingles
            //espanhol
            //françes
            //italiano
        }

        private void mtxtbox_Descricao_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void mtxtbox_Descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_turma_Activated(object sender, EventArgs e)
        {
            
        }

        private void txtb_vagas_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbDom_Turma.Checked == true)
            {
                dia_semana *= 2;
            }
            else 
            {
                dia_semana /= 2;
            }
        }

        private void ckbSeg_Turma_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSeg_Turma.Checked == true)
            {
                dia_semana *= 3;
            }
            else
            {
                dia_semana /= 3;
            }
        }

        private void ckbTer_Turma_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTer_Turma.Checked == true)
            {
                dia_semana *= 5;
            }
            else
            {
                dia_semana /= 5;
            }
        }

        private void ckbQua_Turma_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbQua_Turma.Checked == true)
            {
                dia_semana *= 7;
            }
            else
            {
                dia_semana /= 7;
            }
        }

        private void ckbQui_Turma_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbQui_Turma.Checked == true)
            {
                dia_semana *= 11;
            }
            else
            {
                dia_semana /= 11;
            }
        }

        private void ckbSex_Turma_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSex_Turma.Checked == true)
            {
                dia_semana *= 13;
            }
            else
            {
                dia_semana /= 13;
            }
        }

        private void ckbSab_Turma_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSab_Turma.Checked == true)
            {
                dia_semana *= 17;
            }
            else
            {
                dia_semana /= 17;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Turma_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "INSERT INTO TB_TURMA (COD_FUNC, NOME_TURMA, DISCIPLINA, DIA_TURMA, DATA_INI, DATA_FIN) VALUES (" + cod_func + ",\'" + txtNome_Turma.Text + "\',\'" + cmbCurso_Turma.Text + "\'," + dia_semana + ",\'" + dtpInicio_Turma.Text + "\',\'" + dtpTermino_Turma.Text + "\');";
            comando.CommandType = CommandType.Text;
            comando.Connection = conexao;
            SqlDataReader DR;
            DR = comando.ExecuteReader();
            DR.Read();
            conexao.Close();
            MessageBox.Show("Turma registrada com sucesso!", "Sucesso!", MessageBoxButtons.OK);
            ClearScreen();
        }

        private void ClearScreen()
        {
            txtNome_Turma.Text = "Nome da Turma";
            cmbCurso_Turma.Text = "Tipo do Curso";
            ckbDom_Turma.Checked = false;
            ckbQua_Turma.Checked = false;
            ckbQui_Turma.Checked = false;
            ckbSab_Turma.Checked = false;
            ckbSeg_Turma.Checked = false;
            ckbSex_Turma.Checked = false;
            ckbTer_Turma.Checked = false;
            dtpInicio_Turma.Value = DateTime.Now;
            dtpTermino_Turma.Value = DateTime.Now;
            dia_semana = 1;
            cod_func = null;
        }
        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtNome_Turma.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTurma.Rows[e.RowIndex];
                cod_func = row.Cells["Código"].Value.ToString();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Turma_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }
    }
}
