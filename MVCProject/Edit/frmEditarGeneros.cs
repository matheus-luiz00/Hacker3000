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
    public partial class frmEditarGeneros : Form
    {
        public frmEditarGeneros()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.GenerosRow generosRow;
        private void FrmEditarGeneros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            textNome.Text = generosRow.Tipo;
            textDesc.Text = generosRow.Descricao;


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Genero editar = new Genero();
            editar.Id = generosRow.Id;
            editar.Tipo = textNome.Text;
            editar.Descricao = textDesc.Text;

            if (!string.IsNullOrEmpty(editar.Tipo))
            {
                generosTableAdapter.UpdateQuery(
                    editar.Tipo,
                    editar.Descricao,
                    editar.Id
                    );
                this.Close();
            }
        }
    }
}
