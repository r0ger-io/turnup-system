namespace TCM_4_FUN
{
    partial class Excluir_Aluno
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(474, 43);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 28);
            this.btnDelete.TabIndex = 110;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Código",
            "Nome"});
            this.cmbFiltro.Location = new System.Drawing.Point(66, 45);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(140, 24);
            this.cmbFiltro.TabIndex = 103;
            this.cmbFiltro.Text = "Filtrar";
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(212, 45);
            this.txtSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(116, 23);
            this.txtSelect.TabIndex = 100;
            // 
            // dgvAluno
            // 
            this.dgvAluno.AllowUserToAddRows = false;
            this.dgvAluno.AllowUserToDeleteRows = false;
            this.dgvAluno.AllowUserToResizeColumns = false;
            this.dgvAluno.AllowUserToResizeRows = false;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(23, 97);
            this.dgvAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.ReadOnly = true;
            this.dgvAluno.Size = new System.Drawing.Size(861, 380);
            this.dgvAluno.TabIndex = 99;
            this.dgvAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluno_CellClick);
            this.dgvAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluno_CellContentClick);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(356, 43);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(87, 28);
            this.btnPesquisa.TabIndex = 101;
            this.btnPesquisa.Text = "Procurar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(597, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 23);
            this.textBox1.TabIndex = 111;
            // 
            // Excluir_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 506);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.dgvAluno);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Excluir_Aluno";
            this.Text = "Excluir_Aluno";
            this.Load += new System.EventHandler(this.Excluir_Aluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox textBox1;

    }
}