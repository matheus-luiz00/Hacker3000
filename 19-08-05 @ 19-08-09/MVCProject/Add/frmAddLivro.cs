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

namespace MVCProject.Add
{
    public partial class frmAddLivro : Form
    {
        public frmAddLivro()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Livro add = new Livro();
            add.Titulo = txtNome.Text;
            add.Editora = (int) cboxEditora.SelectedValue;
            add.Registro = (int)nmRegistro.Value;
            add.Genero = (int)cboxGenero.SelectedValue;
            add.Isbn = txtIsbn.Text;
            add.Sinopse = txtSinopse.Text;
            add.Observacoes = txtObs.Text;
            add.UsuAlt = Session.usu.Id;
            add.UsuInc = Session.usu.Id;

            livrosTableAdapter1.Insert(
                add.Registro,
                add.Titulo,
                add.Isbn,
                add.Genero,
                add.Editora,
                add.Sinopse,
                add.Observacoes,
                add.UsuInc,
                add.UsuAlt,
                add.DatInc,
                add.DatAlt
                );
            this.Close();
        }

        private void FrmAddLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

        }
    }
}
