namespace TCM_4_FUN
{
    partial class Cadastro_Livro
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
            this.txtCod_Livro = new System.Windows.Forms.TextBox();
            this.txtNome_Livro = new System.Windows.Forms.TextBox();
            this.txtAutor_Livro = new System.Windows.Forms.TextBox();
            this.txtIdioma_Livro = new System.Windows.Forms.TextBox();
            this.txtAssunto_Livro = new System.Windows.Forms.TextBox();
            this.txtEditora_Livro = new System.Windows.Forms.TextBox();
            this.picCapa_Livro = new System.Windows.Forms.PictureBox();
            this.btnInserir_Livro = new System.Windows.Forms.Button();
            this.txtPrefacio_Livro = new System.Windows.Forms.RichTextBox();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCapa = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCapa_Livro)).BeginInit();
            this.grpCapa.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCod_Livro
            // 
            this.txtCod_Livro.Enabled = false;
            this.txtCod_Livro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod_Livro.Location = new System.Drawing.Point(87, 16);
            this.txtCod_Livro.Name = "txtCod_Livro";
            this.txtCod_Livro.Size = new System.Drawing.Size(97, 23);
            this.txtCod_Livro.TabIndex = 1;
            this.txtCod_Livro.TextChanged += new System.EventHandler(this.txtCod_Livro_TextChanged);
            // 
            // txtNome_Livro
            // 
            this.txtNome_Livro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome_Livro.Location = new System.Drawing.Point(75, 67);
            this.txtNome_Livro.Name = "txtNome_Livro";
            this.txtNome_Livro.Size = new System.Drawing.Size(360, 23);
            this.txtNome_Livro.TabIndex = 4;
            this.txtNome_Livro.Text = "Nome do Livro";
            this.txtNome_Livro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtbox_nomelivro_MouseClick);
            // 
            // txtAutor_Livro
            // 
            this.txtAutor_Livro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor_Livro.Location = new System.Drawing.Point(75, 96);
            this.txtAutor_Livro.Name = "txtAutor_Livro";
            this.txtAutor_Livro.Size = new System.Drawing.Size(360, 23);
            this.txtAutor_Livro.TabIndex = 5;
            this.txtAutor_Livro.Text = "Autor(es)";
            this.txtAutor_Livro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtbox_autor_MouseClick);
            // 
            // txtIdioma_Livro
            // 
            this.txtIdioma_Livro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdioma_Livro.Location = new System.Drawing.Point(75, 183);
            this.txtIdioma_Livro.Name = "txtIdioma_Livro";
            this.txtIdioma_Livro.Size = new System.Drawing.Size(360, 23);
            this.txtIdioma_Livro.TabIndex = 9;
            this.txtIdioma_Livro.Text = "Idioma";
            this.txtIdioma_Livro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtbox_idioma_MouseClick);
            // 
            // txtAssunto_Livro
            // 
            this.txtAssunto_Livro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto_Livro.Location = new System.Drawing.Point(75, 154);
            this.txtAssunto_Livro.Name = "txtAssunto_Livro";
            this.txtAssunto_Livro.Size = new System.Drawing.Size(360, 23);
            this.txtAssunto_Livro.TabIndex = 8;
            this.txtAssunto_Livro.Text = "Assunto";
            this.txtAssunto_Livro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_assunto_MouseClick);
            // 
            // txtEditora_Livro
            // 
            this.txtEditora_Livro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora_Livro.Location = new System.Drawing.Point(75, 125);
            this.txtEditora_Livro.Name = "txtEditora_Livro";
            this.txtEditora_Livro.Size = new System.Drawing.Size(360, 23);
            this.txtEditora_Livro.TabIndex = 7;
            this.txtEditora_Livro.Text = "Editora";
            this.txtEditora_Livro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtbox_editora_MouseClick);
            // 
            // picCapa_Livro
            // 
            this.picCapa_Livro.Location = new System.Drawing.Point(7, 19);
            this.picCapa_Livro.Name = "picCapa_Livro";
            this.picCapa_Livro.Size = new System.Drawing.Size(250, 400);
            this.picCapa_Livro.TabIndex = 10;
            this.picCapa_Livro.TabStop = false;
            // 
            // btnInserir_Livro
            // 
            this.btnInserir_Livro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir_Livro.Location = new System.Drawing.Point(87, 425);
            this.btnInserir_Livro.Name = "btnInserir_Livro";
            this.btnInserir_Livro.Size = new System.Drawing.Size(107, 25);
            this.btnInserir_Livro.TabIndex = 11;
            this.btnInserir_Livro.Text = "Inserir Capa";
            this.btnInserir_Livro.UseVisualStyleBackColor = true;
            this.btnInserir_Livro.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // txtPrefacio_Livro
            // 
            this.txtPrefacio_Livro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrefacio_Livro.Location = new System.Drawing.Point(75, 212);
            this.txtPrefacio_Livro.Name = "txtPrefacio_Livro";
            this.txtPrefacio_Livro.Size = new System.Drawing.Size(360, 122);
            this.txtPrefacio_Livro.TabIndex = 39;
            this.txtPrefacio_Livro.Text = "Prefácio do Livro";
            this.txtPrefacio_Livro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtxtbox_prefacio_MouseClick);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar.Location = new System.Drawing.Point(79, 475);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(148, 32);
            this.bt_salvar.TabIndex = 40;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(260, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 32);
            this.button2.TabIndex = 41;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Código";
            // 
            // grpCapa
            // 
            this.grpCapa.Controls.Add(this.picCapa_Livro);
            this.grpCapa.Controls.Add(this.btnInserir_Livro);
            this.grpCapa.Location = new System.Drawing.Point(485, 16);
            this.grpCapa.Name = "grpCapa";
            this.grpCapa.Size = new System.Drawing.Size(263, 455);
            this.grpCapa.TabIndex = 43;
            this.grpCapa.TabStop = false;
            this.grpCapa.Text = "Capa";
            // 
            // Cadastro_Livro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::TCM_4_FUN.Properties.Resources.backgroundpadrao;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1376, 693);
            this.Controls.Add(this.grpCapa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.txtPrefacio_Livro);
            this.Controls.Add(this.txtIdioma_Livro);
            this.Controls.Add(this.txtAssunto_Livro);
            this.Controls.Add(this.txtEditora_Livro);
            this.Controls.Add(this.txtAutor_Livro);
            this.Controls.Add(this.txtNome_Livro);
            this.Controls.Add(this.txtCod_Livro);
            this.DoubleBuffered = true;
            this.Name = "Cadastro_Livro";
            this.Text = "Cadastro_Livro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cadastro_Livro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCapa_Livro)).EndInit();
            this.grpCapa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod_Livro;
        private System.Windows.Forms.TextBox txtNome_Livro;
        private System.Windows.Forms.TextBox txtAutor_Livro;
        private System.Windows.Forms.TextBox txtIdioma_Livro;
        private System.Windows.Forms.TextBox txtAssunto_Livro;
        private System.Windows.Forms.TextBox txtEditora_Livro;
        private System.Windows.Forms.PictureBox picCapa_Livro;
        private System.Windows.Forms.Button btnInserir_Livro;
        private System.Windows.Forms.RichTextBox txtPrefacio_Livro;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCapa;
    }
}