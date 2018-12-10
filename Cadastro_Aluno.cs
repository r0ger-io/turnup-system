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
using System.Text.RegularExpressions;
using System.IO;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace TCM_4_FUN
{
    public partial class Cadastro_Aluno : Form
    {
        string fileName;
        public Cadastro_Aluno()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRg_Aluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_Aluno_TextChanged(object sender, EventArgs e)
        {
            //item requerido
        }

        private void txtbox_responsavel_TextChanged(object sender, EventArgs e)
        {
            //item não requerido
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Aluno_Load(object sender, EventArgs e)
        {
            
        }

        private void cbox_periodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //matutino
            //vespertino
            //noturno
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // períodos dos curso
            //segunda e quarta
            //quarta e sexta
            //terça e quinta
            //sábado
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_Aluno_MouseClick(object sender, MouseEventArgs e)
        {
            txtNom_Aluno.Clear();
        }

        private void txtbox_responsavel_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtbox_paisM_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtbox_endM_MouseClick(object sender, MouseEventArgs e)
        {
            txtEndereco_Aluno.Clear();
        }

        private void txtbox_compM_MouseClick(object sender, MouseEventArgs e)
        {
            txtComp_Aluno.Clear();
        }

        private void txtbox_cidadeM_MouseClick(object sender, MouseEventArgs e)
        {
            txtCidade_Aluno.Clear();
        }

        private void rtxtbox_obs_MouseClick(object sender, MouseEventArgs e)
        {
            txtObs_Aluno.Clear();
        }

        private void txtRg_Aluno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }

        private void txtRg_Aluno_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtRg_Aluno.Select(0, 0);
            }
         );
        }

        private void txtCpf_Aluno_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtCpf_Aluno.Select(0, 0);
            }
         );
        }

        private void txtCel_ALuno_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtCel_Aluno.Select(0, 0);
            }
         );
        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtTel1_Aluno.Select(0, 0);
            }
         );
        }

        private void maskedTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtTel2_Aluno.Select(0, 0);
            }
         );
        }

        private void maskedTextBox3_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtCep_Aluno.Select(0, 0);
            }
         );
        }

        private void bt_buscarm_Click(object sender, EventArgs e)
        {

        }

        private void gbox_curso_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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
                using(MemoryStream ms = new MemoryStream())
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
                using (SqlCommand comando = new SqlCommand("INSERT INTO TB_ALUNO (NOME_ALUNO, NASC_ALUNO, SEXO_ALUNO, PLANO_SAUDE, OBSERVACAO_MEDICA, CAMINHO_IMG, IMG, TELEFONE1, TELEFONE2, CELULAR, RG, CPF, ORGAO_EMISSOR, LOGRADOURO, NUMERO_LOGRA, COMPLEMENTO, CEP, CIDADE, UF) VALUES (\'" + txtNom_Aluno.Text + "\',\'" + dtpNasc_Aluno.Text + "\',\'" + sexo + "\'," + plano + ",\'" + txtObs_Aluno.Text + "\',\'" + fileName + "\', @IM," + txtTel1_Aluno.Text + "," + txtTel2_Aluno.Text + "," + txtCel_Aluno.Text + ",\'" + txtRg_Aluno.Text + "\'," + txtCpf_Aluno.Text + ",\'" + txtOrgao_Aluno.Text + "\',\'" + txtEndereco_Aluno.Text + "\'," + txtNum_Aluno.Text + ",\'" + txtComp_Aluno.Text + "\'," + txtCep_Aluno.Text + ",\'" + txtCidade_Aluno.Text + "\',\'" + cmbUf_Aluno.Text + "\');", conexao))
                {
                    comando.Parameters.AddWithValue("@IM", data);
                    comando.ExecuteReader();
                    conexao.Close();
                    MessageBox.Show("Aluno registrado com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                    Clear_Screen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Clear_Screen();
        }

        private void gb_medic_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void dtpNasc_Aluno_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCod_Aluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_Aluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum_Aluno_MouseClick(object sender, MouseEventArgs e)
        {
            txtNum_Aluno.Clear();
        }

        private void Clear_Screen()
        {
            txtCel_Aluno.Clear();
            txtCep_Aluno.Clear();
            txtCidade_Aluno.Text = "Cidade";
            txtCod_Aluno.Clear();
            txtComp_Aluno.Text = "Complemento";
            txtCpf_Aluno.Clear();
            txtEndereco_Aluno.Text = "Endereço";
            txtMatricula_Aluno.Clear();
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
