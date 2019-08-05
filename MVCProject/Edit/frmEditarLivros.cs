using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCProject.Model;

namespace MVCProject.Edit
{
    public partial class frmEditarLivros : Form
    {
        public frmEditarLivros()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow livrosRow;
        private void FrmEditarLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            txtNome.Text = livrosRow.Titulo;
            txtIsbn.Text = livrosRow.Isbn;
            txtObs.Text = livrosRow.Observacoes;
            txtSinopse.Text = livrosRow.Sinopse;
            nmRegistro.Value = livrosRow.Registro;
            cboxEditora.SelectedValue = livrosRow.Editora;
            cboxGenero.SelectedValue = livrosRow.Genero;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Livro editar = new Livro();
            editar.Id = livrosRow.Id;
            editar.Titulo = txtNome.Text;
            editar.Isbn = txtIsbn.Text;
            editar.Observacoes = txtObs.Text;
            editar.Sinopse = txtSinopse.Text;
            editar.Registro = (int)nmRegistro.Value;
            editar.Editora =(int) cboxEditora.SelectedValue;
            editar.Genero = (int)cboxGenero.SelectedValue;
            editar.DatAlt = DateTime.Now;
            editar.UsuAlt = Session.usu.Id;

            livrosTableAdapter1.UpdateQuery(
                editar.Registro,
                editar.Titulo,
                editar.Isbn,
                editar.Genero ,
                editar.Editora ,
                editar.Sinopse,
                editar.Observacoes,
                editar.UsuAlt,
                editar.DatAlt,
                editar.Id
                );

            this.Close();
        }
    }
}
