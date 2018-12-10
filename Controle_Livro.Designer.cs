namespace TCM_4_FUN
{
    partial class Controle_Livro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.gpbox_consulta = new System.Windows.Forms.GroupBox();
            this.cmbFiltro_Livro = new System.Windows.Forms.ComboBox();
            this.btnSelect_Livro = new System.Windows.Forms.Button();
            this.txtSelect_Livro = new System.Windows.Forms.TextBox();
            this.dgvLivro = new System.Windows.Forms.DataGridView();
            this.gpbox_alunolivro = new System.Windows.Forms.GroupBox();
            this.cmbFiltro_Aluno = new System.Windows.Forms.ComboBox();
            this.btnSelect_Aluno = new System.Windows.Forms.Button();
            this.txtSelect_Aluno = new System.Windows.Forms.TextBox();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.picCapa = new System.Windows.Forms.PictureBox();
            this.picAluno = new System.Windows.Forms.PictureBox();
            this.dtpAluguel = new System.Windows.Forms.DateTimePicker();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.lbl_dataaluguel = new System.Windows.Forms.Label();
            this.lb_devolução = new System.Windows.Forms.Label();
            this.gpbox_aluguel = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gpbox_consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).BeginInit();
            this.gpbox_alunolivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAluno)).BeginInit();
            this.gpbox_aluguel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(631, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gpbox_consulta
            // 
            this.gpbox_consulta.BackColor = System.Drawing.Color.Transparent;
            this.gpbox_consulta.Controls.Add(this.cmbFiltro_Livro);
            this.gpbox_consulta.Controls.Add(this.btnSelect_Livro);
            this.gpbox_consulta.Controls.Add(this.txtSelect_Livro);
            this.gpbox_consulta.Controls.Add(this.dgvLivro);
            this.gpbox_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbox_consulta.Location = new System.Drawing.Point(12, 12);
            this.gpbox_consulta.Name = "gpbox_consulta";
            this.gpbox_consulta.Size = new System.Drawing.Size(423, 250);
            this.gpbox_consulta.TabIndex = 5;
            this.gpbox_consulta.TabStop = false;
            this.gpbox_consulta.Text = "Consultar livro";
            // 
            // cmbFiltro_Livro
            // 
            this.cmbFiltro_Livro.FormattingEnabled = true;
            this.cmbFiltro_Livro.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "Autor"});
            this.cmbFiltro_Livro.Location = new System.Drawing.Point(6, 19);
            this.cmbFiltro_Livro.Name = "cmbFiltro_Livro";
            this.cmbFiltro_Livro.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltro_Livro.TabIndex = 9;
            this.cmbFiltro_Livro.Text = "Filtrar";
            // 
            // btnSelect_Livro
            // 
            this.btnSelect_Livro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect_Livro.Location = new System.Drawing.Point(321, 19);
            this.btnSelect_Livro.Name = "btnSelect_Livro";
            this.btnSelect_Livro.Size = new System.Drawing.Size(75, 23);
            this.btnSelect_Livro.TabIndex = 8;
            this.btnSelect_Livro.Text = "Procurar";
            this.btnSelect_Livro.UseVisualStyleBackColor = true;
            this.btnSelect_Livro.Click += new System.EventHandler(this.btnSelect_Livro_Click);
            // 
            // txtSelect_Livro
            // 
            this.txtSelect_Livro.Location = new System.Drawing.Point(133, 20);
            this.txtSelect_Livro.Name = "txtSelect_Livro";
            this.txtSelect_Livro.Size = new System.Drawing.Size(182, 22);
            this.txtSelect_Livro.TabIndex = 7;
            // 
            // dgvLivro
            // 
            this.dgvLivro.AllowUserToAddRows = false;
            this.dgvLivro.AllowUserToDeleteRows = false;
            this.dgvLivro.AllowUserToResizeColumns = false;
            this.dgvLivro.AllowUserToResizeRows = false;
            this.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivro.Location = new System.Drawing.Point(6, 46);
            this.dgvLivro.Name = "dgvLivro";
            this.dgvLivro.ReadOnly = true;
            this.dgvLivro.Size = new System.Drawing.Size(404, 185);
            this.dgvLivro.TabIndex = 6;
            this.dgvLivro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivro_CellClick);
            // 
            // gpbox_alunolivro
            // 
            this.gpbox_alunolivro.BackColor = System.Drawing.Color.Transparent;
            this.gpbox_alunolivro.Controls.Add(this.cmbFiltro_Aluno);
            this.gpbox_alunolivro.Controls.Add(this.btnSelect_Aluno);
            this.gpbox_alunolivro.Controls.Add(this.txtSelect_Aluno);
            this.gpbox_alunolivro.Controls.Add(this.dgvAluno);
            this.gpbox_alunolivro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbox_alunolivro.Location = new System.Drawing.Point(12, 268);
            this.gpbox_alunolivro.Name = "gpbox_alunolivro";
            this.gpbox_alunolivro.Size = new System.Drawing.Size(423, 253);
            this.gpbox_alunolivro.TabIndex = 7;
            this.gpbox_alunolivro.TabStop = false;
            this.gpbox_alunolivro.Text = "Dados do Aluno";
            this.gpbox_alunolivro.Enter += new System.EventHandler(this.gpbox_alunolivro_Enter);
            // 
            // cmbFiltro_Aluno
            // 
            this.cmbFiltro_Aluno.FormattingEnabled = true;
            this.cmbFiltro_Aluno.Items.AddRange(new object[] {
            "Código",
            "Nome"});
            this.cmbFiltro_Aluno.Location = new System.Drawing.Point(6, 27);
            this.cmbFiltro_Aluno.Name = "cmbFiltro_Aluno";
            this.cmbFiltro_Aluno.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltro_Aluno.TabIndex = 13;
            this.cmbFiltro_Aluno.Text = "Filtrar";
            // 
            // btnSelect_Aluno
            // 
            this.btnSelect_Aluno.Location = new System.Drawing.Point(321, 28);
            this.btnSelect_Aluno.Name = "btnSelect_Aluno";
            this.btnSelect_Aluno.Size = new System.Drawing.Size(75, 23);
            this.btnSelect_Aluno.TabIndex = 12;
            this.btnSelect_Aluno.Text = "Procurar";
            this.btnSelect_Aluno.UseVisualStyleBackColor = true;
            this.btnSelect_Aluno.Click += new System.EventHandler(this.btnSelect_Aluno_Click);
            // 
            // txtSelect_Aluno
            // 
            this.txtSelect_Aluno.Location = new System.Drawing.Point(133, 28);
            this.txtSelect_Aluno.Name = "txtSelect_Aluno";
            this.txtSelect_Aluno.Size = new System.Drawing.Size(182, 23);
            this.txtSelect_Aluno.TabIndex = 11;
            // 
            // dgvAluno
            // 
            this.dgvAluno.AllowUserToAddRows = false;
            this.dgvAluno.AllowUserToDeleteRows = false;
            this.dgvAluno.AllowUserToResizeColumns = false;
            this.dgvAluno.AllowUserToResizeRows = false;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(6, 54);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.ReadOnly = true;
            this.dgvAluno.Size = new System.Drawing.Size(404, 185);
            this.dgvAluno.TabIndex = 10;
            this.dgvAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluno_CellClick);
            this.dgvAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluno_CellContentClick);
            // 
            // picCapa
            // 
            this.picCapa.Location = new System.Drawing.Point(6, 17);
            this.picCapa.Name = "picCapa";
            this.picCapa.Size = new System.Drawing.Size(250, 400);
            this.picCapa.TabIndex = 6;
            this.picCapa.TabStop = false;
            // 
            // picAluno
            // 
            this.picAluno.Location = new System.Drawing.Point(6, 19);
            this.picAluno.Name = "picAluno";
            this.picAluno.Size = new System.Drawing.Size(250, 300);
            this.picAluno.TabIndex = 8;
            this.picAluno.TabStop = false;
            // 
            // dtpAluguel
            // 
            this.dtpAluguel.CustomFormat = "MM/dd//yyyy";
            this.dtpAluguel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAluguel.Location = new System.Drawing.Point(117, 19);
            this.dtpAluguel.Name = "dtpAluguel";
            this.dtpAluguel.Size = new System.Drawing.Size(97, 23);
            this.dtpAluguel.TabIndex = 11;
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.CustomFormat = "MM/dd//yyyy";
            this.dtpDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDevolucao.Location = new System.Drawing.Point(117, 46);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(97, 23);
            this.dtpDevolucao.TabIndex = 12;
            // 
            // lbl_dataaluguel
            // 
            this.lbl_dataaluguel.AutoSize = true;
            this.lbl_dataaluguel.Location = new System.Drawing.Point(3, 22);
            this.lbl_dataaluguel.Name = "lbl_dataaluguel";
            this.lbl_dataaluguel.Size = new System.Drawing.Size(98, 16);
            this.lbl_dataaluguel.TabIndex = 13;
            this.lbl_dataaluguel.Text = "Data de Aluguel";
            // 
            // lb_devolução
            // 
            this.lb_devolução.AutoSize = true;
            this.lb_devolução.Location = new System.Drawing.Point(3, 49);
            this.lb_devolução.Name = "lb_devolução";
            this.lb_devolução.Size = new System.Drawing.Size(114, 16);
            this.lb_devolução.TabIndex = 14;
            this.lb_devolução.Text = "Data de Devolução";
            // 
            // gpbox_aluguel
            // 
            this.gpbox_aluguel.BackColor = System.Drawing.Color.Transparent;
            this.gpbox_aluguel.Controls.Add(this.dtpAluguel);
            this.gpbox_aluguel.Controls.Add(this.lb_devolução);
            this.gpbox_aluguel.Controls.Add(this.dtpDevolucao);
            this.gpbox_aluguel.Controls.Add(this.lbl_dataaluguel);
            this.gpbox_aluguel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbox_aluguel.Location = new System.Drawing.Point(18, 527);
            this.gpbox_aluguel.Name = "gpbox_aluguel";
            this.gpbox_aluguel.Size = new System.Drawing.Size(417, 74);
            this.gpbox_aluguel.TabIndex = 15;
            this.gpbox_aluguel.TabStop = false;
            this.gpbox_aluguel.Text = "Aluguel Livro";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(459, 527);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 31);
            this.button3.TabIndex = 18;
            this.button3.Text = "Alugar Livro";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picCapa);
            this.groupBox1.Location = new System.Drawing.Point(453, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 428);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capa do Livro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picAluno);
            this.groupBox2.Location = new System.Drawing.Point(723, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 332);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Foto do Aluno";
            // 
            // Controle_Livro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCM_4_FUN.Properties.Resources.backgroundpadrao;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 602);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gpbox_aluguel);
            this.Controls.Add(this.gpbox_alunolivro);
            this.Controls.Add(this.gpbox_consulta);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.Name = "Controle_Livro";
            this.Text = "Controle_Livro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Controle_Livro_Load);
            this.gpbox_consulta.ResumeLayout(false);
            this.gpbox_consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).EndInit();
            this.gpbox_alunolivro.ResumeLayout(false);
            this.gpbox_alunolivro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAluno)).EndInit();
            this.gpbox_aluguel.ResumeLayout(false);
            this.gpbox_aluguel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gpbox_consulta;
        private System.Windows.Forms.GroupBox gpbox_alunolivro;
        private System.Windows.Forms.PictureBox picCapa;
        private System.Windows.Forms.PictureBox picAluno;
        private System.Windows.Forms.Label lb_devolução;
        private System.Windows.Forms.Label lbl_dataaluguel;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.DateTimePicker dtpAluguel;
        private System.Windows.Forms.GroupBox gpbox_aluguel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbFiltro_Livro;
        private System.Windows.Forms.Button btnSelect_Livro;
        private System.Windows.Forms.TextBox txtSelect_Livro;
        private System.Windows.Forms.DataGridView dgvLivro;
        private System.Windows.Forms.ComboBox cmbFiltro_Aluno;
        private System.Windows.Forms.Button btnSelect_Aluno;
        private System.Windows.Forms.TextBox txtSelect_Aluno;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}