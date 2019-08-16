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
    public partial class frmEditarLocacao : Form
    {
        public frmEditarLocacao()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow locacaoRow;
        private void FrmEditarLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

            cboxGenero.SelectedValue = locacaoRow.Tipo;
            cboxLivro.SelectedValue = locacaoRow.Livro;
            cboxUsuario.SelectedValue = locacaoRow.Usuario;
            dateTimePicker1.Value = locacaoRow.Devolucao;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Locacao editar = new Locacao();
            editar.Id = locacaoRow.Id;
            editar.Tipo = (int)cboxGenero.SelectedValue;
            editar.Livro =(int) cboxLivro.SelectedValue;
            editar.Usuario = (int)cboxUsuario.SelectedValue;
            editar.Devolucao = dateTimePicker1.Value;
            editar.DatAlt = DateTime.Now;
            editar.UsuAlt = Session.usu.Id;

            locacaoTableAdapter1.UpdateQuery(
                editar.Livro,
                editar.Usuario,
                editar.Tipo,
                editar.Devolucao,
                editar.Ativo,
                editar.UsuAlt,
                editar.DatAlt,
                editar.Id);
            this.Close();
        }
    }
}
