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
    public partial class frmLivroAutor : Form
    {
        public frmLivroAutor()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow livrosRow;
        private void FrmLivroAutor_Load(object sender, EventArgs e)
        {
            livroAutorTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.LivroAutor, livrosRow.Id);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddLivroAutor frmAdd = new frmAddLivroAutor();
            frmAdd.ShowDialog();
            this.dataTable1TableAdapter.Fill(this.sistemaBibliotecaDBDataSet.DataTable1);
        }

        MVCProject.SistemaBibliotecaDBDataSet.DataTable1Row rowSelecionada;

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(e.RowIndex == -1))
                rowSelecionada = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.DataTable1Row;
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (rowSelecionada != null)
            {
                frmEditarLivroAutor telaEditar = new frmEditarLivroAutor();
                telaEditar.livroautorRow = rowSelecionada;
                telaEditar.ShowDialog();
                this.dataTable1TableAdapter.Fill(this.sistemaBibliotecaDBDataSet.DataTable1);
            } else
                MessageBox.Show("Selecione um registro para alterar");

        }

    }
}
