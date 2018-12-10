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
    public partial class Testes : Form
    {
        public Testes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM TB_LOGAR WHERE USUARIO = \'" + txtSelect.Text + "\';";
            try
            {
                conexao.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = comando;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "INSERT INTO TB_LOGAR VALUES (\'" + txtLogin_Novo.Text + "\',\'" + txtSenha_Novo.Text + "\');";
            comando.CommandType = CommandType.Text;
            comando.Connection = conexao;
            SqlDataReader DR;
            DR = comando.ExecuteReader();
            conexao.Close();
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM TB_LOGAR;";
            try
            {
                conexao.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = comando;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "UPDATE TB_LOGAR SET SENHA = \'" + txtEsqueci_Senha.Text + "\' WHERE USUARIO = \'" + txtEsqueci_Login.Text + "\';";
            comando.CommandType = CommandType.Text;
            comando.Connection = conexao;
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtClick_Login.Text = row.Cells["USUARIO"].Value.ToString();
                txtClick_Senha.Text = row.Cells["SENHA"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.DB_TCM_OutturnConnectionString;
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "DELETE FROM TB_LOGAR WHERE USUARIO = \'" + txtDelete.Text + "\';";
            comando.CommandType = CommandType.Text;
            comando.Connection = conexao;
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        private void btnJojy_Click(object sender, EventArgs e)
        {
            
        }
    }
}
