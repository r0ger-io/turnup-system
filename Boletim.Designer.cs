namespace TCM_4_FUN
{
    partial class Boletim
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
            this.cmbNome_Turma = new System.Windows.Forms.ComboBox();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.txtNom_Aluno = new System.Windows.Forms.TextBox();
            this.txtOral1_Nota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOral4_Nota = new System.Windows.Forms.TextBox();
            this.txtOral3_Nota = new System.Windows.Forms.TextBox();
            this.txtOral2_Nota = new System.Windows.Forms.TextBox();
            this.txtParticipacao2_Nota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParticipacao1_Nota = new System.Windows.Forms.TextBox();
            this.txtEscrita2_Nota = new System.Windows.Forms.TextBox();
            this.txtEscrita3_Nota = new System.Windows.Forms.TextBox();
            this.txtEscrita4_Nota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEscrita1_Nota = new System.Windows.Forms.TextBox();
            this.grpNotas = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.grpNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbNome_Turma
            // 
            this.cmbNome_Turma.FormattingEnabled = true;
            this.cmbNome_Turma.Location = new System.Drawing.Point(36, 43);
            this.cmbNome_Turma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbNome_Turma.Name = "cmbNome_Turma";
            this.cmbNome_Turma.Size = new System.Drawing.Size(140, 24);
            this.cmbNome_Turma.TabIndex = 0;
            this.cmbNome_Turma.Text = "Turma";
            this.cmbNome_Turma.SelectedIndexChanged += new System.EventHandler(this.cmbNome_Turma_SelectedIndexChanged);
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(36, 74);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(523, 196);
            this.dgvAlunos.TabIndex = 1;
            this.dgvAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellClick);
            this.dgvAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellContentClick);
            // 
            // txtNom_Aluno
            // 
            this.txtNom_Aluno.Location = new System.Drawing.Point(36, 290);
            this.txtNom_Aluno.Name = "txtNom_Aluno";
            this.txtNom_Aluno.Size = new System.Drawing.Size(100, 23);
            this.txtNom_Aluno.TabIndex = 2;
            this.txtNom_Aluno.Text = "Nome do Aluno";
            this.txtNom_Aluno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNom_Aluno_MouseClick);
            this.txtNom_Aluno.TextChanged += new System.EventHandler(this.txtNom_Aluno_TextChanged);
            // 
            // txtOral1_Nota
            // 
            this.txtOral1_Nota.Location = new System.Drawing.Point(111, 59);
            this.txtOral1_Nota.Name = "txtOral1_Nota";
            this.txtOral1_Nota.Size = new System.Drawing.Size(54, 23);
            this.txtOral1_Nota.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Provas orais:";
            // 
            // txtOral4_Nota
            // 
            this.txtOral4_Nota.Location = new System.Drawing.Point(289, 59);
            this.txtOral4_Nota.Name = "txtOral4_Nota";
            this.txtOral4_Nota.Size = new System.Drawing.Size(55, 23);
            this.txtOral4_Nota.TabIndex = 5;
            // 
            // txtOral3_Nota
            // 
            this.txtOral3_Nota.Location = new System.Drawing.Point(231, 59);
            this.txtOral3_Nota.Name = "txtOral3_Nota";
            this.txtOral3_Nota.Size = new System.Drawing.Size(52, 23);
            this.txtOral3_Nota.TabIndex = 6;
            // 
            // txtOral2_Nota
            // 
            this.txtOral2_Nota.Location = new System.Drawing.Point(171, 59);
            this.txtOral2_Nota.Name = "txtOral2_Nota";
            this.txtOral2_Nota.Size = new System.Drawing.Size(54, 23);
            this.txtOral2_Nota.TabIndex = 7;
            // 
            // txtParticipacao2_Nota
            // 
            this.txtParticipacao2_Nota.Location = new System.Drawing.Point(171, 92);
            this.txtParticipacao2_Nota.Name = "txtParticipacao2_Nota";
            this.txtParticipacao2_Nota.Size = new System.Drawing.Size(54, 23);
            this.txtParticipacao2_Nota.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Participação:";
            // 
            // txtParticipacao1_Nota
            // 
            this.txtParticipacao1_Nota.Location = new System.Drawing.Point(111, 92);
            this.txtParticipacao1_Nota.Name = "txtParticipacao1_Nota";
            this.txtParticipacao1_Nota.Size = new System.Drawing.Size(54, 23);
            this.txtParticipacao1_Nota.TabIndex = 8;
            // 
            // txtEscrita2_Nota
            // 
            this.txtEscrita2_Nota.Location = new System.Drawing.Point(171, 27);
            this.txtEscrita2_Nota.Name = "txtEscrita2_Nota";
            this.txtEscrita2_Nota.Size = new System.Drawing.Size(54, 23);
            this.txtEscrita2_Nota.TabIndex = 17;
            // 
            // txtEscrita3_Nota
            // 
            this.txtEscrita3_Nota.Location = new System.Drawing.Point(231, 27);
            this.txtEscrita3_Nota.Name = "txtEscrita3_Nota";
            this.txtEscrita3_Nota.Size = new System.Drawing.Size(52, 23);
            this.txtEscrita3_Nota.TabIndex = 16;
            // 
            // txtEscrita4_Nota
            // 
            this.txtEscrita4_Nota.Location = new System.Drawing.Point(289, 27);
            this.txtEscrita4_Nota.Name = "txtEscrita4_Nota";
            this.txtEscrita4_Nota.Size = new System.Drawing.Size(55, 23);
            this.txtEscrita4_Nota.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Provas Escritas:";
            // 
            // txtEscrita1_Nota
            // 
            this.txtEscrita1_Nota.Location = new System.Drawing.Point(111, 27);
            this.txtEscrita1_Nota.Name = "txtEscrita1_Nota";
            this.txtEscrita1_Nota.Size = new System.Drawing.Size(54, 23);
            this.txtEscrita1_Nota.TabIndex = 13;
            // 
            // grpNotas
            // 
            this.grpNotas.Controls.Add(this.label3);
            this.grpNotas.Controls.Add(this.txtEscrita2_Nota);
            this.grpNotas.Controls.Add(this.txtOral1_Nota);
            this.grpNotas.Controls.Add(this.txtEscrita3_Nota);
            this.grpNotas.Controls.Add(this.label1);
            this.grpNotas.Controls.Add(this.txtEscrita4_Nota);
            this.grpNotas.Controls.Add(this.txtOral4_Nota);
            this.grpNotas.Controls.Add(this.txtOral3_Nota);
            this.grpNotas.Controls.Add(this.txtEscrita1_Nota);
            this.grpNotas.Controls.Add(this.txtOral2_Nota);
            this.grpNotas.Controls.Add(this.txtParticipacao2_Nota);
            this.grpNotas.Controls.Add(this.txtParticipacao1_Nota);
            this.grpNotas.Controls.Add(this.label2);
            this.grpNotas.Location = new System.Drawing.Point(36, 335);
            this.grpNotas.Name = "grpNotas";
            this.grpNotas.Size = new System.Drawing.Size(365, 130);
            this.grpNotas.TabIndex = 18;
            this.grpNotas.TabStop = false;
            this.grpNotas.Text = "Notas";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(267, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Boletim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCM_4_FUN.Properties.Resources.backgroundpadrao;
            this.ClientSize = new System.Drawing.Size(699, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpNotas);
            this.Controls.Add(this.txtNom_Aluno);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.cmbNome_Turma);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Boletim";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Boletim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.grpNotas.ResumeLayout(false);
            this.grpNotas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNome_Turma;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.TextBox txtNom_Aluno;
        private System.Windows.Forms.TextBox txtOral1_Nota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOral4_Nota;
        private System.Windows.Forms.TextBox txtOral3_Nota;
        private System.Windows.Forms.TextBox txtOral2_Nota;
        private System.Windows.Forms.TextBox txtParticipacao2_Nota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParticipacao1_Nota;
        private System.Windows.Forms.TextBox txtEscrita2_Nota;
        private System.Windows.Forms.TextBox txtEscrita3_Nota;
        private System.Windows.Forms.TextBox txtEscrita4_Nota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEscrita1_Nota;
        private System.Windows.Forms.GroupBox grpNotas;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
    }
}