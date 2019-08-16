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
    public partial class frmEditoras : Form
    {
        public frmEditoras()
        {
            InitializeComponent();
        }

        private void FrmEditoras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddEditoras frmAdd = new frmAddEditoras();
            frmAdd.ShowDialog();
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
        }

        MVCProject.SistemaBibliotecaDBDataSet.EditorasRow colunaSelecionada;

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex == -1))
                colunaSelecionada = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.EditorasRow;

           
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(e.RowIndex == -1))
                colunaSelecionada = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.EditorasRow;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (colunaSelecionada != null)
            {
            frmEditarEditoras editar = new frmEditarEditoras();
            editar.edicao = colunaSelecionada;
            editar.ShowDialog();
            }
            else
                MessageBox.Show("Selecione um registro para alterar");
        }
    }
}
