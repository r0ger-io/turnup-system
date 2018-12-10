namespace TCM_4_FUN
{
    partial class Cadastro_turma
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
            this.components = new System.ComponentModel.Container();
            this.cmbCurso_Turma = new System.Windows.Forms.ComboBox();
            this.lblInicio_Turma = new System.Windows.Forms.Label();
            this.lblTermino_Turma = new System.Windows.Forms.Label();
            this.dtpInicio_Turma = new System.Windows.Forms.DateTimePicker();
            this.dtpTermino_Turma = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar_Turma = new System.Windows.Forms.Button();
            this.btnSalvar_Turma = new System.Windows.Forms.Button();
            this.ckbSeg_Turma = new System.Windows.Forms.CheckBox();
            this.ckbDom_Turma = new System.Windows.Forms.CheckBox();
            this.ckbTer_Turma = new System.Windows.Forms.CheckBox();
            this.ckbSex_Turma = new System.Windows.Forms.CheckBox();
            this.ckbQua_Turma = new System.Windows.Forms.CheckBox();
            this.ckbQui_Turma = new System.Windows.Forms.CheckBox();
            this.ckbSab_Turma = new System.Windows.Forms.CheckBox();
            this.txtNome_Turma = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTurma = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCurso_Turma
            // 
            this.cmbCurso_Turma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurso_Turma.FormattingEnabled = true;
            this.cmbCurso_Turma.Items.AddRange(new object[] {
            "Inglês",
            "Espanhol",
            "Francês",
            "Português"});
            this.cmbCurso_Turma.Location = new System.Drawing.Point(173, 62);
            this.cmbCurso_Turma.Name = "cmbCurso_Turma";
            this.cmbCurso_Turma.Size = new System.Drawing.Size(142, 24);
            this.cmbCurso_Turma.TabIndex = 0;
            this.cmbCurso_Turma.Text = "Tipo do Curso";
            this.cmbCurso_Turma.SelectedIndexChanged += new System.EventHandler(this.cbox_tipocurso_SelectedIndexChanged);
            // 
            // lblInicio_Turma
            // 
            this.lblInicio_Turma.AutoSize = true;
            this.lblInicio_Turma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio_Turma.Location = new System.Drawing.Point(397, 371);
            this.lblInicio_Turma.Name = "lblInicio_Turma";
            this.lblInicio_Turma.Size = new System.Drawing.Size(86, 16);
            this.lblInicio_Turma.TabIndex = 7;
            this.lblInicio_Turma.Text = "Data de Início";
            // 
            // lblTermino_Turma
            // 
            this.lblTermino_Turma.AutoSize = true;
            this.lblTermino_Turma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermino_Turma.Location = new System.Drawing.Point(379, 398);
            this.lblTermino_Turma.Name = "lblTermino_Turma";
            this.lblTermino_Turma.Size = new System.Drawing.Size(104, 16);
            this.lblTermino_Turma.TabIndex = 8;
            this.lblTermino_Turma.Text = "Data de Término";
            // 
            // dtpInicio_Turma
            // 
            this.dtpInicio_Turma.CustomFormat = "MM/dd/yyyy";
            this.dtpInicio_Turma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio_Turma.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio_Turma.Location = new System.Drawing.Point(489, 364);
            this.dtpInicio_Turma.Name = "dtpInicio_Turma";
            this.dtpInicio_Turma.Size = new System.Drawing.Size(87, 23);
            this.dtpInicio_Turma.TabIndex = 11;
            // 
            // dtpTermino_Turma
            // 
            this.dtpTermino_Turma.CustomFormat = "MM/dd/yyyy";
            this.dtpTermino_Turma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTermino_Turma.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTermino_Turma.Location = new System.Drawing.Point(489, 390);
            this.dtpTermino_Turma.Name = "dtpTermino_Turma";
            this.dtpTermino_Turma.Size = new System.Drawing.Size(87, 23);
            this.dtpTermino_Turma.TabIndex = 12;
            // 
            // btnCancelar_Turma
            // 
            this.btnCancelar_Turma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar_Turma.Location = new System.Drawing.Point(487, 512);
            this.btnCancelar_Turma.Name = "btnCancelar_Turma";
            this.btnCancelar_Turma.Size = new System.Drawing.Size(124, 31);
            this.btnCancelar_Turma.TabIndex = 13;
            this.btnCancelar_Turma.Text = "Cancelar";
            this.btnCancelar_Turma.UseVisualStyleBackColor = true;
            this.btnCancelar_Turma.Click += new System.EventHandler(this.btnCancelar_Turma_Click);
            // 
            // btnSalvar_Turma
            // 
            this.btnSalvar_Turma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar_Turma.Location = new System.Drawing.Point(317, 512);
            this.btnSalvar_Turma.Name = "btnSalvar_Turma";
            this.btnSalvar_Turma.Size = new System.Drawing.Size(124, 31);
            this.btnSalvar_Turma.TabIndex = 14;
            this.btnSalvar_Turma.Text = "Salvar";
            this.btnSalvar_Turma.UseVisualStyleBackColor = true;
            this.btnSalvar_Turma.Click += new System.EventHandler(this.btnSalvar_Turma_Click);
            // 
            // ckbSeg_Turma
            // 
            this.ckbSeg_Turma.AutoSize = true;
            this.ckbSeg_Turma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSeg_Turma.Location = new System.Drawing.Point(11, 58);
            this.ckbSeg_Turma.Name = "ckbSeg_Turma";
            this.ckbSeg_Turma.Size = new System.Drawing.Size(77, 20);
            this.ckbSeg_Turma.TabIndex = 15;
            this.ckbSeg_Turma.Text = "Segunda";
            this.ckbSeg_Turma.UseVisualStyleBackColor = true;
            this.ckbSeg_Turma.CheckedChanged += new System.EventHandler(this.ckbSeg_Turma_CheckedChanged);
            // 
            // ckbDom_Turma
            // 
            this.ckbDom_Turma.AutoSize = true;
            this.ckbDom_Turma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDom_Turma.Location = new System.Drawing.Point(11, 35);
            this.ckbDom_Turma.Name = "ckbDom_Turma";
            this.ckbDom_Turma.Size = new System.Drawing.Size(77, 20);
            this.ckbDom_Turma.TabIndex = 16;
            this.ckbDom_Turma.Text = "Domingo";
            this.ckbDom_Turma.UseVisualStyleBackColor = true;
            this.ckbDom_Turma.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckbTer_Turma
            // 
            this.ckbTer_Turma.AutoSize = true;
            this.ckbTer_Turma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTer_Turma.Location = new System.Drawing.Point(11, 81);
            this.ckbTer_Turma.Name = "ckbTer_Turma";
            this.ckbTer_Turma.Size = new System.Drawing.Size(60, 20);
            this.ckbTer_Turma.TabIndex = 17;
            this.ckbTer_Turma.Text = "Terça";
            this.ckbTer_Turma.UseVisualStyleBackColor = true;
            this.ckbTer_Turma.CheckedChanged += new System.EventHandler(this.ckbTer_Turma_CheckedChanged);
            // 
            // ckbSex_Turma
            // 
            this.ckbSex_Turma.AutoSize = true;
            this.ckbSex_Turma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSex_Turma.Location = new System.Drawing.Point(119, 81);
            this.ckbSex_Turma.Name = "ckbSex_Turma";
            this.ckbSex_Turma.Size = new System.Drawing.Size(59, 20);
            this.ckbSex_Turma.TabIndex = 20;
            this.ckbSex_Turma.Text = "Sexta";
            this.ckbSex_Turma.UseVisualStyleBackColor = true;
            this.ckbSex_Turma.CheckedChanged += new System.EventHandler(this.ckbSex_Turma_CheckedChanged);
            // 
            // ckbQua_Turma
            // 
            this.ckbQua_Turma.AutoSize = true;
            this.ckbQua_Turma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbQua_Turma.Location = new System.Drawing.Point(119, 35);
            this.ckbQua_Turma.Name = "ckbQua_Turma";
            this.ckbQua_Turma.Size = new System.Drawing.Size(66, 20);
            this.ckbQua_Turma.TabIndex = 19;
            this.ckbQua_Turma.Text = "Quarta";
            this.ckbQua_Turma.UseVisualStyleBackColor = true;
            this.ckbQua_Turma.CheckedChanged += new System.EventHandler(this.ckbQua_Turma_CheckedChanged);
            // 
            // ckbQui_Turma
            // 
            this.ckbQui_Turma.AutoSize = true;
            this.ckbQui_Turma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbQui_Turma.Location = new System.Drawing.Point(119, 58);
            this.ckbQui_Turma.Name = "ckbQui_Turma";
            this.ckbQui_Turma.Size = new System.Drawing.Size(64, 20);
            this.ckbQui_Turma.TabIndex = 18;
            this.ckbQui_Turma.Text = "Quinta";
            this.ckbQui_Turma.UseVisualStyleBackColor = true;
            this.ckbQui_Turma.CheckedChanged += new System.EventHandler(this.ckbQui_Turma_CheckedChanged);
            // 
            // ckbSab_Turma
            // 
            this.ckbSab_Turma.AutoSize = true;
            this.ckbSab_Turma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSab_Turma.Location = new System.Drawing.Point(226, 35);
            this.ckbSab_Turma.Name = "ckbSab_Turma";
            this.ckbSab_Turma.Size = new System.Drawing.Size(70, 20);
            this.ckbSab_Turma.TabIndex = 21;
            this.ckbSab_Turma.Text = "Sábado";
            this.ckbSab_Turma.UseVisualStyleBackColor = true;
            this.ckbSab_Turma.CheckedChanged += new System.EventHandler(this.ckbSab_Turma_CheckedChanged);
            // 
            // txtNome_Turma
            // 
            this.txtNome_Turma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome_Turma.Location = new System.Drawing.Point(31, 62);
            this.txtNome_Turma.Name = "txtNome_Turma";
            this.txtNome_Turma.Size = new System.Drawing.Size(127, 23);
            this.txtNome_Turma.TabIndex = 22;
            this.txtNome_Turma.Text = "Nome da Turma";
            this.txtNome_Turma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbDom_Turma);
            this.groupBox1.Controls.Add(this.ckbSeg_Turma);
            this.groupBox1.Controls.Add(this.ckbSab_Turma);
            this.groupBox1.Controls.Add(this.ckbTer_Turma);
            this.groupBox1.Controls.Add(this.ckbSex_Turma);
            this.groupBox1.Controls.Add(this.ckbQui_Turma);
            this.groupBox1.Controls.Add(this.ckbQua_Turma);
            this.groupBox1.Location = new System.Drawing.Point(31, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 155);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dias da Semana";
            // 
            // dgvTurma
            // 
            this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurma.Location = new System.Drawing.Point(31, 92);
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.Size = new System.Drawing.Size(562, 241);
            this.dgvTurma.TabIndex = 24;
            this.dgvTurma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurma_CellClick);
            this.dgvTurma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Cadastro_turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCM_4_FUN.Properties.Resources.backgroundpadrao;
            this.ClientSize = new System.Drawing.Size(1376, 693);
            this.Controls.Add(this.dgvTurma);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNome_Turma);
            this.Controls.Add(this.btnSalvar_Turma);
            this.Controls.Add(this.btnCancelar_Turma);
            this.Controls.Add(this.dtpTermino_Turma);
            this.Controls.Add(this.dtpInicio_Turma);
            this.Controls.Add(this.lblTermino_Turma);
            this.Controls.Add(this.lblInicio_Turma);
            this.Controls.Add(this.cmbCurso_Turma);
            this.DoubleBuffered = true;
            this.Name = "Cadastro_turma";
            this.Text = "Cadastro_turma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Cadastro_turma_Activated);
            this.Load += new System.EventHandler(this.Cadastro_turma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCurso_Turma;
        private System.Windows.Forms.Label lblInicio_Turma;
        private System.Windows.Forms.Label lblTermino_Turma;
        private System.Windows.Forms.DateTimePicker dtpInicio_Turma;
        private System.Windows.Forms.DateTimePicker dtpTermino_Turma;
        private System.Windows.Forms.Button btnCancelar_Turma;
        private System.Windows.Forms.Button btnSalvar_Turma;
        private System.Windows.Forms.CheckBox ckbSeg_Turma;
        private System.Windows.Forms.CheckBox ckbDom_Turma;
        private System.Windows.Forms.CheckBox ckbTer_Turma;
        private System.Windows.Forms.CheckBox ckbSex_Turma;
        private System.Windows.Forms.CheckBox ckbQua_Turma;
        private System.Windows.Forms.CheckBox ckbQui_Turma;
        private System.Windows.Forms.CheckBox ckbSab_Turma;
        private System.Windows.Forms.MaskedTextBox txtNome_Turma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTurma;
        private System.Windows.Forms.Timer timer1;

    }
}