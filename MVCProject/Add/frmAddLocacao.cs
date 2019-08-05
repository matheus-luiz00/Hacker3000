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
    public partial class frmAddLocacao : Form
    {
        public frmAddLocacao()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Locacao add = new Locacao();
            add.Livro =(int)cboxLivro.SelectedValue;
            add.Usuario = (int)cboxUsuario.SelectedValue;
            add.Tipo = (int)cboxGenero.SelectedValue;
            add.Devolucao = dateTimePicker1.Value;
            add.UsuAlt = Session.usu.Id;
            add.UsuInc = Session.usu.Id;

            locacaoTableAdapter1.Insert(
                add.Livro,
                add.Usuario,
                add.Tipo,
                add.Devolucao,
                add.Ativo,
                add.UsuInc,
                add.UsuAlt,
                add.DatInc,
                add.DatAlt
                );

            this.Close();
        }

        private void FrmAddLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.LivroAutor' table. You can move, or remove it, as needed.
            this.livroAutorTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.LivroAutor);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

        }
    }
}
