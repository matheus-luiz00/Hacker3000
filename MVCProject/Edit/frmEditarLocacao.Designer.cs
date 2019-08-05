namespace MVCProject.Edit
{
    partial class frmEditarLocacao
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxLivro = new System.Windows.Forms.ComboBox();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibliotecaDBDataSet = new MVCProject.SistemaBibliotecaDBDataSet();
            this.livrosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxUsuario = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.UsuariosTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxGenero = new System.Windows.Forms.ComboBox();
            this.generosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.GenerosTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.locacaoTableAdapter1 = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.LocacaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(228, 164);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Locação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Livro";
            // 
            // cboxLivro
            // 
            this.cboxLivro.BackColor = System.Drawing.Color.SlateGray;
            this.cboxLivro.DataSource = this.livrosBindingSource;
            this.cboxLivro.DisplayMember = "Titulo";
            this.cboxLivro.ForeColor = System.Drawing.Color.White;
            this.cboxLivro.FormattingEnabled = true;
            this.cboxLivro.Location = new System.Drawing.Point(83, 57);
            this.cboxLivro.Name = "cboxLivro";
            this.cboxLivro.Size = new System.Drawing.Size(220, 21);
            this.cboxLivro.TabIndex = 6;
            this.cboxLivro.ValueMember = "Id";
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Usuario";
            // 
            // cboxUsuario
            // 
            this.cboxUsuario.BackColor = System.Drawing.Color.SlateGray;
            this.cboxUsuario.DataSource = this.usuariosBindingSource;
            this.cboxUsuario.DisplayMember = "Login";
            this.cboxUsuario.ForeColor = System.Drawing.Color.White;
            this.cboxUsuario.FormattingEnabled = true;
            this.cboxUsuario.Location = new System.Drawing.Point(83, 84);
            this.cboxUsuario.Name = "cboxUsuario";
            this.cboxUsuario.Size = new System.Drawing.Size(220, 21);
            this.cboxUsuario.TabIndex = 12;
            this.cboxUsuario.ValueMember = "Id";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Gênero";
            // 
            // cboxGenero
            // 
            this.cboxGenero.BackColor = System.Drawing.Color.SlateGray;
            this.cboxGenero.DataSource = this.generosBindingSource;
            this.cboxGenero.DisplayMember = "Tipo";
            this.cboxGenero.ForeColor = System.Drawing.Color.White;
            this.cboxGenero.FormattingEnabled = true;
            this.cboxGenero.Location = new System.Drawing.Point(83, 111);
            this.cboxGenero.Name = "cboxGenero";
            this.cboxGenero.Size = new System.Drawing.Size(220, 21);
            this.cboxGenero.TabIndex = 14;
            this.cboxGenero.ValueMember = "Id";
            // 
            // generosBindingSource
            // 
            this.generosBindingSource.DataMember = "Generos";
            this.generosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // generosTableAdapter
            // 
            this.generosTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Devolução";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // locacaoTableAdapter1
            // 
            this.locacaoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmEditarLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 197);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxGenero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxUsuario);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxLivro);
            this.Name = "frmEditarLocacao";
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.FrmEditarLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxLivro;
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxUsuario;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxGenero;
        private System.Windows.Forms.BindingSource generosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.GenerosTableAdapter generosTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private SistemaBibliotecaDBDataSetTableAdapters.LocacaoTableAdapter locacaoTableAdapter1;
    }
}