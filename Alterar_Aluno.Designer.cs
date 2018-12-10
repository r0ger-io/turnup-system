namespace TCM_4_FUN
{
    partial class Alterar_Aluno
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
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tmrAtualiza = new System.Windows.Forms.Timer(this.components);
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpFoto_Aluno = new System.Windows.Forms.GroupBox();
            this.btnInserir_Aluno = new System.Windows.Forms.Button();
            this.picAluno = new System.Windows.Forms.PictureBox();
            this.grpContato_Aluno = new System.Windows.Forms.GroupBox();
            this.lblCel_Aluno = new System.Windows.Forms.Label();
            this.txtCel_Aluno = new System.Windows.Forms.MaskedTextBox();
            this.txtTel1_Aluno = new System.Windows.Forms.MaskedTextBox();
            this.txtTel2_Aluno = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpDados_Aluno = new System.Windows.Forms.GroupBox();
            this.grpSexo_Aluno = new System.Windows.Forms.GroupBox();
            this.rdbMasc_Aluno = new System.Windows.Forms.RadioButton();
            this.rdbFem_Aluno = new System.Windows.Forms.RadioButton();
            this.txtNom_Aluno = new System.Windows.Forms.TextBox();
            this.lblNasc_Aluno = new System.Windows.Forms.Label();
            this.dtpNasc_Aluno = new System.Windows.Forms.DateTimePicker();
            this.grpDocumento_Aluno = new System.Windows.Forms.GroupBox();
            this.txtOrgao_Aluno = new System.Windows.Forms.TextBox();
            this.lblOrgao_Aluno = new System.Windows.Forms.Label();
            this.txtRg_Aluno = new System.Windows.Forms.MaskedTextBox();
            this.lblRg_Aluno = new System.Windows.Forms.Label();
            this.lblCpf_Aluno = new System.Windows.Forms.Label();
            this.txtCpf_Aluno = new System.Windows.Forms.MaskedTextBox();
            this.grpMoradia_Aluno = new System.Windows.Forms.GroupBox();
            this.txtNum_Aluno = new System.Windows.Forms.TextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.txtEndereco_Aluno = new System.Windows.Forms.TextBox();
            this.txtCep_Aluno = new System.Windows.Forms.MaskedTextBox();
            this.txtComp_Aluno = new System.Windows.Forms.TextBox();
            this.txtCidade_Aluno = new System.Windows.Forms.TextBox();
            this.cmbUf_Aluno = new System.Windows.Forms.ComboBox();
            this.grpSaude_Aluno = new System.Windows.Forms.GroupBox();
            this.grpMedico_Aluno = new System.Windows.Forms.GroupBox();
            this.rbPlanoNao_Aluno = new System.Windows.Forms.RadioButton();
            this.rbPlanoSim_Aluno = new System.Windows.Forms.RadioButton();
            this.txtObs_Aluno = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.grpFoto_Aluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAluno)).BeginInit();
            this.grpContato_Aluno.SuspendLayout();
            this.grpDados_Aluno.SuspendLayout();
            this.grpSexo_Aluno.SuspendLayout();
            this.grpDocumento_Aluno.SuspendLayout();
            this.grpMoradia_Aluno.SuspendLayout();
            this.grpSaude_Aluno.SuspendLayout();
            this.grpMedico_Aluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAluno
            // 
            this.dgvAluno.AllowUserToAddRows = false;
            this.dgvAluno.AllowUserToDeleteRows = false;
            this.dgvAluno.AllowUserToResizeColumns = false;
            this.dgvAluno.AllowUserToResizeRows = false;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(2, 112);
            this.dgvAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.ReadOnly = true;
            this.dgvAluno.Size = new System.Drawing.Size(749, 228);
            this.dgvAluno.TabIndex = 0;
            this.dgvAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellClick);
            this.dgvAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellContentClick);
            this.dgvAluno.SelectionChanged += new System.EventHandler(this.dgvAluno_SelectionChanged);
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(194, 62);
            this.txtSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(116, 23);
            this.txtSelect.TabIndex = 2;
            this.txtSelect.TextChanged += new System.EventHandler(this.txtNome_Func_TextChanged);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(335, 58);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(87, 28);
            this.btnPesquisa.TabIndex = 3;
            this.btnPesquisa.Text = "Procurar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(454, 58);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 28);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // tmrAtualiza
            // 
            this.tmrAtualiza.Enabled = true;
            this.tmrAtualiza.Tick += new System.EventHandler(this.tmrAtualiza_Tick);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "Sexo",
            "Plano de Saúde"});
            this.cmbFiltro.Location = new System.Drawing.Point(45, 60);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(140, 24);
            this.cmbFiltro.TabIndex = 5;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpFoto_Aluno
            // 
            this.grpFoto_Aluno.Controls.Add(this.btnInserir_Aluno);
            this.grpFoto_Aluno.Controls.Add(this.picAluno);
            this.grpFoto_Aluno.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFoto_Aluno.Location = new System.Drawing.Point(972, 47);
            this.grpFoto_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFoto_Aluno.Name = "grpFoto_Aluno";
            this.grpFoto_Aluno.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFoto_Aluno.Size = new System.Drawing.Size(307, 439);
            this.grpFoto_Aluno.TabIndex = 97;
            this.grpFoto_Aluno.TabStop = false;
            this.grpFoto_Aluno.Text = "Foto";
            // 
            // btnInserir_Aluno
            // 
            this.btnInserir_Aluno.Location = new System.Drawing.Point(110, 398);
            this.btnInserir_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInserir_Aluno.Name = "btnInserir_Aluno";
            this.btnInserir_Aluno.Size = new System.Drawing.Size(101, 27);
            this.btnInserir_Aluno.TabIndex = 47;
            this.btnInserir_Aluno.Text = "Nova Foto";
            this.btnInserir_Aluno.UseVisualStyleBackColor = true;
            this.btnInserir_Aluno.Click += new System.EventHandler(this.btnInserir_Aluno_Click);
            // 
            // picAluno
            // 
            this.picAluno.Location = new System.Drawing.Point(7, 20);
            this.picAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picAluno.Name = "picAluno";
            this.picAluno.Size = new System.Drawing.Size(292, 369);
            this.picAluno.TabIndex = 46;
            this.picAluno.TabStop = false;
            // 
            // grpContato_Aluno
            // 
            this.grpContato_Aluno.Controls.Add(this.lblCel_Aluno);
            this.grpContato_Aluno.Controls.Add(this.txtCel_Aluno);
            this.grpContato_Aluno.Controls.Add(this.txtTel1_Aluno);
            this.grpContato_Aluno.Controls.Add(this.txtTel2_Aluno);
            this.grpContato_Aluno.Controls.Add(this.label1);
            this.grpContato_Aluno.Controls.Add(this.label3);
            this.grpContato_Aluno.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContato_Aluno.Location = new System.Drawing.Point(520, 485);
            this.grpContato_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpContato_Aluno.Name = "grpContato_Aluno";
            this.grpContato_Aluno.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpContato_Aluno.Size = new System.Drawing.Size(393, 178);
            this.grpContato_Aluno.TabIndex = 96;
            this.grpContato_Aluno.TabStop = false;
            this.grpContato_Aluno.Text = "Contato";
            // 
            // lblCel_Aluno
            // 
            this.lblCel_Aluno.AutoSize = true;
            this.lblCel_Aluno.Location = new System.Drawing.Point(57, 50);
            this.lblCel_Aluno.Name = "lblCel_Aluno";
            this.lblCel_Aluno.Size = new System.Drawing.Size(48, 16);
            this.lblCel_Aluno.TabIndex = 10;
            this.lblCel_Aluno.Text = "Celular";
            // 
            // txtCel_Aluno
            // 
            this.txtCel_Aluno.Location = new System.Drawing.Point(120, 42);
            this.txtCel_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCel_Aluno.Mask = "(99) 00000-0000";
            this.txtCel_Aluno.Name = "txtCel_Aluno";
            this.txtCel_Aluno.Size = new System.Drawing.Size(116, 23);
            this.txtCel_Aluno.TabIndex = 13;
            // 
            // txtTel1_Aluno
            // 
            this.txtTel1_Aluno.Location = new System.Drawing.Point(120, 76);
            this.txtTel1_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTel1_Aluno.Mask = "(99) 0000-0000";
            this.txtTel1_Aluno.Name = "txtTel1_Aluno";
            this.txtTel1_Aluno.Size = new System.Drawing.Size(116, 23);
            this.txtTel1_Aluno.TabIndex = 32;
            // 
            // txtTel2_Aluno
            // 
            this.txtTel2_Aluno.Location = new System.Drawing.Point(120, 111);
            this.txtTel2_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTel2_Aluno.Mask = "(99) 0000-0000";
            this.txtTel2_Aluno.Name = "txtTel2_Aluno";
            this.txtTel2_Aluno.Size = new System.Drawing.Size(116, 23);
            this.txtTel2_Aluno.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Telefone (2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Telefone (1)";
            // 
            // grpDados_Aluno
            // 
            this.grpDados_Aluno.Controls.Add(this.grpSexo_Aluno);
            this.grpDados_Aluno.Controls.Add(this.txtNom_Aluno);
            this.grpDados_Aluno.Controls.Add(this.lblNasc_Aluno);
            this.grpDados_Aluno.Controls.Add(this.dtpNasc_Aluno);
            this.grpDados_Aluno.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDados_Aluno.Location = new System.Drawing.Point(12, 354);
            this.grpDados_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDados_Aluno.Name = "grpDados_Aluno";
            this.grpDados_Aluno.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDados_Aluno.Size = new System.Drawing.Size(491, 225);
            this.grpDados_Aluno.TabIndex = 95;
            this.grpDados_Aluno.TabStop = false;
            this.grpDados_Aluno.Text = "Dados Pessoais";
            // 
            // grpSexo_Aluno
            // 
            this.grpSexo_Aluno.BackColor = System.Drawing.Color.Transparent;
            this.grpSexo_Aluno.Controls.Add(this.rdbMasc_Aluno);
            this.grpSexo_Aluno.Controls.Add(this.rdbFem_Aluno);
            this.grpSexo_Aluno.Location = new System.Drawing.Point(10, 140);
            this.grpSexo_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSexo_Aluno.Name = "grpSexo_Aluno";
            this.grpSexo_Aluno.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSexo_Aluno.Size = new System.Drawing.Size(162, 78);
            this.grpSexo_Aluno.TabIndex = 9;
            this.grpSexo_Aluno.TabStop = false;
            this.grpSexo_Aluno.Text = "Sexo";
            // 
            // rdbMasc_Aluno
            // 
            this.rdbMasc_Aluno.AutoSize = true;
            this.rdbMasc_Aluno.Checked = true;
            this.rdbMasc_Aluno.Location = new System.Drawing.Point(8, 25);
            this.rdbMasc_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbMasc_Aluno.Name = "rdbMasc_Aluno";
            this.rdbMasc_Aluno.Size = new System.Drawing.Size(82, 20);
            this.rdbMasc_Aluno.TabIndex = 0;
            this.rdbMasc_Aluno.TabStop = true;
            this.rdbMasc_Aluno.Text = "Masculino";
            this.rdbMasc_Aluno.UseVisualStyleBackColor = true;
            // 
            // rdbFem_Aluno
            // 
            this.rdbFem_Aluno.AutoSize = true;
            this.rdbFem_Aluno.Location = new System.Drawing.Point(8, 53);
            this.rdbFem_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbFem_Aluno.Name = "rdbFem_Aluno";
            this.rdbFem_Aluno.Size = new System.Drawing.Size(78, 20);
            this.rdbFem_Aluno.TabIndex = 1;
            this.rdbFem_Aluno.Text = "Feminino";
            this.rdbFem_Aluno.UseVisualStyleBackColor = true;
            // 
            // txtNom_Aluno
            // 
            this.txtNom_Aluno.Location = new System.Drawing.Point(7, 36);
            this.txtNom_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNom_Aluno.Name = "txtNom_Aluno";
            this.txtNom_Aluno.Size = new System.Drawing.Size(418, 23);
            this.txtNom_Aluno.TabIndex = 5;
            this.txtNom_Aluno.Text = " Nome Completo";
            // 
            // lblNasc_Aluno
            // 
            this.lblNasc_Aluno.AutoSize = true;
            this.lblNasc_Aluno.Location = new System.Drawing.Point(7, 92);
            this.lblNasc_Aluno.Name = "lblNasc_Aluno";
            this.lblNasc_Aluno.Size = new System.Drawing.Size(122, 16);
            this.lblNasc_Aluno.TabIndex = 3;
            this.lblNasc_Aluno.Text = "Data de Nascimento";
            // 
            // dtpNasc_Aluno
            // 
            this.dtpNasc_Aluno.Checked = false;
            this.dtpNasc_Aluno.CustomFormat = "MM/dd/yyyy";
            this.dtpNasc_Aluno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNasc_Aluno.Location = new System.Drawing.Point(166, 86);
            this.dtpNasc_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNasc_Aluno.Name = "dtpNasc_Aluno";
            this.dtpNasc_Aluno.Size = new System.Drawing.Size(116, 23);
            this.dtpNasc_Aluno.TabIndex = 8;
            // 
            // grpDocumento_Aluno
            // 
            this.grpDocumento_Aluno.Controls.Add(this.txtOrgao_Aluno);
            this.grpDocumento_Aluno.Controls.Add(this.lblOrgao_Aluno);
            this.grpDocumento_Aluno.Controls.Add(this.txtRg_Aluno);
            this.grpDocumento_Aluno.Controls.Add(this.lblRg_Aluno);
            this.grpDocumento_Aluno.Controls.Add(this.lblCpf_Aluno);
            this.grpDocumento_Aluno.Controls.Add(this.txtCpf_Aluno);
            this.grpDocumento_Aluno.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDocumento_Aluno.Location = new System.Drawing.Point(520, 354);
            this.grpDocumento_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDocumento_Aluno.Name = "grpDocumento_Aluno";
            this.grpDocumento_Aluno.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDocumento_Aluno.Size = new System.Drawing.Size(393, 123);
            this.grpDocumento_Aluno.TabIndex = 94;
            this.grpDocumento_Aluno.TabStop = false;
            this.grpDocumento_Aluno.Text = "Documentos";
            // 
            // txtOrgao_Aluno
            // 
            this.txtOrgao_Aluno.Location = new System.Drawing.Point(120, 53);
            this.txtOrgao_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrgao_Aluno.Name = "txtOrgao_Aluno";
            this.txtOrgao_Aluno.Size = new System.Drawing.Size(116, 23);
            this.txtOrgao_Aluno.TabIndex = 87;
            // 
            // lblOrgao_Aluno
            // 
            this.lblOrgao_Aluno.AutoSize = true;
            this.lblOrgao_Aluno.Location = new System.Drawing.Point(6, 62);
            this.lblOrgao_Aluno.Name = "lblOrgao_Aluno";
            this.lblOrgao_Aluno.Size = new System.Drawing.Size(92, 16);
            this.lblOrgao_Aluno.TabIndex = 16;
            this.lblOrgao_Aluno.Text = "Órgão Emissor";
            // 
            // txtRg_Aluno
            // 
            this.txtRg_Aluno.Location = new System.Drawing.Point(120, 21);
            this.txtRg_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRg_Aluno.Mask = "00,000,000-0";
            this.txtRg_Aluno.Name = "txtRg_Aluno";
            this.txtRg_Aluno.Size = new System.Drawing.Size(116, 23);
            this.txtRg_Aluno.TabIndex = 14;
            // 
            // lblRg_Aluno
            // 
            this.lblRg_Aluno.AutoSize = true;
            this.lblRg_Aluno.Location = new System.Drawing.Point(85, 30);
            this.lblRg_Aluno.Name = "lblRg_Aluno";
            this.lblRg_Aluno.Size = new System.Drawing.Size(24, 16);
            this.lblRg_Aluno.TabIndex = 1;
            this.lblRg_Aluno.Text = "RG";
            // 
            // lblCpf_Aluno
            // 
            this.lblCpf_Aluno.AutoSize = true;
            this.lblCpf_Aluno.Location = new System.Drawing.Point(78, 92);
            this.lblCpf_Aluno.Name = "lblCpf_Aluno";
            this.lblCpf_Aluno.Size = new System.Drawing.Size(30, 16);
            this.lblCpf_Aluno.TabIndex = 2;
            this.lblCpf_Aluno.Text = "CPF";
            // 
            // txtCpf_Aluno
            // 
            this.txtCpf_Aluno.Location = new System.Drawing.Point(120, 89);
            this.txtCpf_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCpf_Aluno.Mask = "000,000,000-00";
            this.txtCpf_Aluno.Name = "txtCpf_Aluno";
            this.txtCpf_Aluno.Size = new System.Drawing.Size(116, 23);
            this.txtCpf_Aluno.TabIndex = 15;
            // 
            // grpMoradia_Aluno
            // 
            this.grpMoradia_Aluno.BackColor = System.Drawing.Color.Transparent;
            this.grpMoradia_Aluno.Controls.Add(this.txtNum_Aluno);
            this.grpMoradia_Aluno.Controls.Add(this.lbl_cep);
            this.grpMoradia_Aluno.Controls.Add(this.txtEndereco_Aluno);
            this.grpMoradia_Aluno.Controls.Add(this.txtCep_Aluno);
            this.grpMoradia_Aluno.Controls.Add(this.txtComp_Aluno);
            this.grpMoradia_Aluno.Controls.Add(this.txtCidade_Aluno);
            this.grpMoradia_Aluno.Controls.Add(this.cmbUf_Aluno);
            this.grpMoradia_Aluno.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMoradia_Aluno.Location = new System.Drawing.Point(12, 630);
            this.grpMoradia_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpMoradia_Aluno.Name = "grpMoradia_Aluno";
            this.grpMoradia_Aluno.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpMoradia_Aluno.Size = new System.Drawing.Size(491, 160);
            this.grpMoradia_Aluno.TabIndex = 93;
            this.grpMoradia_Aluno.TabStop = false;
            this.grpMoradia_Aluno.Text = "Moradia";
            // 
            // txtNum_Aluno
            // 
            this.txtNum_Aluno.Location = new System.Drawing.Point(7, 58);
            this.txtNum_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNum_Aluno.Name = "txtNum_Aluno";
            this.txtNum_Aluno.Size = new System.Drawing.Size(179, 23);
            this.txtNum_Aluno.TabIndex = 86;
            this.txtNum_Aluno.Text = "Número";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(3, 133);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(30, 16);
            this.lbl_cep.TabIndex = 85;
            this.lbl_cep.Text = "CEP";
            // 
            // txtEndereco_Aluno
            // 
            this.txtEndereco_Aluno.Location = new System.Drawing.Point(7, 25);
            this.txtEndereco_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndereco_Aluno.Name = "txtEndereco_Aluno";
            this.txtEndereco_Aluno.Size = new System.Drawing.Size(418, 23);
            this.txtEndereco_Aluno.TabIndex = 60;
            this.txtEndereco_Aluno.Text = "Endereço";
            // 
            // txtCep_Aluno
            // 
            this.txtCep_Aluno.Location = new System.Drawing.Point(41, 129);
            this.txtCep_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCep_Aluno.Mask = "00000-000";
            this.txtCep_Aluno.Name = "txtCep_Aluno";
            this.txtCep_Aluno.Size = new System.Drawing.Size(116, 23);
            this.txtCep_Aluno.TabIndex = 84;
            // 
            // txtComp_Aluno
            // 
            this.txtComp_Aluno.Location = new System.Drawing.Point(7, 91);
            this.txtComp_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComp_Aluno.Name = "txtComp_Aluno";
            this.txtComp_Aluno.Size = new System.Drawing.Size(179, 23);
            this.txtComp_Aluno.TabIndex = 61;
            this.txtComp_Aluno.Text = "Complemento";
            // 
            // txtCidade_Aluno
            // 
            this.txtCidade_Aluno.Location = new System.Drawing.Point(194, 91);
            this.txtCidade_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCidade_Aluno.Name = "txtCidade_Aluno";
            this.txtCidade_Aluno.Size = new System.Drawing.Size(231, 23);
            this.txtCidade_Aluno.TabIndex = 47;
            this.txtCidade_Aluno.Text = "Cidade";
            // 
            // cmbUf_Aluno
            // 
            this.cmbUf_Aluno.FormattingEnabled = true;
            this.cmbUf_Aluno.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PR",
            "PB",
            "PA",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cmbUf_Aluno.Location = new System.Drawing.Point(166, 129);
            this.cmbUf_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUf_Aluno.Name = "cmbUf_Aluno";
            this.cmbUf_Aluno.Size = new System.Drawing.Size(47, 24);
            this.cmbUf_Aluno.TabIndex = 48;
            this.cmbUf_Aluno.Text = "UF";
            // 
            // grpSaude_Aluno
            // 
            this.grpSaude_Aluno.BackColor = System.Drawing.Color.Transparent;
            this.grpSaude_Aluno.Controls.Add(this.grpMedico_Aluno);
            this.grpSaude_Aluno.Controls.Add(this.txtObs_Aluno);
            this.grpSaude_Aluno.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSaude_Aluno.Location = new System.Drawing.Point(919, 557);
            this.grpSaude_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSaude_Aluno.Name = "grpSaude_Aluno";
            this.grpSaude_Aluno.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSaude_Aluno.Size = new System.Drawing.Size(644, 222);
            this.grpSaude_Aluno.TabIndex = 91;
            this.grpSaude_Aluno.TabStop = false;
            this.grpSaude_Aluno.Text = "Saúde";
            // 
            // grpMedico_Aluno
            // 
            this.grpMedico_Aluno.BackColor = System.Drawing.Color.Transparent;
            this.grpMedico_Aluno.Controls.Add(this.rbPlanoNao_Aluno);
            this.grpMedico_Aluno.Controls.Add(this.rbPlanoSim_Aluno);
            this.grpMedico_Aluno.Location = new System.Drawing.Point(7, 33);
            this.grpMedico_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpMedico_Aluno.Name = "grpMedico_Aluno";
            this.grpMedico_Aluno.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpMedico_Aluno.Size = new System.Drawing.Size(145, 150);
            this.grpMedico_Aluno.TabIndex = 36;
            this.grpMedico_Aluno.TabStop = false;
            this.grpMedico_Aluno.Text = "Plano de Saúde";
            // 
            // rbPlanoNao_Aluno
            // 
            this.rbPlanoNao_Aluno.AutoSize = true;
            this.rbPlanoNao_Aluno.Location = new System.Drawing.Point(7, 55);
            this.rbPlanoNao_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbPlanoNao_Aluno.Name = "rbPlanoNao_Aluno";
            this.rbPlanoNao_Aluno.Size = new System.Drawing.Size(48, 20);
            this.rbPlanoNao_Aluno.TabIndex = 1;
            this.rbPlanoNao_Aluno.Text = "Não";
            this.rbPlanoNao_Aluno.UseVisualStyleBackColor = true;
            // 
            // rbPlanoSim_Aluno
            // 
            this.rbPlanoSim_Aluno.AutoSize = true;
            this.rbPlanoSim_Aluno.Checked = true;
            this.rbPlanoSim_Aluno.Location = new System.Drawing.Point(7, 27);
            this.rbPlanoSim_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbPlanoSim_Aluno.Name = "rbPlanoSim_Aluno";
            this.rbPlanoSim_Aluno.Size = new System.Drawing.Size(48, 20);
            this.rbPlanoSim_Aluno.TabIndex = 0;
            this.rbPlanoSim_Aluno.TabStop = true;
            this.rbPlanoSim_Aluno.Text = "Sim";
            this.rbPlanoSim_Aluno.UseVisualStyleBackColor = true;
            // 
            // txtObs_Aluno
            // 
            this.txtObs_Aluno.Location = new System.Drawing.Point(159, 33);
            this.txtObs_Aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtObs_Aluno.Name = "txtObs_Aluno";
            this.txtObs_Aluno.Size = new System.Drawing.Size(478, 149);
            this.txtObs_Aluno.TabIndex = 38;
            this.txtObs_Aluno.Text = "Observações Médicas ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(580, 57);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 28);
            this.btnDelete.TabIndex = 98;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Alterar_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCM_4_FUN.Properties.Resources.backgroundpadrao;
            this.ClientSize = new System.Drawing.Size(1605, 853);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grpFoto_Aluno);
            this.Controls.Add(this.grpContato_Aluno);
            this.Controls.Add(this.grpDados_Aluno);
            this.Controls.Add(this.grpDocumento_Aluno);
            this.Controls.Add(this.grpMoradia_Aluno);
            this.Controls.Add(this.grpSaude_Aluno);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.dgvAluno);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Alterar_Aluno";
            this.Text = "Alterar Aluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Alterar_Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.grpFoto_Aluno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAluno)).EndInit();
            this.grpContato_Aluno.ResumeLayout(false);
            this.grpContato_Aluno.PerformLayout();
            this.grpDados_Aluno.ResumeLayout(false);
            this.grpDados_Aluno.PerformLayout();
            this.grpSexo_Aluno.ResumeLayout(false);
            this.grpSexo_Aluno.PerformLayout();
            this.grpDocumento_Aluno.ResumeLayout(false);
            this.grpDocumento_Aluno.PerformLayout();
            this.grpMoradia_Aluno.ResumeLayout(false);
            this.grpMoradia_Aluno.PerformLayout();
            this.grpSaude_Aluno.ResumeLayout(false);
            this.grpMedico_Aluno.ResumeLayout(false);
            this.grpMedico_Aluno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Timer tmrAtualiza;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpFoto_Aluno;
        private System.Windows.Forms.Button btnInserir_Aluno;
        private System.Windows.Forms.PictureBox picAluno;
        private System.Windows.Forms.GroupBox grpContato_Aluno;
        private System.Windows.Forms.Label lblCel_Aluno;
        private System.Windows.Forms.MaskedTextBox txtCel_Aluno;
        private System.Windows.Forms.MaskedTextBox txtTel1_Aluno;
        private System.Windows.Forms.MaskedTextBox txtTel2_Aluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpDados_Aluno;
        private System.Windows.Forms.GroupBox grpSexo_Aluno;
        private System.Windows.Forms.RadioButton rdbMasc_Aluno;
        private System.Windows.Forms.RadioButton rdbFem_Aluno;
        private System.Windows.Forms.TextBox txtNom_Aluno;
        private System.Windows.Forms.Label lblNasc_Aluno;
        private System.Windows.Forms.DateTimePicker dtpNasc_Aluno;
        private System.Windows.Forms.GroupBox grpDocumento_Aluno;
        private System.Windows.Forms.TextBox txtOrgao_Aluno;
        private System.Windows.Forms.Label lblOrgao_Aluno;
        private System.Windows.Forms.MaskedTextBox txtRg_Aluno;
        private System.Windows.Forms.Label lblRg_Aluno;
        private System.Windows.Forms.Label lblCpf_Aluno;
        private System.Windows.Forms.MaskedTextBox txtCpf_Aluno;
        private System.Windows.Forms.GroupBox grpMoradia_Aluno;
        private System.Windows.Forms.TextBox txtNum_Aluno;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.TextBox txtEndereco_Aluno;
        private System.Windows.Forms.MaskedTextBox txtCep_Aluno;
        private System.Windows.Forms.TextBox txtComp_Aluno;
        private System.Windows.Forms.TextBox txtCidade_Aluno;
        private System.Windows.Forms.ComboBox cmbUf_Aluno;
        private System.Windows.Forms.GroupBox grpSaude_Aluno;
        private System.Windows.Forms.GroupBox grpMedico_Aluno;
        private System.Windows.Forms.RadioButton rbPlanoNao_Aluno;
        private System.Windows.Forms.RadioButton rbPlanoSim_Aluno;
        private System.Windows.Forms.RichTextBox txtObs_Aluno;
        private System.Windows.Forms.Button btnDelete;
    }
}