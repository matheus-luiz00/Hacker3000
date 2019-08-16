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
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void FrmLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddLocacao frmAdd = new frmAddLocacao();
            frmAdd.ShowDialog();
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);
        }
        MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow rowSelecionada;
        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(e.RowIndex == -1))
                rowSelecionada = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (rowSelecionada != null)
            {
            frmEditarLocacao telaEditar = new frmEditarLocacao();
            telaEditar.locacaoRow = rowSelecionada;
            telaEditar.ShowDialog();
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);
            }
            else
                MessageBox.Show("Selecione um registro para alterar");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            locacaoTableAdapter.DeleteQuery(rowSelecionada.Id);
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);
        }
    }
}
