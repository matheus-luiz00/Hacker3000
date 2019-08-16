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
    public partial class frmEditarAutores : Form
    {
        public frmEditarAutores()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.AutoresRow edicao;

        private void FrmEditarAutores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            textBox2.Text = edicao.Nome;
            textBox1.Text = edicao.Descricao;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Autor editar = new Autor();
            editar.Id = edicao.Id;
            editar.Nome = textBox2.Text;
            editar.Descricao = textBox1.Text;

            if (!string.IsNullOrEmpty(editar.Nome))
            {
                autoresTableAdapter.UpdateQuery(
                    editar.Nome,
                    editar.Descricao,
                    editar.Id
                    );
                this.Close();
            }

        }
    }
}
