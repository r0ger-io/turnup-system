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
    public partial class Cadastro_Funcionario : Form
    {
        string fileName;
        public Cadastro_Funcionario()
        {
            InitializeComponent();
        }

        private void Cadastro_Prof_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grpSexo_Aluno_Enter(object sender, EventArgs e)
        {

        }

        private void txtNom_Prof_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_Prof_MouseClick(object sender, MouseEventArgs e)
        {
            txtNom_Prof.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtCep_Prof.Select(0, 0);
            }
         );
        }

        private void lbl_cep_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MouseClick(object sender, MouseEventArgs e)
        {
            txtSalario_Prof.Clear();
        }

        private void txtbox_Pais_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtbox_Orgao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_Orgao_MouseClick(object sender, MouseEventArgs e)
        {
            txtOrgao_Prof.Clear();
        }

        private void txtbox_Endereco_MouseClick(object sender, MouseEventArgs e)
        {
            txtEndereco_Prof.Clear();
        }

        private void txtbox_Comp_MouseClick(object sender, MouseEventArgs e)
        {
            txtComp_Prof.Clear();
        }

        private void txtbox_Cidade_MouseClick(object sender, MouseEventArgs e)
        {
            txtCidade_Prof.Clear();
        }

        private void txtbox_Grau_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtbox_Email_MouseClick(object sender, MouseEventArgs e)
        {
            txtEmail_Prof.Clear();
        }

        private void txtbox_Carteira_MouseClick(object sender, MouseEventArgs e)
        {
            txtCarteira_Prof.Clear();
        }

        private void txtbox_Grau_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtRg_Prof_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtRg_Prof.Select(0, 0);
            }
            );
        }

        private void txtCpf_Prof_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtCpf_Prof.Select(0, 0);
            }
          );
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCel_Prof_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtTel_Prof.Select(0, 0);
            }
         );
        }

        private void txtCel_Prof_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtCel_Prof.Select(0, 0);
            }
         );
        }

        private void maskedTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtEmer_Prof.Select(0, 0);
            }
         );
        }

        private void maskedTextBox4_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtCep_Prof.Select(0, 0);
            }
      );
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
                    picProf.Image = Image.FromFile(fileName);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            try
            {
                int whats;
                if (rdbWhatsSim_Prof.Checked == true)
                {
                    whats = 1;
                }
                else
                {
                    whats = 0;
                }
                int vt;
                if (rdbVTSim_Prof.Checked == true)
                {
                    vt = 1;
                }
                else
                {
                    vt = 0;
                }
                int vr;
                if (rdbVRSim_Prof.Checked == true)
                {
                    vr = 1;
                }
                else
                {
                    vr = 0;
                }
                char sexo = 'M';
                if (rdbMasc_Prof.Checked == true)
                {
                    sexo = 'M';
                }
                if (rdbFem_Prof.Checked == true)
                {
                    sexo = 'F';
                }
                Image myImage = Image.FromFile(fileName);
                byte[] data;
                using (MemoryStream ms = new MemoryStream())
                {
                    myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    data = ms.ToArray();
                }
                txtRg_Prof.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                txtCpf_Prof.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                txtCel_Prof.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                txtTel_Prof.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                txtEmer_Prof.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                txtCep_Prof.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                conexao.Open();
                using (SqlCommand comando = new SqlCommand("INSERT INTO TB_FUNCIONARIO (NOME_FUNC, EMAIL, FUNCAO_FUNC, NASC_FUNC, SEXO, SALARIO_FUNC, VALE_TRANSPORTE_FUNC, VALE_ALIMENTACAO_FUNC , NUM_CARTEIRA_TRABALHO, CAMINHO_IMG, IMG, TIPO_SALARIO, TELEFONE, CONTATO_EMERGENCIA, CELULAR, WHATSAPP, RG, CPF, ORGAO_EMISSOR, LOGRADOURO, NUMERO_LOGRA, COMPLEMENTO, CEP, CIDADE, UF, HORA_ENTRADA, HORA_SAIDA, TEMPO_ALMOCO) VALUES (\'" + txtNom_Prof.Text + "\',\'" + txtEmail_Prof.Text + "\',\'" + cmbFuncao_Prof.Text + "\',\'" + dtpNasc_Prof.Text + "\',\'" + sexo + "\'," + txtSalario_Prof.Text + "," + vt + "," + vr + "," + txtCarteira_Prof.Text + ",\'" + fileName + "\',@IM,\'" + cmbTipo_Salario.Text + "\'," + txtTel_Prof.Text + "," + txtEmer_Prof.Text + "," + txtCel_Prof.Text + "," + whats + ",\'" + txtRg_Prof.Text + "\'," + txtCpf_Prof.Text + ",\'" + txtOrgao_Prof.Text + "\',\'" + txtEndereco_Prof.Text + "\'," + txtNum_Prof.Text + ",\'" + txtComp_Prof.Text + "\'," + txtCep_Prof.Text + ",\'" + txtCidade_Prof.Text + "\',\'" + cmbUf_Prof.Text + "\',\'" + txtEntrada_Prof.Text + "\',\'" + txtSaida_Prof.Text + "\',\'" + txtAlmoco_Prof.Text + "\');", conexao))
                {
                    comando.Parameters.AddWithValue("@IM", data);
                    comando.ExecuteReader();
                    conexao.Close();
                    MessageBox.Show("Funcionário registrado com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                    ClearScreen();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCpf_Prof_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCancel_Prof_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void ClearScreen()
        {
            txtAlmoco_Prof.Clear();
            txtCarteira_Prof.Text = "N. Carteira De Trabalho";
            txtCel_Prof.Clear();
            txtCep_Prof.Clear();
            txtCidade_Prof.Text = "Cidade";
            txtCod_Func.Clear();
            txtComp_Prof.Text = "Complemento";
            txtCpf_Prof.Clear();
            txtEmail_Prof.Text = "Email";
            txtEmer_Prof.Clear();
            txtEndereco_Prof.Text = "Endereço";
            txtEntrada_Prof.Clear();
            txtNom_Prof.Text = "Nome";
            txtNum_Prof.Text = "Número";
            txtOrgao_Prof.Text = "Órgão Emissor";
            txtRg_Prof.Clear();
            txtSaida_Prof.Clear();
            txtSalario_Prof.Text = "Salário";
            txtTel_Prof.Clear();
            cmbFuncao_Prof.Text = "Cargo";
            cmbTipo_Salario.Text = "Tipo de Salário";
            cmbUf_Prof.Text = "UF";
            dtpNasc_Prof.Value = DateTime.Now;
            picProf.Image = null;
            rdbFem_Prof.Checked = false;
            rdbMasc_Prof.Checked = true;
            rdbVRNao_Prof.Checked = false;
            rdbVRSim_Prof.Checked = true;
            rdbVTNao_Prof.Checked = false;
            rdbVTSim_Prof.Checked = true;
            rdbWhatsNao_Prof.Checked = false;
            rdbWhatsSim_Prof.Checked = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNum_Prof_MouseClick(object sender, MouseEventArgs e)
        {
            txtNum_Prof.Clear();
        }

        private void txtEntrada_Prof_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtEntrada_Prof.Select(0, 0);
            }
         );
        }

        private void txtSaida_Prof_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtSaida_Prof.Select(0, 0);
            }
         );
        }

        private void txtAlmoco_Prof_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txtAlmoco_Prof_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtAlmoco_Prof.Select(0, 0);
            }
         );
        }

    }
}
