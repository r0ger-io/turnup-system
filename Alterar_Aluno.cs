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
    public partial class Alterar_Aluno : Form
    {
        string filtro;
        string fileName;
        string delete;
        public Alterar_Aluno()
        {
            InitializeComponent();
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Alterar_Funcionario_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexao;
            comando.CommandText = "SELECT COD_ALUNO AS Código, NOME_ALUNO AS Nome, NASC_ALUNO AS 'Data de Nascimento', SEXO_ALUNO AS Sexo, PLANO_SAUDE AS 'Plano de Saúde', OBSERVACAO_MEDICA AS 'Observação Médica', TELEFONE1 AS 'Telefone(1)', TELEFONE2 AS 'Telefone(2)', CELULAR AS 'Celular', RG, CPF, ORGAO_EMISSOR AS 'Órgão Emissor', LOGRADOURO AS 'Endereço', NUMERO_LOGRA AS Número, COMPLEMENTO AS Complemento, CEP, CIDADE AS Cidade, UF FROM TB_ALUNO;";
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

        private void AtualizaGrid()
        {
            if (cmbFiltro.Text.Equals("Código"))
            {
                filtro = "COD_ALUNO";
            }
            else if (cmbFiltro.Text.Equals("Nome"))
            {
                filtro = "NOME_ALUNO";
            }
            else if (cmbFiltro.Text.Equals("Plano de Saúde"))
            {
                filtro = "PLANO_SAUDE";
            }
            else if (cmbFiltro.Text.Equals("Sexo"))
            {
                filtro = "SEXO_ALUNO";
            }
            else
            {
                filtro = "NOME_ALUNO";
            }
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexao;
            comando.CommandText = "SELECT COD_ALUNO AS Código, NOME_ALUNO AS Nome, NASC_ALUNO AS 'Data de Nascimento', SEXO_ALUNO AS Sexo, PLANO_SAUDE AS 'Plano de Saúde', OBSERVACAO_MEDICA AS 'Observação Médica', TELEFONE1 AS 'Telefone(1)', TELEFONE2 AS 'Telefone(2)', CELULAR AS 'Celular', RG, CPF, ORGAO_EMISSOR AS 'Órgão Emissor', LOGRADOURO AS 'Endereço', NUMERO_LOGRA AS Número, COMPLEMENTO AS Complemento, CEP, CIDADE AS Cidade, UF FROM TB_ALUNO WHERE " + filtro + " LIKE \'%" + txtSelect.Text + "%\';";
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void Clear_Screen()
        {
            txtCel_Aluno.Clear();
            txtCep_Aluno.Clear();
            txtCidade_Aluno.Text = "Cidade";
            txtComp_Aluno.Text = "Complemento";
            txtCpf_Aluno.Clear();
            txtEndereco_Aluno.Text = "Endereço";
            txtNom_Aluno.Text = "Nome Completo";
            txtNum_Aluno.Text = "Número";
            txtObs_Aluno.Text = "Observaçoes Médicas";
            txtOrgao_Aluno.Clear();
            txtRg_Aluno.Clear();
            txtTel1_Aluno.Clear();
            txtTel2_Aluno.Clear();
            cmbUf_Aluno.Text = "UF";
            picAluno.Image = null;
            dtpNasc_Aluno.Value = DateTime.Now;
            rbPlanoNao_Aluno.Checked = false;
            rbPlanoSim_Aluno.Checked = true;
            rdbFem_Aluno.Checked = false;
            rdbMasc_Aluno.Checked = true;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja atualizar?","Aviso",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
                try
                {
                    char sexo = 'M';
                    if (rdbMasc_Aluno.Checked == true)
                    {
                        sexo = 'M';
                    }
                    if (rdbFem_Aluno.Checked == true)
                    {
                        sexo = 'F';
                    }
                    int plano = 0;
                    if (rbPlanoSim_Aluno.Checked == true)
                    {
                        plano = 1;
                    }
                    if (rbPlanoNao_Aluno.Checked == true)
                    {
                        plano = 0;
                    }
                    Image myImage = Image.FromFile(fileName);
                    byte[] data;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        data = ms.ToArray();
                    }
                    txtRg_Aluno.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    txtCpf_Aluno.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    txtCel_Aluno.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    txtTel1_Aluno.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    txtTel2_Aluno.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    txtCep_Aluno.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    conexao.Open();
                    using (SqlCommand comando = new SqlCommand("UPDATE TB_ALUNO SET NOME_ALUNO = \'" + txtNom_Aluno.Text + "\', NASC_ALUNO = \'" + dtpNasc_Aluno.Text + "\', SEXO_ALUNO = \'" + sexo + "\', PLANO_SAUDE = " + plano + ", OBSERVACAO_MEDICA = \'" + txtObs_Aluno.Text + "\', CAMINHO_IMG = \'" + fileName + "\', IMG = (@IM), TELEFONE1 = " + txtTel1_Aluno.Text + ", TELEFONE2 = " + txtTel2_Aluno.Text + ", CELULAR = " + txtCel_Aluno.Text + ", RG = " + txtRg_Aluno.Text + ", CPF = " + txtCpf_Aluno.Text + ", ORGAO_EMISSOR = \'" + txtOrgao_Aluno.Text + "\', LOGRADOURO = \'" + txtEndereco_Aluno.Text + "\', NUMERO_LOGRA = " + txtNum_Aluno.Text + ", COMPLEMENTO = \'" + txtComp_Aluno.Text + "\', CEP = " + txtCep_Aluno.Text + ", CIDADE = \'" + txtCidade_Aluno.Text + "\', UF = \'" + cmbUf_Aluno.Text + "\' WHERE COD_ALUNO = " + delete.ToString() + ";", conexao))
                    {
                        if (data == null)
                        {
                            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_TCM_OutturnConnectionString))
                            using (SqlCommand cmd = new SqlCommand("SELECT IMG FROM TB_ALUNO WHERE COD_ALUNO = " + delete.ToString() + ";", con))
                            {
                                con.Open();
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.HasRows)
                                    {
                                        reader.Read();
                                        Image img;
                                        img = ByteArrayToImage((byte[])(reader.GetValue(0)));
                                        comando.Parameters.AddWithValue("@IM", img);
                                        comando.ExecuteReader();
                                        conexao.Close();
                                        MessageBox.Show("Aluno atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                                    }
                                }
                            }
                        }
                        else
                        {
                            comando.Parameters.AddWithValue("@IM", data);
                            comando.ExecuteReader();
                            conexao.Close();
                            MessageBox.Show("Aluno atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                        }
                        AtualizaGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
            DataGridViewRow coluna = this.dgvAluno.Rows[e.RowIndex];
            delete = coluna.Cells["Código"].Value.ToString();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAluno.Rows[e.RowIndex];
                txtCel_Aluno.Text = row.Cells["Celular"].Value.ToString();
                txtCep_Aluno.Text = row.Cells["CEP"].Value.ToString();
                txtCidade_Aluno.Text = row.Cells["Cidade"].Value.ToString();
                txtComp_Aluno.Text = row.Cells["Complemento"].Value.ToString();
                txtCpf_Aluno.Text = row.Cells["CPF"].Value.ToString();
                txtEndereco_Aluno.Text = row.Cells["Endereço"].Value.ToString();
                txtNom_Aluno.Text = row.Cells["Nome"].Value.ToString();
                txtNum_Aluno.Text = row.Cells["Número"].Value.ToString();
                txtObs_Aluno.Text = row.Cells["Observação Médica"].Value.ToString();
                txtOrgao_Aluno.Text = row.Cells["Órgão Emissor"].Value.ToString();
                txtRg_Aluno.Text = row.Cells["RG"].Value.ToString();
                txtTel1_Aluno.Text = row.Cells["Telefone(1)"].Value.ToString();
                txtTel2_Aluno.Text = row.Cells["Telefone(2)"].Value.ToString();
                cmbUf_Aluno.Text = row.Cells["UF"].Value.ToString();
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_TCM_OutturnConnectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT IMG FROM TB_ALUNO WHERE COD_ALUNO = " + delete.ToString() + "", con))
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
                                MessageBox.Show("Imagem do Aluno não existente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                dtpNasc_Aluno.Text = row.Cells["Data de Nascimento"].Value.ToString();
                if(row.Cells["Plano de Saúde"].Value.Equals(true))
                {
                    rbPlanoSim_Aluno.Checked = true;
                    rbPlanoNao_Aluno.Checked = false;
                }
                else
                {
                    rbPlanoNao_Aluno.Checked = true;
                    rbPlanoSim_Aluno.Checked = false;
                }
                if (row.Cells["Sexo"].Value.Equals("M"))
                {
                    rdbFem_Aluno.Checked = false;
                    rdbMasc_Aluno.Checked = true;
                }
                else
                {
                    rdbFem_Aluno.Checked = true;
                    rdbMasc_Aluno.Checked = false;
                }
                
            }
                
            }
            catch(Exception ex)
            {
                    MessageBox.Show("");
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
        private void tmrAtualiza_Tick(object sender, EventArgs e)
        {
            
        }

        private void txtNome_Func_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnInserir_Aluno_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "JPG|*.jpg;*.jpeg|PNG|*.png",
                ValidateNames = true,
                Multiselect = false
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    picAluno.Image = Image.FromFile(fileName);
                }
            }
        }

        private void dgvAluno_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja deletar?","Aviso",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
                conexao.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexao;
                comando.CommandText = "DELETE FROM TB_ALUNO WHERE COD_ALUNO = " + delete.ToString() + ";";
                SqlDataReader DR;
                DR = comando.ExecuteReader();
                DR.Read();
                AtualizaGrid();
            }
        }
    }
}
