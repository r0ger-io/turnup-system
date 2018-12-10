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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "SELECT USUARIO, SENHA FROM TB_LOGAR WHERE USUARIO = \'" + txtUsuario.Text + "\'";
                comando.CommandType = CommandType.Text;
                comando.Connection = conexao;
                SqlDataReader DR;
                DR = comando.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetValue(1).ToString() == txtSenha.Text)
                        {
                            this.Hide();
                            var tela_principal = new Tela_Principal(txtUsuario.Text);
                            tela_principal.Closed += (s, args) => this.Close();
                            tela_principal.Show();
                        }

                        if (DR.GetValue(1).ToString() != txtSenha.Text)
                        {
                            MessageBox.Show("Senha incorreta", "Aviso");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos", "Aviso");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtbox_Senha_MouseClick(object sender, MouseEventArgs e)
        {
            txtSenha.Clear();
        }

        private void txtnox_Usuario_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsuario.Clear();
        }

        public string Usuario
        {
            get
            {
                return txtUsuario.Text;
            }
        }
    }
}
