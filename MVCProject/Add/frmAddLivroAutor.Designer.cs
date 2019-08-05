namespace MVCProject.Add
{
    partial class frmAddLivroAutor
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboxAutor = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxLivro = new System.Windows.Forms.ComboBox();
            this.livrosTableAdapter1 = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter();
            this.livroAutorTableAdapter1 = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.LivroAutorTableAdapter();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Autor";
            // 
            // cboxAutor
            // 
            this.cboxAutor.BackColor = System.Drawing.Color.SlateGray;
            this.cboxAutor.DisplayMember = "Nome";
            this.cboxAutor.ForeColor = System.Drawing.Color.White;
            this.cboxAutor.FormattingEnabled = true;
            this.cboxAutor.Location = new System.Drawing.Point(56, 77);
            this.cboxAutor.Name = "cboxAutor";
            this.cboxAutor.Size = new System.Drawing.Size(220, 21);
            this.cboxAutor.TabIndex = 18;
            this.cboxAutor.ValueMember = "Id";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(201, 104);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Autor do Livro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Livro";
            // 
            // cboxLivro
            // 
            this.cboxLivro.BackColor = System.Drawing.Color.SlateGray;
            this.cboxLivro.DisplayMember = "Titulo";
            this.cboxLivro.ForeColor = System.Drawing.Color.White;
            this.cboxLivro.FormattingEnabled = true;
            this.cboxLivro.Location = new System.Drawing.Point(56, 50);
            this.cboxLivro.Name = "cboxLivro";
            this.cboxLivro.Size = new System.Drawing.Size(220, 21);
            this.cboxLivro.TabIndex = 14;
            this.cboxLivro.ValueMember = "Id";
            // 
            // livrosTableAdapter1
            // 
            this.livrosTableAdapter1.ClearBeforeFill = true;
            // 
            // livroAutorTableAdapter1
            // 
            this.livroAutorTableAdapter1.ClearBeforeFill = true;
            // 
            // frmAddLivroAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(287, 136);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxAutor);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxLivro);
            this.Name = "frmAddLivroAutor";
            this.Text = "frmAddLivroAutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxAutor;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxLivro;
        private SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter1;
        private SistemaBibliotecaDBDataSetTableAdapters.LivroAutorTableAdapter livroAutorTableAdapter1;
    }
}