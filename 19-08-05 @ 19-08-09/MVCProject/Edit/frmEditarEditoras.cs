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
    public partial class frmEditarEditoras : Form
    {
        public frmEditarEditoras()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.EditorasRow edicao;

        private void FrmEditarEditoras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            
            textBox1.Text = edicao.Nome;
            txtNome.Text = edicao.Descricao;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Editora editar = new Editora();
            editar.Id = edicao.Id;
            editar.Nome = edicao.Nome;
            editar.Descricao = edicao.Descricao;

            if (!string.IsNullOrEmpty(editar.Nome))
            {
                editorasTableAdapter.UpdateQuery(
                    editar.Nome,
                    editar.Descricao,
                    editar.Id);

                this.Close();

            }
        }
    }
}
