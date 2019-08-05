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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddUsuarios frmAdd = new frmAddUsuarios();
            frmAdd.ShowDialog();
        }
        MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow rowSelecionada;
        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowSelecionada = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmEditarUsuarios telaEditar = new frmEditarUsuarios();
            telaEditar.usuariosRow = rowSelecionada;
            telaEditar.ShowDialog();
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            usuariosTableAdapter.DeleteQuery(rowSelecionada.Id);
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);

        }
    }
}
