using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCM_4_FUN
{
    public partial class Tela_Principal : Form
    {

        public Tela_Principal(string usuario)
        {
            InitializeComponent();
            tslUsuario.Text = usuario;
        }
        
        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Cadastro_Aluno myForm = new Cadastro_Aluno();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void pnlApp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Cadastro_Funcionario myForm = new Cadastro_Funcionario();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Cadastro_Livro myForm = new Cadastro_Livro();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Cadastro_turma myForm = new Cadastro_turma();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void tsbCadastro_Click(object sender, EventArgs e)
        {

        }

        private void controleLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            {
                panel.Controls.Clear();
                Cadastro_Aluno myForm = new Cadastro_Aluno();
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                panel.Controls.Add(myForm);
                myForm.Show();
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            {
                panel.Controls.Clear();
                Cadastro_turma myForm = new Cadastro_turma();
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                panel.Controls.Add(myForm);
                myForm.Show();
            }
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            {
                panel.Controls.Clear();
                Cadastro_Livro myForm = new Cadastro_Livro();
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                panel.Controls.Add(myForm);
                myForm.Show();
            }
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            {
                panel.Controls.Clear();
                Cadastro_Funcionario myForm = new Cadastro_Funcionario();
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                panel.Controls.Add(myForm);
                myForm.Show();
            }
        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {
            {
                panel.Controls.Clear();
                Tela_Principal myForm = new Tela_Principal(tslUsuario.Text);
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                panel.Controls.Add(myForm);
                myForm.Show();
            }
        }

        private void telaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                var tela_principal = new Tela_Principal(tslUsuario.Text);
                tela_principal.Closed += (s, args) => this.Close();
                tela_principal.Show();
            }
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            {
                panel.Controls.Clear();
                Boletim myForm = new Boletim();
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                panel.Controls.Add(myForm);
                myForm.Show();
            }
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            {
                panel.Controls.Clear();
                Controle_Livro myForm = new Controle_Livro();
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                panel.Controls.Add(myForm);
                myForm.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Boletim myForm = new Boletim();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void tmrTempo_Tick(object sender, EventArgs e)
        {
            tslTempo.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Testes myForm = new Testes();
            myForm.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            Test_Image myForm = new Test_Image();
            myForm.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Alterar_Aluno myForm = new Alterar_Aluno();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tslUsuario_Click(object sender, EventArgs e)
        {

        }

        private void tslTempo_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Alterar_Aluno myForm = new Alterar_Aluno();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void pictureBox6_Click_2(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Excluir_Aluno myForm = new Excluir_Aluno();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boletimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Excluir_Aluno myForm = new Excluir_Aluno();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Cadastro_Funcionario myForm = new Cadastro_Funcionario();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void aluguelLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Controle_Livro myForm = new Controle_Livro();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void boletimToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Boletim myForm = new Boletim();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
