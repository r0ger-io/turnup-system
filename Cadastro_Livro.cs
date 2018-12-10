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
    public partial class Cadastro_Livro : Form
    {
        string fileName;
        public Cadastro_Livro()
        {
            InitializeComponent();
        }

        private void Cadastro_Livro_Load(object sender, EventArgs e)
        {

        }

        private void txtCod_Livro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_nomelivro_MouseClick(object sender, MouseEventArgs e)
        {
            txtNome_Livro.Clear();
        }

        private void txtbox_autor_MouseClick(object sender, MouseEventArgs e)
        {
            txtAutor_Livro.Clear();
        }

        private void txtbox_editora_MouseClick(object sender, MouseEventArgs e)
        {
            txtEditora_Livro.Clear();
        }

        private void lbl_assunto_MouseClick(object sender, MouseEventArgs e)
        {
            txtAssunto_Livro.Clear();
        }

        private void txtbox_idioma_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdioma_Livro.Clear();
        }

        private void rtxtbox_prefacio_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrefacio_Livro.Clear();
        }

        private void bt_inserir_Click(object sender, EventArgs e)
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
                    picCapa_Livro.Image = Image.FromFile(fileName);
                }
            }
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            try
            {
                Image myImage = Image.FromFile(fileName);
                byte[] data;
                using (MemoryStream ms = new MemoryStream())
                {
                    myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    data = ms.ToArray();
                }
                conexao.Open();
                using (SqlCommand comando = new SqlCommand("INSERT INTO TB_LIVRO (NOME_LIVRO, AUTOR_LIVRO, EDITORA_LIVRO, ASSUNTO_LIVRO, IDIOMA_LIVRO, CAMINHO_IMG, IMG) VALUES (\'" + txtNome_Livro.Text + "\',\'" + txtAutor_Livro.Text + "\',\'" + txtEditora_Livro.Text + "\',\'" + txtAssunto_Livro.Text + "\',\'" + txtIdioma_Livro.Text + "\',\'" + fileName + "\', @IM);", conexao))
                {
                    comando.Parameters.AddWithValue("@IM", data);
                    comando.ExecuteReader();
                    conexao.Close();
                    MessageBox.Show("Livro registrado com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                    ClearScreen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }
        private void ClearScreen()
        {
            txtCod_Livro.Clear();
            txtEditora_Livro.Text = "Editora";
            txtIdioma_Livro.Text = "Idioma";
            txtNome_Livro.Text = "Nome do Livro";
            txtPrefacio_Livro.Text = "Prefácio do Livro";
            txtAssunto_Livro.Text = "Assunto";
            txtAutor_Livro.Text = "Autor(es)";
            picCapa_Livro.Image = null;
        }
    }
}
