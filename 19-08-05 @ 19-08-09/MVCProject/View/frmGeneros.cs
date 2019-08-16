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
    public partial class frmGeneros : Form
    {
        public frmGeneros()
        {
            InitializeComponent();
        }

        private void FrmGeneros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddGenero frmAdd = new frmAddGenero();
            frmAdd.ShowDialog();
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
        }

        MVCProject.SistemaBibliotecaDBDataSet.GenerosRow rowSelecionada;

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(!(e.RowIndex == -1))
            rowSelecionada = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.GenerosRow;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (rowSelecionada != null)
            {
            frmEditarGeneros telaEditar = new frmEditarGeneros();
            telaEditar.generosRow = rowSelecionada;
            telaEditar.ShowDialog();
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
            }
            else
                MessageBox.Show("Selecione um registro para alterar");

        }
    }
}
