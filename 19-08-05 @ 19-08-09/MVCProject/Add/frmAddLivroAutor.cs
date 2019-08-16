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
    public partial class frmAddLivroAutor : Form
    {
        public frmAddLivroAutor()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            LivroAutor add = new LivroAutor();
            add.Autor = (int) cboxAutor.SelectedValue;
            add.Livro = (int)cboxLivro.SelectedValue;

            livroAutorTableAdapter1.Insert(
                add.Livro,
                add.Autor
                );

            this.Close();
        }

        private void FrmAddLivroAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.livrosTableAdapter1.Fill(this.sistemaBibliotecaDBDataSet.Livros);
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);

        }
    }
}
