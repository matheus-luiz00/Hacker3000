namespace MVCProject.Add
{
    partial class frmAddLocacao
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxGenero = new System.Windows.Forms.ComboBox();
            this.cboxUsuario = new System.Windows.Forms.ComboBox();
            this.cboxLivro = new System.Windows.Forms.ComboBox();
            this.locacaoTableAdapter1 = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.LocacaoTableAdapter();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Devolução";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Gênero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Usuario";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(226, 153);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 21;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Locacao";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Livro";
            // 
            // cboxGenero
            // 
            this.cboxGenero.BackColor = System.Drawing.Color.SlateGray;
            this.cboxGenero.DisplayMember = "Tipo";
            this.cboxGenero.ForeColor = System.Drawing.Color.White;
            this.cboxGenero.FormattingEnabled = true;
            this.cboxGenero.Location = new System.Drawing.Point(81, 100);
            this.cboxGenero.Name = "cboxGenero";
            this.cboxGenero.Size = new System.Drawing.Size(220, 21);
            this.cboxGenero.TabIndex = 24;
            this.cboxGenero.ValueMember = "Id";
            // 
            // cboxUsuario
            // 
            this.cboxUsuario.BackColor = System.Drawing.Color.SlateGray;
            this.cboxUsuario.DisplayMember = "Login";
            this.cboxUsuario.ForeColor = System.Drawing.Color.White;
            this.cboxUsuario.FormattingEnabled = true;
            this.cboxUsuario.Location = new System.Drawing.Point(81, 73);
            this.cboxUsuario.Name = "cboxUsuario";
            this.cboxUsuario.Size = new System.Drawing.Size(220, 21);
            this.cboxUsuario.TabIndex = 22;
            this.cboxUsuario.ValueMember = "Id";
            // 
            // cboxLivro
            // 
            this.cboxLivro.BackColor = System.Drawing.Color.SlateGray;
            this.cboxLivro.DisplayMember = "Titulo";
            this.cboxLivro.ForeColor = System.Drawing.Color.White;
            this.cboxLivro.FormattingEnabled = true;
            this.cboxLivro.Location = new System.Drawing.Point(81, 46);
            this.cboxLivro.Name = "cboxLivro";
            this.cboxLivro.Size = new System.Drawing.Size(220, 21);
            this.cboxLivro.TabIndex = 18;
            this.cboxLivro.ValueMember = "Id";
            // 
            // locacaoTableAdapter1
            // 
            this.locacaoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmAddLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 188);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxGenero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxUsuario);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxLivro);
            this.Name = "frmAddLocacao";
            this.Text = "frmAddLocacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxGenero;
        private System.Windows.Forms.ComboBox cboxUsuario;
        private System.Windows.Forms.ComboBox cboxLivro;
        private SistemaBibliotecaDBDataSetTableAdapters.LocacaoTableAdapter locacaoTableAdapter1;
    }
}