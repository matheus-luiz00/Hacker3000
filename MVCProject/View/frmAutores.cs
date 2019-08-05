using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCProject.Add;
using MVCProject.Edit;

namespace MVCProject.View
{
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddAutores frmAdd = new frmAddAutores();
            frmAdd.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmEditarAutores editar = new frmEditarAutores();
            editar.edicao = colunaSelecionada;
            editar.ShowDialog();
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
        }

        MVCProject.SistemaBibliotecaDBDataSet.AutoresRow colunaSelecionada;

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            colunaSelecionada = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.AutoresRow;

            /*
            switch (e.ColumnIndex)
            {
                /*
                case 0:
                    {
                        this.autoresTableAdapter.DeleteQuery(colunaSelecionada.Id);
                        break;
                    }
                case 0:
                    {
                        frmEditarAutores editar = new frmEditarAutores();
                        editar.edicao = colunaSelecionada;
                        editar.ShowDialog();
                        break;
                    }

            }*/

        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            colunaSelecionada = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.AutoresRow;
        }
    }
}
